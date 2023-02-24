using System;
using Model.RoomModel;

namespace Model.ExaminationModel
{
    public class Hospitalization
    {
        public Room room { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }


        public Hospitalization(Room room, DateTime dateStart, DateTime dateEnd)
        {
            this.room = room;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }
    }
}