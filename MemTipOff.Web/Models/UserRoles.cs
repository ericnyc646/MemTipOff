using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class UserRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsTemporary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //public UserRoleDefinition Role { get; set; }
        //public Users User { get; set; }
    }
}
