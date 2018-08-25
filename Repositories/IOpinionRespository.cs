using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IOpinionRepository
        : IRepository<Opinion, int>,
        IPagingRepository<Opinion>,
        IAsyncRepository<Opinion, int>,
        IAsyncPagingRepository<Opinion>
    {
        //IEnumerable<Opinion> GetOpinions(Question question);
    }
}
