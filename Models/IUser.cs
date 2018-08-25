using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public interface ApplicationUser :
        IIdentifiable,
        ICreatable<ApplicationUser, int>,
        IUpdatable<ApplicationUser, int>,
        IActivatable<ApplicationUser, int>
    {
        string UserName { get; }
        string PasswordHash { get; }
        string Email { get; }
        DateTime DateOfBirth { get; }
        string PreferredName { get; }
        void Update(ApplicationUser updatedByUser, string email);
        void Notify(ApplicationUser notifier, Note notification);
    }
}
