using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    public class LoginModel
    {
        public LoginModel()
        {
            RegistrationId = "1234";
            Password = "12345";
        }
        public string RegistrationId { get; set; }
        public string Password { get; set; }
    }
}
