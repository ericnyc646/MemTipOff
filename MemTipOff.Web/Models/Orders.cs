using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderLineDetail = new HashSet<OrderLineDetail>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserIpaddress { get; set; }
        public string BillingStreetAddress1 { get; set; }
        public string BillingStreetAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingStateProvince { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingMethod { get; set; }
        public string ApprovalCode { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal Total { get; set; }

        public ICollection<OrderLineDetail> OrderLineDetail { get; set; }
    }
}
