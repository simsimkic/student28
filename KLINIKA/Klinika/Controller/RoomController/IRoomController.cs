using Model.DrugModel;
using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Controller.RoomController
{
    public interface IRoomController : IController
    {
        Room GetRoomByNumber(int roomNumber);
        List<Room> GetAllRooms();
        void AddEquipmentToRoom(Equipment equipment, int roomNumber);
        List<Room> GetAllSurgeryRooms();
        List<RoomEquipment> GetRoomEquipment(int roomNumber);
        List<Room> getAllHospitalBedrooms();
        void IncreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount);
        void DecreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount);
    }
}