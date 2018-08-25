using Basics.DomainModelling;
using Microsoft.AspNetCore.Identity;

namespace Erpmi.Core.Models
{
    public class ApplicationRoleClaim : IdentityRoleClaim<int>,
        IIdentifiable<int>
    {
    }
}
