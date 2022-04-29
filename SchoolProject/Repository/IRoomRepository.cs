using SchoolProject.Models;
using System.Collections.Generic;

namespace SchoolProject.Repository
{
    public interface IRoomRepository
    {
        public void Create(Room room);
        public List<Room> GetAllRooms();
        public void Delete(int id);
    }
}
