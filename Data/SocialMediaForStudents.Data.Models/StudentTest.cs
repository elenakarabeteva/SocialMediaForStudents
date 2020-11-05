using SocialMediaForStudents.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialMediaForStudents.Data.Models
{
    public class StudentTest : IAuditInfo, IDeletableEntity
    {
        public StudentTest()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [ForeignKey(nameof(Test))]
        public int TestId { get; set; }

        public virtual Test Test { get; set; }

        [Required]
        public decimal Grade { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
