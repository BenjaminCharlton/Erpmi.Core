using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using Basics.DomainModelling;
using System.Linq;

namespace Erpmi.Core.Models
{
    public class Sitting :
        CreatableEntity<int, ApplicationUser, int>
    {
        private Sitting() { }

        public Sitting(ApplicationUser candidate, Exam exam, IEnumerable<Question> questions = null) : base(candidate)
        {
            Exam = exam ?? throw new ArgumentNullException(nameof(exam));
            Candidate = candidate ?? throw new ArgumentNullException(nameof(candidate));
            Collection<Attempt> attempts = new Collection<Attempt>();

            if (questions != null)
            {
                foreach (Question q in questions)
                {
                    attempts.Add(new Attempt(this, q));
                }
                Attempts = attempts;
            }
        }
        
        public Exam Exam { get; private set; }
        public ApplicationUser Candidate { get; private set; }
        public IEnumerable<Attempt> Attempts { get; private set; }
        public DateTime? WhenStarted { get; private set; }
        public DateTime? Deadline { get; private set; }
        public DateTime? WhenEnded { get; private set;  }
        public bool RanOutOfTime { get; private set; }

        //public double RandomChancePercentage
        //{
        //    get => Attempts.SelectMany<double>()

        //}

        public void Start()
        {
            WhenStarted = DateTime.Now;
            Deadline = WhenStarted.Value.AddMinutes(Exam.TimeAllowedInMinutes);
        }

        public void Submit()
        {
            WhenEnded = DateTime.Now;
            if (WhenEnded >= Deadline)
                RanOutOfTime = true;
        }
    }
}
