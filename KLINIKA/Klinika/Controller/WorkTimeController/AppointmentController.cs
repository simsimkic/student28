using Klinika;
using Model.UserModel;
using Model.WorkTimeModel;
using Service.WorkTimeService;
using System;
using System.Collections.Generic;

namespace Controller.WorkTimeController
{
    public class AppointmentController : IAppointmentController
    {
        private static AppointmentController instance { get; set; }
        private AppointmentService appointmentService { get; set; }

        public static AppointmentController GetInstance(AppointmentService appointmentService)
        {
            if (instance == null)
            {
                instance = new AppointmentController(appointmentService);
            }
            return instance;
        }

        private AppointmentController(AppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        public List<Appointment> GetAvailableAppointments()
        {
            return appointmentService.GetAvailableAppointments();
        }

        public List<Appointment> GetAppointmentsByDoctor(Doctor doctor)
        {
            return appointmentService.GetAppointmentsByDoctor(doctor);
        }

        public Appointment ReserveAppointment(Appointment appointment)
        {
            return appointmentService.ReserveAppointment(appointment);
        }

        public Appointment FreeAppointment(Appointment appointment)
        {
            return appointmentService.FreeAppointment(appointment);
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor)
        {
            return appointmentService.GetAvailableAppointmentsByDoctorAndDate(date, doctor);
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            return appointmentService.GetAvailableAppointmentsByDoctorInRange(doctor, startDate, endDate);
        }

        public List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate)
        {
            return appointmentService.GetAvailableAppointmentsInRange(startDate, endDate);
        }

        public object Add(object obj)
        {
            return appointmentService.Add(obj);
        }

        public object Edit(object obj)
        {
            return appointmentService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return appointmentService.Delete(obj);
        }

        public List<Appointment> generateAppointmentsInWorkTime(WorkTime workTime)
        {
            return appointmentService.generateAppointmentsInWorkTime(workTime);
        }
    }
}