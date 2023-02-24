using Klinika;
using Klinika.Repository;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.WorkTimeRepository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private static AppointmentRepository instance { get; set; }
        private FileRepository<Appointment> stream { get; set; }

        public static AppointmentRepository GetInstance(FileRepository<Appointment> stream)
        {
            if (instance == null)
            {
                instance = new AppointmentRepository(stream);
            }
            return instance;
        }

        private AppointmentRepository(FileRepository<Appointment> stream)
        {
            this.stream = stream;
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorAndDate(DateTime date, Doctor doctor)
        {
            return getAppointmentByDate(doctor.workTime, date);
        }

        public List<Appointment> GetAppointments()
        {
            return stream.GetAll().ToList();
        }

        public Appointment getAppointmentById(int id)
        {
            foreach(Appointment appointment in stream.GetAll().ToList())
            {
                if(id == appointment.appointmentId)
                {
                    return appointment;
                }
            }
            return null;
        }

        public List<Appointment> GetAvailableAppointments()
        {
            List<Appointment> availableAppointments = new List<Appointment>();
            foreach (Appointment appointment in stream.GetAll().ToList())
            {
                if (appointment.available)
                {
                    availableAppointments.Add(appointment);
                }
            }
            return availableAppointments;
        }

        public List<Appointment> GetAppointmentsByDoctor(Doctor doctor)
        {
            List<Appointment> availableAppointments = new List<Appointment>();
            foreach (WorkTime workTime in doctor.workTime)
            {
                availableAppointments = GetAllAvailableAppointmentsByWorkTime(workTime, availableAppointments);
            }
            return availableAppointments;
        }

        public List<Appointment> GetAvailableAppointmentsByDoctorInRange(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach (WorkTime workTime in doctor.workTime)
            {
                if(!(endDate < workTime.startDate || startDate > workTime.endDate))
                {
                    foreach(Appointment appointment in workTime.appointment)
                    {
                        if(appointment.available)
                        {
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }

        public List<Appointment> GetAvailableAppointmentsInRange(DateTime startDate, DateTime endDate)
        {
            var allApointments = stream.GetAll().ToList();
            List<Appointment> appointments = new List<Appointment>();
            foreach (Appointment appointment in allApointments)
            {
                if (appointment.date.date >= startDate && appointment.date.date <= endDate)
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        public object Add(object obj)
        {
            var allAppointments = stream.GetAll().ToList();
            allAppointments.Add((Appointment)obj);
            stream.SaveAll(allAppointments);
            return obj;
        }

        public object Edit(object obj)
        {
            var allAppointments = stream.GetAll().ToList();
            Appointment editedAppointment = (Appointment)obj;
            foreach (Appointment appointment in allAppointments)
            {
                if (appointment.appointmentId == editedAppointment.appointmentId)
                {
                    EditAllAppointmentAttributes(appointment, editedAppointment);
                }
            }
            stream.SaveAll(allAppointments);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allAppointments = stream.GetAll().ToList();
            Appointment appointment = (Appointment)obj;
            if (allAppointments.Remove(appointment))
            {
                stream.SaveAll(allAppointments);
                return true;
            }
            return false;
        }

        private List<Appointment> GetAllAvailableAppointmentsByWorkTime(WorkTime workTime, List<Appointment> availableAppointments)
        {
            foreach (Appointment appointment in workTime.appointment)
            {
                if (appointment.available)
                {
                    availableAppointments.Add(appointment);
                }
            }
            return availableAppointments;
        }

        private void EditAllAppointmentAttributes(Appointment appointment, Appointment editedAppointment)
        {
            appointment.available = editedAppointment.available;
            appointment.date = editedAppointment.date;
        }

        private List<Appointment> getAvailableAppointmentsByWorkTime(WorkTime workTime, List<Appointment> availableAppointments, DateTime date)
        {
            foreach (Appointment appointment in workTime.appointment)
            {
                if (appointment.available)
                {
                    if (appointment.date.date == date)
                    {
                        availableAppointments.Add(appointment);
                    }
                }
            }
            return availableAppointments;
        }

        private List<Appointment> getAppointmentByDate(List<WorkTime> workTimes, DateTime date)
        {
            List<Appointment> availableAppointments = new List<Appointment>();
            foreach (WorkTime workTime in workTimes)
            {
                if (date >= workTime.startDate && date <= workTime.endDate)
                {
                    availableAppointments = getAvailableAppointmentsByWorkTime(workTime, availableAppointments, date);
                }
            }
            return availableAppointments;
        }
    }
}