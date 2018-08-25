using Basics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Note : AuditableEntity<int, ApplicationUser, int>
    {
        private Note() { }

        public Note(
            ApplicationUser createdByUser,
            string messageFormat,
            IEnumerable<NoteParameter> parameters = null,
            DateTime? whenExpires = null) : base(createdByUser)
        {
            MessageFormat = messageFormat.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(messageFormat)) : messageFormat;
            WhenExpires = whenExpires;
            Parameters = parameters ?? new Collection<NoteParameter>();
            Notifications = new Collection<Notification>();
        }

        public string MessageFormat { get; private set; }
        
        public DateTime? WhenExpires { get; private set; }

        public IEnumerable<NoteParameter> Parameters { get; private set; }

        public IEnumerable<Notification> Notifications { get; }

        public void Update(
            ApplicationUser updatedByUser,
            string messageFormat,
            IEnumerable<NoteParameter> parameters = null,
            DateTime? whenExpires = null)
        {
            MessageFormat = messageFormat ?? throw new ArgumentNullException(nameof(messageFormat));
            Parameters = parameters ?? new Collection<NoteParameter>();
            WhenExpires = whenExpires;
            Update(updatedByUser);

            foreach(Notification un in Notifications)
            {
                un.MarkUnread(updatedByUser);
            }
        }
    }
}
