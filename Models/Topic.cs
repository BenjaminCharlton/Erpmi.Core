using Basics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Topic : AuditableEntity<int, ApplicationUser, int>
    {
        private Topic() { }

        public Topic(
            ApplicationUser createdByUser,
            Exam exam,
            string name,
            string description,
            int numberOfQuestionsToBeAttempted = 0) : base(createdByUser)
        {
            Exam = exam ?? throw new ArgumentNullException(nameof(exam));
            Name = name.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(name)) : name;
            Description = description.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(description)) : description;
            NumberOfQuestionsToBeAttempted = numberOfQuestionsToBeAttempted;
            PossibleQuestions = new Collection<Question>();
        }

        public Exam Exam { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int NumberOfQuestionsToBeAttempted { get; private set; }

        public IEnumerable<Question> PossibleQuestions { get; private set; }

        public void Update(ApplicationUser updatedByUser, string name, string description, int numberOfQuestionsToBeAttempted)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            NumberOfQuestionsToBeAttempted = numberOfQuestionsToBeAttempted;
            Update(updatedByUser);
        }
    }
}
