using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [MaxLength(30)]
        public string StudentName { get; set;}
        [Range(5,30)]
        public int StudentAge { get; set;} 
        public bool StudentStatus { get; set; }
        [MaxLength(50)]
        public string StudentAddress { get; set; }
    }
}
