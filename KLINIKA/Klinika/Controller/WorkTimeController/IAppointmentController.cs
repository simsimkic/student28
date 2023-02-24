using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.WorkTimeController
{
    public interface IAppointmentController : IController
    {
        List<Appointment> GetAvailableAppointments();
        List<Appointment> GetAppointmentsByDoctor(Doctor doctor);
        Appointment ReserveAppointment(Appointment appointment);
        Appointment FreeAppointment(Appointment appointment);
        List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor);
        List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate);
        List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate);
        List<Appointment> generateAppointmentsInWorkTime(WorkTime workTime);
    }
}