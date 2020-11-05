using SocialMediaForStudents.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialMediaForStudents.Data.Models
{
    public class Subject : IAuditInfo, IDeletableEntity
    {
        public Subject()
        {
            this.Students = new HashSet<StudentSubject>();
            this.Teachers = new HashSet<Teacher>();
            this.Tests = new HashSet<Test>();
            this.Posts = new HashSet<Post>();
            this.Groups = new HashSet<Group>();

            this.CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public virtual ICollection<StudentSubject> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<Test> Tests { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
