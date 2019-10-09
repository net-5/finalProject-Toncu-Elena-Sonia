using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class TalkViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Speaker")]
        public int SpeakerId { get; set; }
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public string Edition { get; set; }

        public virtual Speakers Speaker { get; set; }
        //public virtual ICollection<Speakers> Speakers { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }
    }
}
