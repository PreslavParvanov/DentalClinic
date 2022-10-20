using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class User : IdentityUser
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
