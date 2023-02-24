using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Repository.RoomRepository
{
    public interface IRoomRepository : IRepository
    {
        List<Room> GetAvailableRoomsByType(RoomType roomType, DateTime startDate, DateTime endDate);
        List<Room> GetAllRooms();
        Room GetRoomByNumber(int roomNumber);
        List<Room> GetAllSurgeryRooms();
    }
}