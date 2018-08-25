using System;
using System.Collections.Generic;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Opinion : CreatableEntity<int, ApplicationUser, int>
    {
        private Opinion() { }

        public Opinion(
            ApplicationUser createdByUser,
            Question question,
            bool liked,
            Standard violatedStandard,
            string suggestedText = "",
            string suggestedExplanation = "",
            IEnumerable<Option> suggestedOptions = null) : base(createdByUser)
        {
            Question = question ?? throw new ArgumentNullException(nameof(question));
            ViolatedStandard = violatedStandard ?? throw new ArgumentNullException(nameof(violatedStandard));
            Liked = liked;
            SuggestedExplanation = suggestedExplanation;
            SuggestedOptions = suggestedOptions;
            SuggestedText = suggestedText;
        }

        public Question Question { get; private set; }

        public bool Liked { get; }

        public Standard ViolatedStandard { get; }

        public string SuggestedExplanation { get; }

        public string SuggestedText { get; }

        public IEnumerable<Option> SuggestedOptions { get; }
    }
}
