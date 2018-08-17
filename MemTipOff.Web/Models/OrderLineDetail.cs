using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class OrderLineDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int QuickSheetId { get; set; }
        public decimal Price { get; set; }

        public Orders Order { get; set; }
    }
}
