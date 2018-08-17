using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Pricing
    {
        public int Id { get; set; }
        public int Qsid { get; set; }
        public decimal Price { get; set; }
        public DateTime PriceStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public bool CurrentPermanentPrice { get; set; }
        public bool ArchivedPrice { get; set; }

        public QuickSheets Qs { get; set; }
    }
}
