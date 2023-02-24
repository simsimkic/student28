using System;

namespace Model.WorkTimeModel
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public Date date { get; set; }
        public Boolean available { get; set; }

        public Appointment(Date date, bool available, int appointmentId)
        {
            this.date = date;
            this.available = available;
            this.appointmentId = appointmentId;
        }
    }
}