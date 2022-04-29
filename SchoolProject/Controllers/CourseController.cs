using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;
using System.Collections.Generic;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourserepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        public CourseController(ICourserepository courserepository, ITeacherRepository teacherRepository)
        {
            _courseRepository = courserepository;
            _teacherRepository = teacherRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Course> courseList = _courseRepository.GetAllCourse();
            return View(courseList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<Teacher> teacherList = _teacherRepository.GetAllTeacher();
            return View(teacherList);
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            _courseRepository.Create(course);
            List<Course> coursesList = _courseRepository.GetAllCourse();
            return View("Index", coursesList);
        }
        public ActionResult Delete(int id)
        {
            _courseRepository.Delete(id);
            List<Course> coursesList = _courseRepository.GetAllCourse();
            return View("Index", coursesList);
        }
    }
}
