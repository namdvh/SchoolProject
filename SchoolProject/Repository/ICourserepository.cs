using SchoolProject.Models;
using System.Collections.Generic;

namespace SchoolProject.Repository
{
    public interface ICourserepository
    {
        public void Create(Course course);
        public List<Course> GetAllCourse();
        public void Delete(int id);
    }
}
