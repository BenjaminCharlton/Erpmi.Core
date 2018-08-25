using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IPassageRepository :
        IRepository<Passage, int>,
        IAsyncRepository<Passage, int>
    {
        //Passage GetPassageForQuestion(Question question);
    }
}