using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Models
{
    public class DoctorViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Qualification { get; set; }
        public string? MoreInfo { get; set; }
    }
}
