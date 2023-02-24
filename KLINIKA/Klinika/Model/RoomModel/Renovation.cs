using System;

namespace Model.RoomModel
{
    public class Renovation
    {
        public Room room { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Renovation(Room room, DateTime startDate, DateTime endDate)
        {
            this.room = room;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}