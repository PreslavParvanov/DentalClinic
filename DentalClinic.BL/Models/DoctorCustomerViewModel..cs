using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class DoctorCustomerViewModel
    {

        [Required]
        public Guid DoctorId { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; } = new List<Doctor>();

        [Required]
        public DateTime DateTimeSchedule { get; set; }

        public string? CustomerId { get; set; }

        public User? Users { get; set; }

        [Required]
        public bool IsBusy { get; set; }    
    }
}
