using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IRoleClaimRepository :
        IRepository<ApplicationRoleClaim, int>,
        IAsyncRepository<ApplicationRoleClaim, int>
    {
    }
}
