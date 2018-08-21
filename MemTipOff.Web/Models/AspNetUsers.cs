using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            Customers = new HashSet<Customers>();
            UserPurchaseHistory = new HashSet<UserPurchaseHistory>();
        }

        public string Id { get; set; }
        public int? AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public long? FacebookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string PictureUrl { get; set; }
        public string SecurityStamp { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public string UserName { get; set; }

        public ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<UserPurchaseHistory> UserPurchaseHistory { get; set; }
    }
}
