using Conference.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SpeakerViewModel
    { 
        public int? Id { get; set; }
        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
        //public string FullName { get => FirstName + " " + LastName; }
        [Required]
        public string Position { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string GitHub { get; set; }
        public string Twitter { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        public string PageSlug { get; set; }
        [Required]
        public string Edition { get; set; }


        public virtual ICollection<Photos> Photos { get; set; }
        public virtual ICollection<Talks> Talks { get; set; }
        public virtual ICollection<Workshops> Workshops { get; set; }
    }
}
