using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationContext _applicationContext = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        public RoomRepository(ApplicationContext myApplicationContext)
        {
            _applicationContext = myApplicationContext;
        }
        public void Create(Room room)
        {
            _applicationContext.rooms.Add(room);
            _applicationContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Room room = (from roomObj in _applicationContext.rooms
                         where roomObj.RoomId == id
                         select roomObj).FirstOrDefault();
            _applicationContext.rooms.Remove(room);
            _applicationContext.SaveChanges();
        }

        public List<Room> GetAllRooms()
        {
            List<Room> roomList=(from roomObj in _applicationContext.rooms select roomObj).ToList();
            return roomList;
        }
    }
}
