using Model.RoomModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Model.WorkTimeModel
{
    public class WorkTime
    {
        public User user { get; set; }
        public int workTimeId { get; set; }
        public Room room { get; set; }
        public List<Appointment> appointment { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public Boolean working { get; set; }

        public WorkTime(int workTimeId, Room room, List<Appointment> appointment, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, bool working)
        {
            this.workTimeId = workTimeId;
            this.room = room;
            this.appointment = appointment;
            this.startDate = startDate;
            this.endDate = endDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.working = working;
        }
    }
}