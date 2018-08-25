using Erpmi.Core.Models;
using Basics.PatternsAndPractices;
using System.Collections.Generic;

namespace Erpmi.Core.Repositories
{
    public interface IExamRepository :
        IRepository<Exam, int>,
        IPagingRepository<Exam>,
        IAsyncRepository<Exam, int>,
        IAsyncPagingRepository<Exam>
    {
        Exam Get(string name);
        //IEnumerable<Exam> GetExamsAttemptedBy(ApplicationUser user);
        //IEnumerable<Exam> GetExamsAttemptedBy(ApplicationUser user, DateTime datingBackTo);
        //IEnumerable<Exam> GetExamsPassedBy(ApplicationUser user, bool includeExpired);
        //IEnumerable<Exam> GetExamsPassedBy(ApplicationUser user, bool includeExpired, DateTime datingBackTo);
        //IEnumerable<Exam> GetExamsFailedBy(ApplicationUser user);
        //IEnumerable<Exam> GetExamsFailedBy(ApplicationUser user, DateTime datingBackTo);
        //IEnumerable<Exam> GetExamsAvailableToTake(ApplicationUser user);
        //IEnumerable<Exam> GetExamsCreatedBy(ApplicationUser user);
        //IEnumerable<Exam> GetExamsCreatedBy(ApplicationUser user, DateTime datingBackTo);
        IEnumerable<Exam> GetExamsAvailableToEdit(ApplicationUser user);
        //IEnumerable<Exam> GetExamsToWhichUserCanContributeQuestions(ApplicationUser user);
        //IEnumerable<Exam> GetExamsToWhichUserHasContributedQuestions(ApplicationUser user);
        //IEnumerable<Exam> GetExamsToWhichUserHasContributedQuestions(ApplicationUser user, DateTime datingBackTo);
        IEnumerable<Exam> GetExamsWithInsufficientQuestions(ApplicationUser user);
        IEnumerable<Exam> GetExamsAvailableToActivate(ApplicationUser user);
        IEnumerable<Exam> GetExamsAwaitingActivation(bool includeExamsWithInsufficientQuestions);
        IEnumerable<Exam> GetActiveExamsAvailableToEdit(ApplicationUser user);
        bool IsDuplicateName(string name, int id);
        //IEnumerable<Exam> GetHardestExams(int max);
        //IEnumerable<Exam> GetEasiestExams(int max);
        //Exam GetMostRecentlyAttemptedExam(ApplicationUser user);
        //Exam GetMostRecentlyFailedExam(ApplicationUser user);
        //Exam GetMostRecentlyPassedExam(ApplicationUser user);
    }
}