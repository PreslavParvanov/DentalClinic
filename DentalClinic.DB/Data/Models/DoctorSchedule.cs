﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorSchedule
    {
        [Required]
        public Guid DoctorId { get; set; }

        public Doctor Doctors { get; set; }

        [Required]
        public DateTime ScheduleDateTime { get; set; }

        [Required]
        public bool IsBusy { get; set; }

        [Required]
        public string Who { get; set; }
        public User Users { get; set; }

        [Required]
        public DateTime When { get; set; }

    }
}
