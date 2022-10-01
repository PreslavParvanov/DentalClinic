﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.DB.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phonenumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Range(0, 1)]
        public byte IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid Who { get; set; }


        [Required]
        public DateTime When { get; set; }

        [Required]
        public DateTime LastActive { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public User()
        {
            Doctors = new HashSet<Doctor>();
        }

    }
}