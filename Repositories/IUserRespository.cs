using Basics.PatternsAndPractices;
using System.Threading.Tasks;
using Erpmi.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Erpmi.Core.Repositories
{
    public interface IUserRepository : 
        IUserStore<ApplicationUser>,
        IRepository<ApplicationUser, int>,
        IPagingRepository<ApplicationUser>,
        IAsyncRepository<ApplicationUser, int>,
        IAsyncPagingRepository<ApplicationUser>
    {
        //ApplicationUser FindByEmail(string email);
        //ApplicationUser FindByUserName(string userName);
        Task<ApplicationUser> FindByEmailAsync(string email);
        Task<ApplicationUser> FindByUserNameAsync(string userName);
    }
}
