using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface ISittingRepository :
        IRepository<Sitting, int>,
        IPagingRepository<Sitting>,
        IAsyncRepository<Sitting, int>,
        IAsyncPagingRepository<Sitting>
    {
        //IEnumerable<Sitting> GetSittingsBy(ApplicationUser user, DateTime datingBackTo);
        //IEnumerable<Sitting> GetSittingsFor(Exam exam, DateTime datingBackTo);
        //IEnumerable<Sitting> GetSuccessfulSittings(Exam exam, DateTime datingBackTo);
        //IEnumerable<Sitting> GetSuccessfulSittings(ApplicationUser user, DateTime datingBackTo);
        //IEnumerable<Sitting> GetFailedSittings(Exam exam, DateTime datingBackTo);
        //IEnumerable<Sitting> GetFailedSittings(ApplicationUser user, DateTime datingBackTo);

        //IEnumerable<Sitting> GetSittingsBy(ApplicationUser user, int pageIndex, int pageSize);
        //IEnumerable<Sitting> GetSittingsFor(Exam exam, int pageIndex, int pageSize);
        //IEnumerable<Sitting> GetSuccessfulSittings(Exam exam, int pageIndex, int pageSize);
        //IEnumerable<Sitting> GetSuccessfulSittings(ApplicationUser user, int pageIndex, int pageSize);
        //IEnumerable<Sitting> GetFailedSittings(Exam exam, int pageIndex, int pageSize);
        //IEnumerable<Sitting> GetFailedSittings(ApplicationUser user, int pageIndex, int pageSize);
    }
}
