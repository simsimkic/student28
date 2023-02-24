using System;

namespace Model.WorkTimeModel
{
    public class Date
    {
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public Date(DateTime date, DateTime startTime, DateTime endTime)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}