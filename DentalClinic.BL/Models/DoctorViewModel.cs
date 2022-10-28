using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Models
{
    public class DoctorViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(1),MaxLength(100)]
        public string Qualification { get; set; }

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string MoreInfo { get; set; }

        [Required]
        public string Who { get; set; }

    }
}
