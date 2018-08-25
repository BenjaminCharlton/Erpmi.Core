using Erpmi.Core.Models;
using System.Collections.Generic;
using Basics.PatternsAndPractices;


namespace Erpmi.Core.Repositories
{
    public interface IUserTokenRepository :
        IRepository<ApplicationUserToken, object[]>,
        IAsyncRepository<ApplicationUserToken, object[]>
    {
    }
}
