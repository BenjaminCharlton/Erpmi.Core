using Basics;
using System;
using Basics.DomainModelling;

namespace Erpmi.Core.Models
{
    public class Image : AuditableEntity<int, ApplicationUser, int>
    {
        private Image() { }

        public Image(ApplicationUser createdByUser, string fileName, string description = "") : base(createdByUser)
        {
            FileName = fileName.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(fileName)) : fileName;
            Description = description.IsNullOrWhiteSpace() ? throw new ArgumentNullException(nameof(description)) : description;
        }

        public string FileName { get; set; }

        public string Description { get; set; }

        public void Update(ApplicationUser updatedByUser, string fileName, string description)
        {
            FileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Update(updatedByUser);
        }
    }
}
