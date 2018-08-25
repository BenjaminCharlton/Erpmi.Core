using Basics;
using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Passage : AuditableEntity<int, ApplicationUser, int>
    {
        private Passage() { }

        public Passage(ApplicationUser createdByUser, string text) : base(createdByUser)
        {
            Text = text.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(text)) : text;
        } 

        public string Text { get; private set; }

        public void Update(ApplicationUser updatedByUser, string text)
        {
            Text = text.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(text)) : text;
            Update(updatedByUser);
        }
    }
}
