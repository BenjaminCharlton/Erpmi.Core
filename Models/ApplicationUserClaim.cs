using Basics.DomainModelling;
using Microsoft.AspNetCore.Identity;

namespace Erpmi.Core.Models
{
    public class ApplicationUserClaim : IdentityUserClaim<int>,
                IIdentifiable<int>
    {
        public ApplicationUser User { get; private set; }
    }
}
