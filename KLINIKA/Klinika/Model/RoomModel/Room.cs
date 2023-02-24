using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Model.RoomModel
{
    public class Room
    {
        public List<RoomEquipment> roomEquipment { get; set; }
        public WorkTime workTime { get; set; }
        public int roomNumber { get; set; }
        public RoomType roomType { get; set; }
        public Boolean roomAvailable { get; set; }
        public int roomSize { get; set; }
        public int bedNumber { get; set; }
        public int bedsAvailable { get; set; }

        public Room(List<RoomEquipment> roomEquipment, WorkTime workTime, int roomNumber, RoomType roomType, bool roomAvailable, int roomSize, int bedNumber, int bedsAvailable)
        {
            this.roomEquipment = roomEquipment;
            this.workTime = workTime;
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.roomAvailable = roomAvailable;
            this.roomSize = roomSize;
            this.bedNumber = bedNumber;
            this.bedsAvailable = bedsAvailable;
        }
    }
}