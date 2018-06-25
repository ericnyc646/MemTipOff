using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class QstoTechnologies
    {
        public int Id { get; set; }
        public int QuickSheetId { get; set; }
        public int TechnologyId { get; set; }

        public QuickSheets IdNavigation { get; set; }
        public Technologies Technology { get; set; }
    }
}
