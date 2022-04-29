using SchoolProject.Models;
using System.Collections.Generic;

namespace SchoolProject.Repository
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student std);
        public void Delete(int id);
        public void Register(int courseId,int studentId);


    }
}
