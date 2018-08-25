using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IAttemptRepository :
        IRepository<Attempt, int[]>,
        IPagingRepository<Attempt>,
        IAsyncRepository<Attempt, int[]>,
        IAsyncPagingRepository<Attempt>
    {
        //IEnumerable<Attempt> GetAttemptsBy(ApplicationUser user);
        //IEnumerable<Attempt> GetAttemptsAt(Question question);
        //IEnumerable<Attempt> GetSuccessfulAttemptsBy(ApplicationUser user);
        //IEnumerable<Attempt> GetFailedAttemptsBy(ApplicationUser user);
        //IEnumerable<Attempt> GetFailedAtemptsAt(Question question);
    }
}
