using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehiclesTracking.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [DisplayName("Owner's First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [DisplayName("Owner's Last Name")]
        public string LastName { get; set; }

        [DisplayName("Owner's Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [DisplayName("Owner's Unit number")]
        [Required(ErrorMessage = "Unit number is required")]
        public int UnitNumber { get; set; }

        [DisplayName("Owner's Appartment number")]
        [Required(ErrorMessage = "Appartment number is required")]
        public int AptNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        //[DisplayName("Owner")]
        //[Required(ErrorMessage = "Owner is required")]
        //public int ResidentId { get; set; }

        [DisplayName("Registration Number")]
        [Required(ErrorMessage = "Registration Number is required")]
        public int RegistrationNumber { get; set; }

        [DisplayName("Date Of Registration")]
        [Required(ErrorMessage = "Date Of Registration is required")]
        public DateTime DOR { get; set; }
    }
}