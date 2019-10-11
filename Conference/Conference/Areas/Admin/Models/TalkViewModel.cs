using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class TalkViewModel
    {
        public int Id { get; set; }
        [Required]
        public int SpeakerId { get; set; }
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public string Edition { get; set; }

        public virtual Speakers Speaker { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }
    }
}
