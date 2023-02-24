using Model.DrugModel;
using Model.RoomModel;
using Service.RoomService;
using System;
using System.Collections.Generic;

namespace Controller.RoomController
{
    public class RoomController : IRoomController
    {
        private static RoomController instance { get; set; }
        private RoomService roomService { get; set; }       

        public static RoomController GetInstance(RoomService roomService)
        {
            if (instance == null)
            {
                instance = new RoomController(roomService);
            }
            return instance;
        }

        private RoomController(RoomService roomService)
        {
            this.roomService = roomService;
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            return roomService.GetRoomByNumber(roomNumber);
        }

        public List<Room> GetAllRooms()
        {
            return roomService.GetAllRooms();
        }

        public void AddEquipmentToRoom(Equipment equipment, int roomNumber)
        {
            roomService.AddEquipmentToRoom(equipment, roomNumber);
        }

        public List<Room> GetAllSurgeryRooms()
        {
            return roomService.GetAllSurgeryRooms();
        }

        public List<RoomEquipment> GetRoomEquipment(int roomNumber)
        {
            return roomService.GetEquipmentInRoom(roomNumber);
        }

        public void IncreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            roomService.IncreaseEquipmentInRoom(roomNumber, equipment, amount);
        }

        public void DecreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            roomService.DecreaseEquipmentInRoom(roomNumber, equipment, amount);
        }

        public object Add(object obj)
        {
            return roomService.Add(obj);
        }

        public object Edit(object obj)
        {
            return roomService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return roomService.Delete(obj);
        }

        public List<Room> getAllHospitalBedrooms()
        {
            return roomService.GetAllHospitalBedrooms();
        }
    }
}