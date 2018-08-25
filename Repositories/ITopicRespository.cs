using Erpmi.Core.Models;
using System.Collections.Generic;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface ITopicRepository :
        IRepository<Topic, int>,
        IAsyncRepository<Topic, int>
    {
        IEnumerable<Topic> GetTopics(Exam exam);
        IEnumerable<Topic> GetTopics(int examId);
        Topic Get(Exam exam, string name);
        bool IsDuplicateName(string suggestedName, int id);
        bool IsTopicOfExam(string name, Exam exam);
        //IEnumerable<Topic> GetUsersStrongestTopics(ApplicationUser user, Exam exam, int max);
        //IEnumerable<Topic> GetUsersWeakestTopics(ApplicationUser user, Exam exam, int max);
        //IEnumerable<Topic> GetEasiestTopics(Exam exam, int max);
        //IEnumerable<Topic> GetHardestTopics(Exam exam, int max);
    }
}
