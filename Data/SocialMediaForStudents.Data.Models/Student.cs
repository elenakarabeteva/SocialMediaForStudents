using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SocialMediaForStudents.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialMediaForStudents.Data.Models
{
    public class Student : IAuditInfo, IDeletableEntity
    {
        public Student()
        {
            this.Subjects = new HashSet<StudentSubject>();
            this.Teachers = new HashSet<StudentTeacher>();
            this.Tests = new HashSet<StudentTest>();
            this.Groups = new HashSet<StudentGroup>();

            this.CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<StudentSubject> Subjects { get; set; }

        public virtual ICollection<StudentTeacher> Teachers { get; set; }

        public virtual ICollection<StudentTest> Tests { get; set; }

        public virtual ICollection<StudentGroup> Groups { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
