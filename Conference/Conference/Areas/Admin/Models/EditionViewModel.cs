using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class EditionViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string TagLine { get; set; }
        [Required]
        public int Year { get; set; }
        public bool Active { get; set; }
    }
}
