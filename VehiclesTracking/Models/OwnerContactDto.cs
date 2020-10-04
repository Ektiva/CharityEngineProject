using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace VehiclesTracking.Models
{
    public class OwnerContactDto
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Contact")]
        public string PhoneNumber { get; set; }
        public int RegistrationNumber { get; set; }
    }
}