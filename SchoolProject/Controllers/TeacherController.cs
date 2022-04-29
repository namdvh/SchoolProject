using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;
using System.Collections.Generic;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public ActionResult Index()
        {
            List<Teacher> teacherList = _teacherRepository.GetAllTeacher();
            return View(teacherList);   
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            _teacherRepository.Create(teacher);
            List<Teacher> teacherList = _teacherRepository.GetAllTeacher();
            return View("Index", teacherList);
        }
        public ActionResult Delete(int id)
        {
            _teacherRepository.Delete(id);
            List<Teacher> teacherList = _teacherRepository.GetAllTeacher();
            return View("Index",teacherList);
        }
    }
}
