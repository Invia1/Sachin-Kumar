using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    internal class Patient
    {
        public int RegistrationId { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string AadharNumber { get; set; }
        public string SpecialityToConsult { get; set; } 
        public Patient() { }
    }
}
