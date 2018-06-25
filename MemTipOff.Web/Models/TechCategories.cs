using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class TechCategories
    {
        public TechCategories()
        {
            Technologies = new HashSet<Technologies>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string FontAwesomeIcon { get; set; }

        public ICollection<Technologies> Technologies { get; set; }
    }
}
