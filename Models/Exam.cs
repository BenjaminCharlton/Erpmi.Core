using Basics;
using Basics.Enumerations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Exam : ActivatableEntity<int, ApplicationUser, int>
    {
        private int _numberOfQuestionsToBeAttempted;
        //private ICollection<Standard> _standards;

        private Exam()
        {
            Topics = new Collection<Topic>();
        }

        public Exam(ApplicationUser createdByUser,
            string name,
            string description,
            double timeAllowedInMinutes,
            bool shuffleTopicsTogether = true) :
            base(createdByUser)
        {
            Name = name;
            Description = description;
            TimeAllowedInMinutes = timeAllowedInMinutes;
            ShuffleTopicsTogether = shuffleTopicsTogether;
            Topics = new Collection<Topic>();
            Requirements = new Collection<Requirement>();
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public double TimeAllowedInMinutes { get; private set; }

        public bool ShuffleTopicsTogether { get; private set; }

        public IEnumerable<Question> PossibleQuestions
        {
            get
            {
                return Topics.SelectMany(t => t.PossibleQuestions);
            }
        }

        public int NumberOfQuestionsToBeAttempted
        {
            get
            {
                if (_numberOfQuestionsToBeAttempted != 0) return _numberOfQuestionsToBeAttempted;
                foreach (Topic topic in Topics)
                {
                    _numberOfQuestionsToBeAttempted += topic.NumberOfQuestionsToBeAttempted;
                }
                return _numberOfQuestionsToBeAttempted;
            }
        }

        public ICollection<Topic> Topics { get; private set; }

        //public IEnumerable<Standard> Standards
        //{
        //    get
        //    {
        //        if (_standards.IsNullOrWhiteSpace())
        //        {
        //            _standards = new Collection<Standard>();

        //            foreach (Requirement requirement in Requirements)
        //                _standards.Add(requirement.Standard);
        //        }

        //        return _standards;
        //    }
        //}

        public ICollection<Requirement> Requirements { get; private set; }

        public void Update(ApplicationUser updatedByUser, string name, string description, double timeAllowedInMinutes, bool shuffleTopicsTogether = true)
        {
            Name = name.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(name)) : name;
            Description = description;
            TimeAllowedInMinutes = timeAllowedInMinutes;
            ShuffleTopicsTogether = shuffleTopicsTogether;
            Update(updatedByUser);
        }

        public void RequireStandard(Standard standard)
        {
            if(standard.IsNullOrDefault())
                throw new ArgumentNullException(nameof(standard));

            Requirements.Add(new Requirement(this, standard));
        }

        public void NoLongerRequireStandard(Standard standard)
        {
            if (standard.IsNullOrDefault())
                throw new ArgumentNullException(nameof(standard));

            foreach(var requirement in Requirements.Where(r => r.Standard == standard))
                Requirements.Remove(requirement);
        }

        public void RequireStandards(IEnumerable<Standard> standards)
        {
            foreach (Standard standard in standards)
                RequireStandard(standard);
        }

        public void NoLongerRequireStandards(IEnumerable<Standard> standards)
        {
            foreach (Standard standard in standards)
                NoLongerRequireStandard(standard);
        }

        public void SwapStandards(Standard old, Standard fresh)
        {
            if (old.IsNullOrDefault())
                throw new ArgumentNullException(nameof(old));

            if (fresh.IsNullOrDefault())
                throw new ArgumentNullException(nameof(fresh));

            NoLongerRequireStandard(old);
            RequireStandard(fresh);
        }

        public void AddTopic(ApplicationUser addedByUser,
            string name, string description, int numberOfQuestionsToBeAttempted)
        {
            Topics.Add(new Topic(addedByUser, this, name, description, numberOfQuestionsToBeAttempted));
        }
    }
}
