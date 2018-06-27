using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class QuickSheetRatings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuickSheetId { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
        public string RatingTitle { get; set; }
        public string RatingComments { get; set; }

        //public QuickSheets QuickSheet { get; set; }
        //public Users User { get; set; }
    }
}
