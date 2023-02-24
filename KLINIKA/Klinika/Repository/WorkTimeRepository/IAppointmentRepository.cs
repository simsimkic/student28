using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Repository.WorkTimeRepository
{
    public interface IAppointmentRepository : Repository.IRepository
    {
        List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor);
        List<Appointment> GetAppointments();
        List<Appointment> GetAvailableAppointments();
        List<Appointment> GetAppointmentsByDoctor(Doctor doctor);
        List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate);
        List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate);
    }
}