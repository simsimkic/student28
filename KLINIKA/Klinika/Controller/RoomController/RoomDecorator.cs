using Model.RoomModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.RoomController
{
    public class RoomDecorator : IRoomController
    {
        private IRoomController iRoomController { get; set; }
        private User user { get; set; }

        public RoomDecorator(IRoomController iRoomController, User user)
        {
            this.iRoomController = iRoomController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iRoomController.Add(obj);
        }

        public void AddEquipmentToRoom(Equipment equipment, int roomNumber)
        {
            iRoomController.AddEquipmentToRoom(equipment, roomNumber);
        }

        public object Delete(object obj)
        {
            return iRoomController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iRoomController.Edit(obj);
        }

        public List<Room> GetAllRooms()
        {
            return iRoomController.GetAllRooms();
        }

        public List<Room> GetAllSurgeryRooms()
        {
            return iRoomController.GetAllSurgeryRooms();
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            return iRoomController.GetRoomByNumber(roomNumber);
        }

        public List<RoomEquipment> GetRoomEquipment(int roomNumber)
        {
            return iRoomController.GetRoomEquipment(roomNumber);
        }

        public void IncreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            iRoomController.IncreaseEquipmentInRoom(roomNumber, equipment, amount);
        }

        public void DecreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            iRoomController.DecreaseEquipmentInRoom(roomNumber, equipment, amount);
        }

        public List<Room> getAllHospitalBedrooms()
        {
            return iRoomController.getAllHospitalBedrooms();
        }
    }
}