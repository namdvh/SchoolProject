using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.Repository
{
    public class CourseRepository : ICourserepository
    {
        private readonly ApplicationContext _applicationContext = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        public CourseRepository(ApplicationContext myApplicationContext)
        {
            _applicationContext = myApplicationContext;
        }
        public void Create(Course course)
        {
            _applicationContext.courses.Add(course);
            _applicationContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Course course = (from courseObj in _applicationContext.courses
                         where courseObj.CourseId == id
                         select courseObj).FirstOrDefault();
            _applicationContext.courses.Remove(course);
            _applicationContext.SaveChanges();
        }

        public List<Course> GetAllCourse()
        {
            List<Course> coursesList = (from courseObj in _applicationContext.courses select courseObj).ToList();
            return coursesList;
        }
    }
}
