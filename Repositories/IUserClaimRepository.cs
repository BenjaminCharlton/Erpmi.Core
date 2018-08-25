using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IUserClaimRepository :
        IRepository<ApplicationUserClaim, int>,
        IAsyncRepository<ApplicationUserClaim, int>
    {
    }
}
