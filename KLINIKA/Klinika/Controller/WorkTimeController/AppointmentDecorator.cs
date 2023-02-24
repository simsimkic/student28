using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.WorkTimeController
{
    public class AppointmentDecorator : IAppointmentController
    {
        private IAppointmentController iAppointmentController { get; set; }
        private User user { get; set; }

        public AppointmentDecorator(IAppointmentController iAppointmentController, User user)
        {
            this.iAppointmentController = iAppointmentController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iAppointmentController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iAppointmentController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iAppointmentController.Edit(obj);
        }

        public List<Appointment> GetAppointmentsByDoctor(Doctor doctor)
        {
            return iAppointmentController.GetAppointmentsByDoctor(doctor);
        }

        public List<Appointment> GetAvailableAppointments()
        {
            return iAppointmentController.GetAvailableAppointments();
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor)
        {
            return iAppointmentController.GetAvailableAppointmentsByDoctorAndDate(date, doctor);
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            return iAppointmentController.GetAvailableAppointmentsByDoctorInRange(doctor, startDate, endDate);
        }

        public Appointment ReserveAppointment(Appointment appointment)
        {
            return iAppointmentController.ReserveAppointment(appointment);
        }

        public Appointment FreeAppointment(Appointment appointment)
        {
            return iAppointmentController.FreeAppointment(appointment);
        }

        public List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate)
        {
            return iAppointmentController.GetAvailableAppointmentsInRange(startDate, endDate);
        }

        public List<Appointment> generateAppointmentsInWorkTime(WorkTime workTime)
        {
            return iAppointmentController.generateAppointmentsInWorkTime(workTime);
        }
    }
}