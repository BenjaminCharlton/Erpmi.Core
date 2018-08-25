using Basics;
using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Standard : AuditableEntity<int, ApplicationUser, int>
    {
        private Standard() { }

        public Standard(ApplicationUser createdByUser, string description, string violation) : base(createdByUser)
        {
            Description = description.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(description)) : description;
            Violation = violation.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(violation)) : violation;
            IsDefault = false;
        }


        public static Standard CreateDefaultStandard(ApplicationUser createdByUser, string description, string violation)
        {
            return new Standard(createdByUser, description, violation) {IsDefault = true};
        }

        public string Description { get; private set; }
        public string Violation { get; private set; }
        public bool IsDefault { get; private set; }

        public void Update(ApplicationUser updatedByUser, string description, string violation)
        {
            Description = description.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(description)) : description;
            Violation = violation.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(violation)) : violation;
            Update(updatedByUser);
        }
    }
}
