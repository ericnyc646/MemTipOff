using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Faqs
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Faqname { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int DisplayOrder { get; set; }
        public bool? DisplayItem { get; set; }

        public Faqcategories Category { get; set; }
    }
}
