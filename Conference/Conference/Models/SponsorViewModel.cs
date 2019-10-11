using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class SponsorViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Description { get; set; }
        public string PageSlug { get; set; }
        public int SponsorTypeId { get; set; }
        public bool Active { get; set; }
        [MaxLength(20)]
        public string Edition { get; set; }

        public virtual SponsorTypes SponsorType { get; set; }
        public virtual ICollection<SponsorPhoto> SponsorPhoto { get; set; }
    }
}
