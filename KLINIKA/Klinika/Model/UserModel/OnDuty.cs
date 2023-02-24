using System;

namespace Model.UserModel
{
    public class OnDuty
    {
        public Doctor doctor { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public OnDuty(Doctor doctor, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime)
        {
            this.doctor = doctor;
            this.startDate = startDate;
            this.endDate = endDate;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}