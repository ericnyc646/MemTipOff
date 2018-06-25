using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Users
    {
        public Users()
        {
            QuickSheetRatings = new HashSet<QuickSheetRatings>();
            QuickSheetViews = new HashSet<QuickSheetViews>();
            UserPurchaseHistory = new HashSet<UserPurchaseHistory>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<QuickSheetRatings> QuickSheetRatings { get; set; }
        public ICollection<QuickSheetViews> QuickSheetViews { get; set; }
        public ICollection<UserPurchaseHistory> UserPurchaseHistory { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
