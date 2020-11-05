using SocialMediaForStudents.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;

namespace SocialMediaForStudents.Data.Models
{
    public class StudentSubject : IAuditInfo, IDeletableEntity
    {
        public StudentSubject()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        [Required]
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Required]
        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
