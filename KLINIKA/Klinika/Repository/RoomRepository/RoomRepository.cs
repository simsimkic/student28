using Klinika.Repository;
using Model.RoomModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.RoomRepository
{
    public class RoomRepository : IRoomRepository
    {
        private static RoomRepository instance { get; set; }
        private FileRepository<Room> stream { get; set; }

        public static RoomRepository GetInstance(FileRepository<Room> stream)
        {
            if (instance == null)
            {
                instance = new RoomRepository(stream);
            }
            return instance;
        }

        private RoomRepository(FileRepository<Room> stream)
        {
            this.stream = stream;
        }

        public List<Room> GetAvailableRoomsByType(RoomType roomType, DateTime startDate, DateTime endDate) //Problem
        {
            List<Room> availableRooms = new List<Room>();
            foreach(Room room in stream.GetAll().ToList())
            {
                if(room.roomType == roomType && room.roomAvailable && room.workTime.startDate >= startDate && room.workTime.endDate <= endDate)
                {
                        availableRooms.Add(room);
                }
            }
            return availableRooms;
        }

        public List<Room> GetAllRooms()
        {
            return stream.GetAll().ToList();
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            foreach (Room room in stream.GetAll().ToList())
            {
                if (room.roomNumber == roomNumber)
                {
                    return room;
                }
            }
            return null;
        }

        public List<Room> GetAllSurgeryRooms()
        {
            List<Room> surgeryRooms = new List<Room>();
            foreach (Room room in stream.GetAll().ToList())
            {
                if (room.roomType == RoomType.SurgeryRoom)
                {
                    surgeryRooms.Add(room);
                }
            }
            return surgeryRooms;
        }

        public object Add(object obj)
        {
            var allRoms = stream.GetAll().ToList();
            allRoms.Add((Room)obj);
            stream.SaveAll(allRoms);
            return obj;
        }

        public object Edit(object obj)
        {
            var allRoms = stream.GetAll().ToList();
            Room editedRoom = (Room)obj;
            foreach (Room room in allRoms)
            {
                EditRoomIfFound(room, editedRoom);
            }
            stream.SaveAll(allRoms);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allRooms = stream.GetAll().ToList();
            Room room = (Room)obj;
            if (allRooms.Remove(room) == true)
            {
                stream.SaveAll(allRooms);
                return true;
            }
            return false;
        }

        private void EditAllRoomAttributes(Room room, Room editedRoom)
        {
            room.roomAvailable = editedRoom.roomAvailable;
            room.roomEquipment = editedRoom.roomEquipment;
            room.roomSize = editedRoom.roomSize;
            room.roomType = editedRoom.roomType;
            room.workTime = editedRoom.workTime;
            room.bedNumber = editedRoom.bedNumber;
            room.bedsAvailable = editedRoom.bedsAvailable;
        }

        private void EditRoomIfFound(Room room, Room editedRoom)
        {
            if (room.roomNumber == editedRoom.roomNumber)
            {
                EditAllRoomAttributes(room, editedRoom);
            }
        }
    }
}