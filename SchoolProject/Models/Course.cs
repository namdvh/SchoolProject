using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [MaxLength(30)]
        public string CourseName { get; set; }
        [Range(5, 30)]
        public bool CourseStatus { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }    
    }
}
