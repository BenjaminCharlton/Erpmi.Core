using Microsoft.AspNetCore.Identity;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class ApplicationUserLogin : IdentityUserLogin<int>,
        IIdentifiable<string[]>
    {
        public string[] Id => new string[] { LoginProvider, ProviderKey };
        public ApplicationUser User { get; private set; }
    }
}
