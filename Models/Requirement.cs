using System;
using Basics.DomainModelling;
using Erpmi.Core;

namespace Erpmi.Core.Models
{
    public class Requirement : AuditableEntity<int, ApplicationUser, int>
    {
        private Requirement() { }

        public Requirement(Exam exam, Standard standard)
        {
            Exam = exam ?? throw new ArgumentNullException(nameof(exam));
            Standard = standard ?? throw new ArgumentNullException(nameof(standard));
        }

        public Exam Exam { get; private set; }
        public Standard Standard { get; private set; }

        public void SwapStandard(ApplicationUser swappingUser, Standard newStandard)
        {
            Standard = newStandard;
            Update(swappingUser);
        }
    }
}