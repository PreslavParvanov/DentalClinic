using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorSchedule
    {

        [Required]
        public Guid DoctorId { get; set; }

        public Doctor? Doctors { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public string CustomerId { get; set; }

        public User Users { get; set; }

        [Required]
        public bool IsBusy { get; set; }    
    }
}
