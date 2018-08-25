using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Option : CreatableEntity<int, ApplicationUser, int>
    {
        private Option() { }

        public Option(ApplicationUser createdByUser, Question question, string description, bool isCorrectAnswer) : base(createdByUser)
        {
            Question = question ?? throw new ArgumentNullException(nameof(question));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            IsCorrectAnswer = isCorrectAnswer;
        }
        public Question Question { get; set; }

        public string Description { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
