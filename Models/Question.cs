using Basics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Question :
        ApprovableEntity<int, ApplicationUser, int>
    {
        private Question() { }

        public Question(
            ApplicationUser createdByUser,
            Topic topic,
            string text) : base(createdByUser)
        {
            Topic = topic ?? throw new ArgumentNullException(nameof(topic));
            Text = text.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(text)) : text;
            Options = new Collection<Option>();
            Opinions = new Collection<Opinion>();
        }

        public Exam Exam => Topic.Exam;

        public Topic Topic { get; private set; }

        public Passage Passage { get; private set; }

        public Image Image { get; private set; }

        public string Text { get; private set; }

        public ICollection<Option> Options { get; }

        public string Explanation { get; private set; }

        public IEnumerable<Opinion> Opinions { get; }

        public double RandomChancePercentage
        {
            get
            {
                return 1 / Options.Count;
            }
        }

        protected void Update(ApplicationUser updatedByUser, string text, string explanation, Topic category, Passage passage, Image image)
        {
            Topic = category ?? throw new ArgumentNullException(nameof(category));
            Passage = passage;
            Image = image;
            Text = text.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(text)) : text;
            Explanation = explanation.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(explanation)): explanation;
            base.Update(updatedByUser);
        }

        public void MoveToTopic(Topic topic, ApplicationUser updatedByUser)
        {
            Topic = topic ?? throw new ArgumentNullException(nameof(topic));
            base.Update(updatedByUser);
        }
    }
}