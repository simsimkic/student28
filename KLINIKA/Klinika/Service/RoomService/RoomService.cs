using Model.RoomModel;
using Repository.RoomRepository;
using System;
using System.Collections.Generic;

namespace Service.RoomService
{
    public class RoomService : IRoomService
    {
        private static RoomService instance { get; set; }
        private RoomRepository roomRepository { get; set; }

        public static RoomService GetInstance(RoomRepository roomRepository)
        {
            if (instance == null)
            {
                instance = new RoomService(roomRepository);
            }
            return instance;
        }

        private RoomService(RoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        public List<Room> GetAvailableRoomsByType(RoomType roomType, DateTime startDate, DateTime endDate)
        {
            return roomRepository.GetAvailableRoomsByType(roomType, startDate, endDate);
        }

        public List<Room> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            return roomRepository.GetRoomByNumber(roomNumber);
        }

        public void AddEquipmentToRoom(Equipment equipment, int roomNumber)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            roomWithGivenNumber.roomEquipment.Add(new RoomEquipment(0, equipment));
            roomRepository.Edit(roomWithGivenNumber);
        }

        public void IncreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            foreach(RoomEquipment re in roomWithGivenNumber.roomEquipment)
            {
                if(re.equipment.equipmentId == equipment.equipmentId)
                {
                    IncreaseAmountInRoomAndDecreaseAvailable(re, amount);
                    roomRepository.Edit(roomWithGivenNumber);
                }
            }
        }

        public void DecreaseEquipmentInRoom(int roomNumber, Equipment equipment, int amount)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            foreach (RoomEquipment re in roomWithGivenNumber.roomEquipment)
            {
                if (re.equipment.equipmentId == equipment.equipmentId)
                {
                    DecreaseAmountInRoomAndIncreaseAvailable(re, amount);
                    roomRepository.Edit(roomWithGivenNumber);
                }
            }
        }

        public List<RoomEquipment> GetEquipmentInRoom(int roomNumber)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            List<RoomEquipment> allEquipmentInRoom = new List<RoomEquipment>();
            foreach (RoomEquipment roomEquipment in roomWithGivenNumber.roomEquipment)
            {
                allEquipmentInRoom.Add(roomEquipment);
            }
            return allEquipmentInRoom;
        }

        public void ReserveRoom(int roomNumber)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            roomWithGivenNumber.roomAvailable = false;
            roomRepository.Edit(roomWithGivenNumber);
        }

        public void ReserveBed(int roomNumber)
        {
            Room roomWithGivenNumber = roomRepository.GetRoomByNumber(roomNumber);
            roomWithGivenNumber.bedsAvailable -= 1;
            SetRoomUnavailableIfZeroBeds(roomWithGivenNumber);
            roomRepository.Edit(roomWithGivenNumber);
        }

        public object Add(object obj)
        {
            return roomRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return roomRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return roomRepository.Delete(obj);
        }

        public List<Room> GetAllSurgeryRooms()
        {
            List<Room> allSurgeryRooms = new List<Room>();
            foreach (Room room in roomRepository.GetAllRooms())
            {
                AddSurgeryRoomsToList(room, allSurgeryRooms);
            }
            return allSurgeryRooms;
        }

        public List<Room> GetAllHospitalBedrooms()
        {
            List<Room> allHospitalBedrooms = new List<Room>();
            foreach(Room room in roomRepository.GetAllRooms())
            {
                AddHospitalBedroomsToList(room, allHospitalBedrooms);
            }
            return allHospitalBedrooms;
        }

        private void SetRoomUnavailableIfZeroBeds(Room room)
        {
            if (room.bedsAvailable == 0)
            {
                room.roomAvailable = false;
            }
        }

        private void IncreaseAmountInRoomAndDecreaseAvailable(RoomEquipment re, int amount)
        {
            re.amountInRoom += amount;
            re.equipment.equipmentAvailable -= amount;
        }

        private void DecreaseAmountInRoomAndIncreaseAvailable(RoomEquipment re, int amount)
        {
            re.amountInRoom -= amount;
            re.equipment.equipmentAvailable += amount;
        }

        private void AddSurgeryRoomsToList(Room room, List<Room> surgeryRooms)
        {
            if (room.roomType == RoomType.SurgeryRoom)
            {
                surgeryRooms.Add(room);
            }
        }

        private void AddHospitalBedroomsToList(Room room, List<Room> hospitalBedrooms)
        {
            if (room.roomType == RoomType.HospitalBedroom)
            {
                hospitalBedrooms.Add(room);
            }
        }
    }
}