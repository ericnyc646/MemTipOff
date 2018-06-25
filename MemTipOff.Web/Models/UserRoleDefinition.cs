using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class UserRoleDefinition
    {
        public UserRoleDefinition()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAuthor { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
