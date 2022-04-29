using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.Repository
{
    public class TeacherRepository : ITeacherRepository 
    {
        private readonly ApplicationContext _applicationContext = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        public TeacherRepository(ApplicationContext myApplicationContext)
        {
            _applicationContext = myApplicationContext;
        }
        public void Create(Teacher teacher)
        {
           _applicationContext.teachers.Add(teacher);
            _applicationContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Teacher teacher=(from teacherObj in _applicationContext.teachers
                             where teacherObj.TeacherId==id
                             select teacherObj).FirstOrDefault();
            _applicationContext.teachers.Remove(teacher);
            _applicationContext.SaveChanges();
        }
    
        public List<Teacher> GetAllTeacher()
        {
            List<Teacher>teacherList=(from teacherObj in _applicationContext.teachers select teacherObj).ToList();
            return teacherList;
        }
    }
}
