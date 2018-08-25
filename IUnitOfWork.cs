using Basics.PatternsAndPractices;
using Erpmi.Core.Repositories;

namespace Erpmi.Core
{
    public interface IUnitOfWork : IAsyncUnitOfWork
    {
        IAttemptRepository Attempts { get; }
        IExamRepository Exams { get; }
        IImageRepository Images { get; }
        INotificationRepository Notifications { get; }
        INoteRepository Notes { get; }
        INoteParameterRepository NoteParameters { get; }
        IOpinionRepository Opinions { get; }
        IOptionRepository Options { get; }
        IPassageRepository Passages { get; }
        IQuestionRepository Questions { get; }
        IRequirementRepository Requirements { get; }
        IRoleClaimRepository RoleClaims { get; }
        IRoleRepository Roles { get; }
        IStandardRepository Standards { get; }
        ISittingRepository Sittings { get; }
        ITopicRepository Topics { get; }
        IUserClaimRepository UserClaims { get; }
        IUserRepository Users { get; }
        IUserLoginRepository UserLogins { get; }
        IUserRoleRepository UserRoles { get; }
        IUserTokenRepository UserTokens { get; }
    }
}
