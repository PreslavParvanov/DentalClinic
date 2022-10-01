using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Models
{
    public class UserViewModel
    {
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [MinLength(1), MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MinLength(1),MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MinLength(1), MaxLength(15)]
        public string Phonenumber { get; set; }

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string Password { get; set; }

        [Range(0, 1)]
        public byte IsActive { get; set; }
    }
}
