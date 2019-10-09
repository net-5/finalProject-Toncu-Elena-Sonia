using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SponsorTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Edition { get; set; }

        public virtual ICollection<Sponsors> Sponsors { get; set; }
    }
}
