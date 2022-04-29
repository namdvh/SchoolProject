using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;
using System;
using System.Collections.Generic;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //list all students
        [HttpGet] 
        public ActionResult Index()
        {
            List<Student>studentList = _studentRepository.GetAllStudents();
            return View(studentList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student std)
        {
            _studentRepository.AddStudent(std);
            List<Student> studentList = _studentRepository.GetAllStudents();
            return View("Index", studentList);
        }
        public ActionResult Delete(int id)
        {
            _studentRepository.Delete(id);
            List<Student> studentList = _studentRepository.GetAllStudents();
            return View("Index", studentList);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(int courseId,int studentId)
        {
            _studentRepository.Register(courseId,studentId);
            List<Student> studentList = _studentRepository.GetAllStudents();
            return View("Index", studentList);
        }
    }
}
