using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IOptionRepository :
        IRepository<Option, int>,
        IAsyncRepository<Option, int>
    {
        //IEnumerable<Option> GetOptionsForQuestion(Question question);
    }
}
