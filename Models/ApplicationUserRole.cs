using Basics.DomainModelling;
using Microsoft.AspNetCore.Identity;

namespace Erpmi.Core.Models
{
    public class ApplicationUserRole : IdentityUserRole<int>,
        IIdentifiable<int[]>
    {
        public int[] Id => new int[] { UserId, RoleId };
    }
}
