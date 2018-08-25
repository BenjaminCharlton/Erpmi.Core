using Erpmi.Core.Models;
using System.Collections.Generic;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IUserLoginRepository :
        IRepository<ApplicationUserLogin, string[]>,
        IAsyncRepository<ApplicationUserLogin, string[]>
    {
    }
}
