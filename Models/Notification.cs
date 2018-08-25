using Basics;
using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Notification : AuditableEntity<int, ApplicationUser, int>
    {
        private Notification() { }

        public Notification(
            ApplicationUser createdByUser,
            ApplicationUser notifyUser,
            Note note) : base(createdByUser)
        {
            NotifyUser = notifyUser ?? throw new ArgumentNullException(nameof(notifyUser));
            Note = note ?? throw new ArgumentNullException(nameof(note));
        }

        public ApplicationUser NotifyUser { get; private set; }
        public Note Note { get; private set; }

        public DateTime? WhenFirstRead { get; private set; }

        public DateTime? WhenLastRead { get; private set; }

        public bool IsRead { get; private set; }

        public void MarkUnread(ApplicationUser updatedByUser)
        {
            IsRead = false;
            Update(updatedByUser);
        }

        public void MarkRead(ApplicationUser updatedByUser)
        {
            IsRead = true;
            if(WhenFirstRead.IsNullOrDefault())
                WhenFirstRead = DateTime.Now;

            WhenLastRead = DateTime.Now;
            Update(updatedByUser);
        }
    }
}