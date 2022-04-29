using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _applicationContext = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        public StudentRepository(ApplicationContext myApplicationContext)
        {
            _applicationContext= myApplicationContext;
        }
        public void AddStudent(Student std)
        {
            _applicationContext.students.Add(std);
            _applicationContext.SaveChanges();

        }

        public void Delete(int id)
        {
            Student student=(from studentObj in _applicationContext.students
                             where studentObj.StudentId==id
                             select studentObj).FirstOrDefault(); 
            _applicationContext.students.Remove(student);
            _applicationContext.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> studentList = (from StudentObj in _applicationContext.students
                                             select StudentObj).ToList();
                return studentList;
            }
            catch(Exception ex)
            {
                return null;

            }
            
            
        }

        public void Register(int courseId, int studentId)
        {
            _applicationContext.studentCourses.Add(new StudentCourse
            {
                CourseID = courseId,
                StudentId = studentId
            });
            _applicationContext.SaveChanges();
        }
    }
}
