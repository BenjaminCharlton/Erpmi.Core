using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class NoteParameter : IIdentifiable<object[]>
    {
        private NoteParameter() { }

        public NoteParameter(ApplicationUser createdByUser, Note note, string key, string value)
        {
            Note = note ?? throw new ArgumentNullException(nameof(note));
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Note Note { get; private set; }

        public string Key { get; private set; }
        
        public string Value { get; private set; }

        public object[] Id => new object[] { Note.Id, Key };
    }
}
