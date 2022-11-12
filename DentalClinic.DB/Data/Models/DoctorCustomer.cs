using System.ComponentModel.DataAnnotations;

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

        [Required]
        public DateTime When { get; set; }

    }
}
