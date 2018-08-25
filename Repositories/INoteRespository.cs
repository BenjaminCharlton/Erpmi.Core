using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface INoteRepository :
        IRepository<Note, int>,
        IAsyncRepository<Note, int>
    {
        //IEnumerable<Note> GetNotes(int pageIndex, int pageSize);
    }
}
