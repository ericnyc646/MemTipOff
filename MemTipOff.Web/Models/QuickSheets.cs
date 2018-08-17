using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class QuickSheets
    {
        public QuickSheets()
        {
            Pricing = new HashSet<Pricing>();
            QuickSheetRatings = new HashSet<QuickSheetRatings>();
            QuickSheetViews = new HashSet<QuickSheetViews>();
            UserPurchaseHistory = new HashSet<UserPurchaseHistory>();
        }

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Attribution { get; set; }
        public string Json { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public QstoTechnologies QstoTechnologies { get; set; }
        public ICollection<Pricing> Pricing { get; set; }
        public ICollection<QuickSheetRatings> QuickSheetRatings { get; set; }
        public ICollection<QuickSheetViews> QuickSheetViews { get; set; }
        public ICollection<UserPurchaseHistory> UserPurchaseHistory { get; set; }
    }
}
