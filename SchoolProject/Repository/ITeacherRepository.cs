using SchoolProject.Models;
using System.Collections.Generic;

namespace SchoolProject.Repository
{
    public interface ITeacherRepository
    {
        public void Create(Teacher teacher);
        public List<Teacher> GetAllTeacher();
        public void Delete(int id);
    }
}
