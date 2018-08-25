using Erpmi.Core.Models;
using Basics.PatternsAndPractices;
using Microsoft.AspNetCore.Identity;

using System.Threading.Tasks;

namespace Erpmi.Core.Repositories
{
    public interface IRoleRepository :
        IRoleStore<ApplicationRole>,
        IRepository<ApplicationRole, int>,
        IAsyncRepository<ApplicationRole, int>,
        IPagingRepository<ApplicationRole>,
        IAsyncPagingRepository<ApplicationRole>
    {
        Task<ApplicationRole> GetByNameAsync(string name);
        ApplicationRole GetByName(string name);
    }
}
