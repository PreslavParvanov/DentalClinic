using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data.Models
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public List<DoctorCustomer> DoctorCustomers { get; set; } = new List<DoctorCustomer>();
        public List<DoctorSchedule> DoctorSchedules { get; set; } = new List<DoctorSchedule>();

        [Required]
        public string Name { get; set; }

        [Required]
        public string Qualification { get; set; }
        [Required]
        public string MoreInfo { get; set; }

        [Range(0,1)]
        public byte IsActive { get; set; }

        [Required]
        public string Who { get; set; }
        public User Users { get; set; }

        [Required]
        public DateTime When { get; set; }
    }
}
