using Model.UserModel;
using Model.WorkTimeModel;
using Repository.WorkTimeRepository;
using System;
using System.Collections.Generic;

namespace Service.WorkTimeService
{
    public class AppointmentService : IAppointmentService
    {
        private static AppointmentService instance;
        private AppointmentRepository appointmentRepository;
        private WorkTimeService workTimeService;
        
        public static AppointmentService GetInstance(AppointmentRepository appointmentRepository, WorkTimeService workTimeService)
        {
            if (instance == null)
            {
                instance = new AppointmentService(appointmentRepository, workTimeService);
            }
            return instance;
        }

        private AppointmentService(AppointmentRepository appointmentRepository, WorkTimeService workTimeService)
        {
            this.appointmentRepository = appointmentRepository;
            this.workTimeService = workTimeService;
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor)
        {
            return appointmentRepository.GetAvailableAppointmentsByDoctorAndDate(date, doctor);
        }

        public List<Appointment> GetAvailableAppointments()
        {
            return appointmentRepository.GetAvailableAppointments();
        }

        public Appointment ReserveAppointment(Appointment appointment)
        {
            appointment.available = false;
            return (Appointment)appointmentRepository.Edit(appointment);
        }

        public List<Appointment> GetAppointmentsByDoctor(Doctor doctor)
        {
            return appointmentRepository.GetAppointmentsByDoctor(doctor);
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            return appointmentRepository.GetAvailableAppointmentsByDoctorInRange(doctor, startDate, endDate);
        }

        public List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate)
        {
            return appointmentRepository.GetAvailableAppointmentsInRange(startDate, endDate);
        }

        public object Add(object obj)
        {
            return appointmentRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return appointmentRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return appointmentRepository.Delete(obj);
        }

        public Appointment FreeAppointment(Appointment appointment)
        {
            appointment.available = true;
            return (Appointment)appointmentRepository.Edit(appointment);
        }

        public List<Appointment> generateAppointmentsInWorkTime(WorkTime workTime)
        {
            foreach(DateTime day in EachDay(workTime.startDate, workTime.endDate))
            {
                foreach (DateTime appointment in EachAppointment(workTime.startTime, workTime.endTime))
                {
                    Date date = MakeOneAppointment(day, appointment);
                    workTime.appointment.Add(new Appointment(date, true, GetRandomNumber()));
                }
            }
            workTimeService.EditWorkTime(workTime);
            return workTime.appointment;
        }

        private IEnumerable<DateTime> EachAppointment(DateTime from, DateTime thru)
        {
            for (var date = from.Date; date.Date <= thru.Date; date = date.AddMinutes(20))
                yield return date;
        }

        private IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var date = from.Date; date.Date <= thru.Date; date = date.AddDays(1))
                yield return date;
        }

        private int GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1000);
            while(appointmentRepository.getAppointmentById(number) != null)
            {
                number = random.Next(1000);
            }
            return number;
        }

        private Date MakeOneAppointment(DateTime day, DateTime startAppointment)
        {
            DateTime endAppointment = startAppointment; //variable for end of appointment
            return new Date(day, startAppointment, endAppointment);
        }
    }
}