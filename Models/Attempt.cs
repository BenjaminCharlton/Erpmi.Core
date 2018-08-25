using System;
using Basics.DomainModelling;
using Erpmi.Core;

namespace Erpmi.Core.Models
{
    public class Attempt : IIdentifiable<int[]>
    {
        private Attempt() { }

        public Attempt(Sitting sitting, Question question)
        {
            Sitting = sitting ?? throw new ArgumentNullException(nameof(sitting));
            Question = question ?? throw new ArgumentNullException(nameof(question));
        }

        public Sitting Sitting { get; private set; }
        public Question Question { get; private set; }

        public int[] Id => new int[] { Sitting.Id, Question.Id };
    }
}