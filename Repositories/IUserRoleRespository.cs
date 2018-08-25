using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IUserRoleRepository :
        IRepository<ApplicationUserRole, int[]>,
        IAsyncRepository<ApplicationUserRole, int[]>
    {
    }
}
