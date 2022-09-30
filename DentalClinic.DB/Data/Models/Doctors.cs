using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data.Models
{
    public class Doctors
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Qualification { get; set; }
        [Required]
        public string MoreInfo { get; set; }

        [Required]
        public Guid Who { get; set; }

        [Required]
        public DateTime When { get; set; }
    }
}
