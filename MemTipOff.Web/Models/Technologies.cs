using System;
using System.Collections.Generic;

namespace MemTipOff.Web.Models
{
    public partial class Technologies
    {
        public Technologies()
        {
            QstoTechnologies = new HashSet<QstoTechnologies>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public TechCategories Category { get; set; }
        public ICollection<QstoTechnologies> QstoTechnologies { get; set; }
    }
}
