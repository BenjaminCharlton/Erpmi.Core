using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IImageRepository :
        IRepository<Image, int>,
        IAsyncRepository<Image, int>
    {
        //Image GetImageForQuestion(Question question);
    }
}
