using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class QuickSheetViews
    {
        public int Id { get; set; }
        public int QuickSheetId { get; set; }
        public int UserId { get; set; }
        public string Topic { get; set; }
        public DateTime ViewDateTime { get; set; }

        //public QuickSheets QuickSheet { get; set; }
        //public Users User { get; set; }
    }
}
