using Basics.PatternsAndPractices;
using Erpmi.Core.Models;
using System.Collections.Generic;

namespace Erpmi.Core.Repositories
{
    public interface IRequirementRepository :
        IRepository<Requirement, int>,
        IAsyncRepository<Requirement, int>
    {
        IEnumerable<Requirement> GetRequirements(Exam exam);
        IEnumerable<Requirement> GetRequirements(int examId);
        IEnumerable<Requirement> GetRequirements(Standard standard);
        IEnumerable<Requirement> GetDefaultRequirements();
    }
}
