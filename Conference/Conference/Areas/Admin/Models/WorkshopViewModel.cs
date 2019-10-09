using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class WorkshopViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        public string Prerequisites { get; set; }
        public string Requirements { get; set; }
        public int? PlacesAvailable { get; set; }
        public string Edition { get; set; }
        
        public int SpeakerId { get; set; }
        public string RegistrationLink { get; set; }
        public virtual Speakers Speaker { get; set; }
    }
}
