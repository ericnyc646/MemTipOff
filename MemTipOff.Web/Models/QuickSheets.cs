using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class QuickSheets
    {
        //public QuickSheets()
        //{
        //    QuickSheetRatings = new HashSet<QuickSheetRatings>();
        //    QuickSheetViews = new HashSet<QuickSheetViews>();
        //}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Attribution { get; set; }
        public string Json { get; set; }

        //public QstoTechnologies QstoTechnologies { get; set; }
        //public ICollection<QuickSheetRatings> QuickSheetRatings { get; set; }
        //public ICollection<QuickSheetViews> QuickSheetViews { get; set; }
    }
}
