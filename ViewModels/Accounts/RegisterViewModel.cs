using System;
using System.Collections.Generic;
using System.Text;

namespace Erpmi.Core.ViewModels.Accounts
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string PreferredName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
