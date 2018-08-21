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
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : Controller
    {
        private readonly ClaimsPrincipal _caller;
        private readonly AuthDbContext _appDbContext;
        private readonly memorytipoffdbContext _dbcontext;

        public FAQController(UserManager<AppUser> userManager, AuthDbContext appDbContext, IHttpContextAccessor httpContextAccessor, memorytipoffdbContext dbcontext)
        {
            _caller = httpContextAccessor.HttpContext.User;
            _appDbContext = appDbContext;
            _dbcontext = dbcontext;
        }

        // GET: api/FAQ/GetFaqs
        [HttpGet]
        public async Task<IActionResult> GetFaqs() {

            List<Faqcategories> faq = new List<Faqcategories>();

            var categories = _dbcontext.Faqcategories.Where(a => a.DisplayCategory == true).OrderBy(b=>b.DisplayOrder).ToList();

            foreach (var item in categories) {

                var faqentriesfromdb = _dbcontext.Faqs.Where(a => a.CategoryId == item.Id && a.DisplayItem == true).OrderBy(b => b.DisplayOrder).ToList();
                List<Faqs> faqset = new List<Faqs>();

                foreach (var faqitem in faqentriesfromdb) {
                    faqset.Add(new Faqs {
                        Id = faqitem.Id,
                        CategoryId = faqitem.CategoryId,
                        Faqname = faqitem.Faqname,
                        Question = faqitem.Question,
                        Answer = faqitem.Answer,
                        DisplayOrder = faqitem.DisplayOrder,
                        DisplayItem = faqitem.DisplayItem
                    });
                }
 

                faq.Add(new Faqcategories
                {
                    Id = item.Id,
                    CategoryName = item.CategoryName,
                    DisplayOrder = item.DisplayOrder,
                    DisplayCategory = item.DisplayCategory, 
                    Faqs = faqset
                });
            }

            return new OkObjectResult(faq);
        }
    }
}