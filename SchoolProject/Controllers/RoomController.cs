using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;
using System.Collections.Generic;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        //list all students
        [HttpGet]
        public ActionResult Index()
        {
            List<Room> roomList = _roomRepository.GetAllRooms();
            return View(roomList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            _roomRepository.Create(room);
            List<Room> roomList = _roomRepository.GetAllRooms();
            return View("Index", roomList);
        }
        public ActionResult Delete(int id)
        {
            _roomRepository.Delete(id);
            List<Room> roomList = _roomRepository.GetAllRooms();
            return View("Index", roomList );
        }
    }
}
