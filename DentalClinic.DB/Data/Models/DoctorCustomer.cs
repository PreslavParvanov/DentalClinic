using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorCustomer
    {

        [Required]
        public Guid DoctorId { get; set; }

        public Doctor? Doctors { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string CustomerId { get; set; } = null!;

        public IdentityUser Users { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }

    }
}
