using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Faqcategories
    {
        public Faqcategories()
        {
            Faqs = new HashSet<Faqs>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public bool? DisplayCategory { get; set; }

        public ICollection<Faqs> Faqs { get; set; }
    }
}
