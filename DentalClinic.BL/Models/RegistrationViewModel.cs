using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Models
{
    public class RegistrationViewModel
    {
        
        [Required]
        [MinLength(1), MaxLength(50)]
        [RegularExpression(@"^\b([A-Z]{1}[a-z]+)+$", ErrorMessage = "Invalid First name!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        [RegularExpression(@"^\b([A-Z]{1}[a-z][-,a-z']*)+$", ErrorMessage = "Invalid Last name!")]
        public string LastName { get; set; }

        [Required]
        [MinLength(1),MaxLength(50)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }

        [Required]
        [MinLength(1), MaxLength(15)]
        public string Phonenumber { get; set; }

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string Password { get; set; }

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string RePassword { get; set; }

        [Range(0, 1)]
        public byte IsActive { get; set; }
    }
}
