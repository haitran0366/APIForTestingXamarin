using System;
using System.Collections.Generic;

#nullable disable

namespace APIForTestingXamarin.Models
{
    public partial class TblUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
