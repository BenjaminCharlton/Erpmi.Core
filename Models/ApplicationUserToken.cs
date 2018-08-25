using Basics.DomainModelling;
using Microsoft.AspNetCore.Identity;

namespace Erpmi.Core.Models
{
    public class ApplicationUserToken : IdentityUserToken<int>,
        IIdentifiable<object[]>
    {
        public object[] Id => new object[] { UserId, LoginProvider, Name };
        public ApplicationUser User { get; private set; }
    }
}
