using System;

namespace Model.RoomModel
{
    public class RoomEquipment
    {
        public int amountInRoom { get; set; }
        public Equipment equipment { get; set; }

        public RoomEquipment(int amountInRoom, Equipment equipment)
        {
            this.amountInRoom = amountInRoom;
            this.equipment = equipment;
        }
    }
}