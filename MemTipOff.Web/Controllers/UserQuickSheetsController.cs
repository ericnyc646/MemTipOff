using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MemTipOff.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MemTipOff.Web.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserQuickSheetsController : Controller
    {
        private readonly ClaimsPrincipal _caller;
        private readonly AuthDbContext _appDbContext;
        private readonly memorytipoffdbContext _dbcontext;

        public UserQuickSheetsController(UserManager<AppUser> userManager, AuthDbContext appDbContext, IHttpContextAccessor httpContextAccessor, memorytipoffdbContext dbcontext) {
            _caller = httpContextAccessor.HttpContext.User;
            _appDbContext = appDbContext;
            _dbcontext = dbcontext;
        }

        // GET api/UserQuickSheets/GetUserSheets
        [HttpGet]
        public async Task<IActionResult> GetUserSheets()
        {
            var userId = _caller.Claims.Single(c => c.Type == "id");
            //var userId = "f9e42395-b1ed-4528-bcb0-b66904c68f41";

            DataTable dt = new DataTable();
            using (SqlConnection sqlconn = new SqlConnection(_dbcontext.Database.GetDbConnection().ConnectionString)) {
                string sql = "spUserMyQuicksheets";
                using (SqlCommand sqlcmd = new SqlCommand(sql, sqlconn)) {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@UserId", userId);
                    sqlconn.Open();
                    using (SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd)) {
                        adapt.Fill(dt);
                    }
                }
            }

            return new OkObjectResult(dt);
        }
    }
}