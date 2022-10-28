using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class User : IdentityUser
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Range(0, 1)]
        public byte IsActive { get; set; }

        [Required]
        public DateTime When { get; set; }

        [Required]
        public DateTime LastActive { get; set; }

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<DoctorCustomer> DoctorCustomers { get; set; } = new List<DoctorCustomer>();
        public List<DoctorSchedule> DoctorSchedules { get; set; } = new List<DoctorSchedule>();



    }
}
