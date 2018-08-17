using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class UserPurchaseHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuickSheetId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal? PricePaid { get; set; }
        public int? OrderNumber { get; set; }

        public QuickSheets QuickSheet { get; set; }
        
    }
}
