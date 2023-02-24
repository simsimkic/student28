using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Service.RoomService
{
    public interface IRoomService : IService
    {
        List<Room> GetAvailableRoomsByType(RoomType roomType, DateTime startDate, DateTime endDate);
        List<Room> GetAllRooms();
        Room GetRoomByNumber(int roomNumber);
        void AddEquipmentToRoom(Equipment equipment, int roomNumber);
        void IncreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount);
        void DecreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount);
        List<RoomEquipment> GetEquipmentInRoom(int roomNumber);
        void ReserveRoom(int roomId);
        void ReserveBed(int roomId);
        List<Room> GetAllSurgeryRooms();
        List<Room> GetAllHospitalBedrooms();
    }
}