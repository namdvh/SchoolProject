using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [MaxLength(30)]
        public string TeacherName { get; set; }
        [Range(22, 50)]
        public string TeacherAge { get; set; }
        public bool TeacherStatus { get; set; }
        [MaxLength(50)]
        public string TeacherAddress { get; set; }
    }
}
