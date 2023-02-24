using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Service.WorkTimeService
{
    public interface IAppointmentService : IService
    {
        List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor);
        List<Appointment> GetAvailableAppointments();
        Appointment ReserveAppointment(Appointment appointment);
        List<Appointment> GetAppointmentsByDoctor(Doctor doctor);
        List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate);
        Appointment FreeAppointment(Appointment appointment);
        List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate);
    }
}