using Basics.PatternsAndPractices;
using Erpmi.Core.Models;
using System.Collections.Generic;

namespace Erpmi.Core.Repositories
{
    public interface IStandardRepository :
        IRepository<Standard, int>,
        IAsyncRepository<Standard, int>
    {
        IEnumerable<Standard> GetDefaultRequirements();
        Standard GetDefaultStandard(int id);
        bool IsDefaultStandard(int id);
        Standard GetCustomStandard(int id);
        IEnumerable<Standard> GetStandardsForExam(Exam exam);
        IEnumerable<Standard> GetStandardsForExam(int examId);
        bool IsDefaultStandard(string description);
        bool IsStandardOfExam(string description, Exam exam);
        bool IsDuplicateDescription(string suggestedDescription, int id);
        bool IsDuplicateDescription(string suggestedDescription, int id, Exam exam);
    }
}
