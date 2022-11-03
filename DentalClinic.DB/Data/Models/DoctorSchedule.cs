using System.ComponentModel.DataAnnotations;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorSchedule
    {
        [Required]
        public Guid DoctorId { get; set; }

        public Doctor Doctors { get; set; } = null!;

        [Required]
        public DateTime ScheduleDateTime { get; set; }

        [Required]
        public bool IsBusy { get; set; }

        [Required]
        public string Who { get; set; } = null!;
        public User Users { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }

    }
}
