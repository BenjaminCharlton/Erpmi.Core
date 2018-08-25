using Basics;
using Basics.DomainModelling;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Erpmi.Core.Models
{
    public class ApplicationUser :
        IdentityUser<int>,
        IIdentifiable<int>,
        IUpdatable<ApplicationUser, int>,
        IActivatable<ApplicationUser, int>
    {
        private ApplicationUser() {
            Notifications = new Collection<Notification>();
        }

        public static ApplicationUser Create(ApplicationUser createdByUser,
            string email,
            string givenName,
            string familyName,
            string preferredName,
            DateTime dateOfBirth)
        {
            return Create(email, givenName, familyName, preferredName, dateOfBirth)
                .CreatedByUser = createdByUser;
        }

        public static ApplicationUser Create(
            string email,
            string givenName,
            string familyName, 
            string preferredName,
            DateTime dateOfBirth)
        {
            if (email.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(email));

            if (givenName.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(givenName));

            if (familyName.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(familyName));

            if (preferredName.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(preferredName));

            return new ApplicationUser()
            {
                Email = email,
                GivenName = givenName,
                FamilyName = familyName,
                PreferredName = preferredName,
                DateOfBirth = dateOfBirth,
                WhenCreated = DateTime.Now
            };
        }

        public DateTime DateOfBirth { get; private set; }
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }
        public string FullName { get; private set; }
        public string PreferredName { get; private set; }
        public DateTime WhenCreated { get; private set; }
        public DateTime? WhenLastUpdated { get; private set; }
        public DateTime? WhenLastActivated { get; private set; }
        public DateTime? WhenLastDeactivated { get; private set; }
        public bool IsActive { get; private set; }
        public ApplicationUser CreatedByUser { get; private set; }
        public ApplicationUser LastUpdatedByUser { get; private set; }
        public ApplicationUser LastActivatedByUser { get; private set; }
        public ApplicationUser LastDeactivatedByUser { get; private set; }
        public IEnumerable<Notification> Notifications { get; private set; }
        public IEnumerable<ApplicationRole> Roles { get; private set; }

        public void Update(ApplicationUser updatedByUser, string email)
        {
            Email = email;
            UserName = email;
            Update(LastActivatedByUser);
        }

        protected void Update(ApplicationUser updatedByUser)
        {
            LastUpdatedByUser = updatedByUser ?? throw new ArgumentNullException(nameof(updatedByUser));
            WhenLastUpdated = DateTime.Now;
        }

        public void Activate(ApplicationUser activatedByUser)
        {
            LastActivatedByUser = activatedByUser ?? throw new ArgumentNullException(nameof(activatedByUser));
            WhenLastActivated = DateTime.Now;
            IsActive = true;
        }

        public void Deactivate(ApplicationUser deactivatedByUser)
        {
            LastDeactivatedByUser = deactivatedByUser ?? throw new ArgumentNullException(nameof(deactivatedByUser));
            WhenLastDeactivated = DateTime.Now;
            IsActive = false;
        }

        public void Notify(ApplicationUser notifier, Note notification)
        {
            var list = Notifications.ToList();
            list.Add(new Notification(notifier, this, notification));
            Notifications = list;
        }
    }
}
