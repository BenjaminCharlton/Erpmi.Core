using Basics.PatternsAndPractices;
using Erpmi.Core.Models;

namespace Erpmi.Core.Repositories
{
    public interface INoteParameterRepository :
        IRepository<NoteParameter, object[]>,
        IAsyncRepository<NoteParameter, object[]>
    {
        //IEnumerable<NoteParameter> GetParametersFor(Note note);
        //IEnumerable<NoteParameter> GetParameterFor(Note note, string key);
    }
}
