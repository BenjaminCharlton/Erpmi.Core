using Erpmi.Core.Models;
using System.Collections.Generic;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface IQuestionRepository :
        IRepository<Question, int>,
        IPagingRepository<Question>,
        IAsyncRepository<Question, int>,
        IAsyncPagingRepository<Question>
    {
        //IEnumerable<Question> GetApprovedQuestions(Exam exam);
        //IEnumerable<Question> GetUnApprovedQuestions(Exam exam);
        //IEnumerable<Question> GetQuestionsCreatedBy(ApplicationUser user);
        //IEnumerable<Question> GetRandomQuestions(Exam exam, int max);
        //IEnumerable<Question> GetApprovedQuestions(Topic topic);
        //IEnumerable<Question> GetQuestionsAwaitingApproval(Topic topic);
        //IEnumerable<Question> GetRandomApprovedQuestions(Topic topic, int max);
        //IEnumerable<Question> GetHardestQuestions();
        //IEnumerable<Question> GetEasiestQuestions();
        //IEnumerable<Question> GetHardestQuestions(Exam exam);
        //IEnumerable<Question> GetEasiestQuestions(Exam exam);
        IEnumerable<Question> GetQuestionsOnTopic(Topic topic);
        IEnumerable<Question> GetPendingQuestionsNotBy(ApplicationUser user, Topic topic = null);
    }
}