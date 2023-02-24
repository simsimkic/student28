using Klinika.Repository;
using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.UserRepository
{
    public class DoctorRepository : IDoctorRepository
    {
        private static DoctorRepository instance { get; set; }
        private FileRepository<Doctor> stream { get; set; }

        public static DoctorRepository GetInstance(FileRepository<Doctor> stream)
        {
            if(instance == null)
            {
                instance = new DoctorRepository(stream);
            }
            return instance;
        }

        private DoctorRepository(FileRepository<Doctor> stream)
        {
            this.stream = stream;
        }

        public List<Doctor> GetAllDoctors()
        {
            var allDoctors = stream.GetAll().ToList();
            return allDoctors;
        }

        public List<Doctor> GetAvailableDoctors()
        {
            var allAvailableDoctors = new List<Doctor>();
            foreach(Doctor doctor in stream.GetAll().ToList())
            {
                if(doctor.available == true)
                {
                    allAvailableDoctors.Add(doctor);
                }
            }
            return allAvailableDoctors;
        }

        public Doctor GetDoctorById(int employeeId)
        {
            foreach(Doctor doctor in stream.GetAll().ToList())
            {
                if(doctor.employeeId == employeeId)
                {
                    return doctor;
                }
            }
            return null;
        }

        public List<Doctor> GetAvailableSpecializedDoctors(String specialization)
        {
            var availableSpecializedDoctors = new List<Doctor>();
            foreach (Doctor doctor in stream.GetAll().ToList())
            {
                if(doctor.specialization.Equals(specialization) && doctor.available == true)
                {
                    availableSpecializedDoctors.Add(doctor);
                }
            }
            return availableSpecializedDoctors;
        }

        public List<Doctor> GetDoctorsByDepartment(string specialization)
        {
            var doctorsByDepartment = new List<Doctor>();
            foreach(Doctor doctor in stream.GetAll().ToList())
            {
                if (doctor.specialization.Equals(specialization))
                {
                    doctorsByDepartment.Add(doctor);
                }
            }
            return doctorsByDepartment;
        }

        public object Add(object obj)
        {
            var allDoctors = stream.GetAll().ToList();
            allDoctors.Add((Doctor)obj);
            stream.SaveAll(allDoctors);
            return (Doctor)obj;
        }

        public object Edit(object obj)
        {
            var allDoctors = stream.GetAll().ToList();
            var editedDoctor = (Doctor)obj;
            foreach(Doctor doctor in allDoctors)
            {
                if(doctor.employeeId == editedDoctor.employeeId)
                {
                    EditAllAttributes(doctor, editedDoctor);
                }
            }
            stream.SaveAll(allDoctors);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allDoctors = stream.GetAll().ToList();
            if (allDoctors.Remove((Doctor)obj))
            {
                return true;
            }
            stream.SaveAll(allDoctors);
            return false;
        }

        public List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor)
        {
            List<WorkTime> workTimesByDoctor = new List<WorkTime>();
            foreach(Doctor doctorIterable in stream.GetAll().ToList())
            {
                if (doctorIterable.Equals(doctor))
                {
                    foreach (WorkTime workTime in doctor.workTime)
                    {
                        if (DateTime.Compare(startDate, workTime.startDate) <= 0 && DateTime.Compare(endDate, workTime.endDate) >= 0)
                        {
                            workTimesByDoctor.Add(workTime);
                        }
                    }
                }
            }
            return workTimesByDoctor;
        }

        private void EditAllAttributes(Doctor doctor, Doctor editedDoctor)
        {
            doctor.adress = editedDoctor.adress;
            doctor.appGraded = editedDoctor.appGraded;
            doctor.dateOfBirth = editedDoctor.dateOfBirth;
            doctor.email = editedDoctor.email;
            doctor.employeeId = editedDoctor.employeeId;
            doctor.feedback = editedDoctor.feedback;
            doctor.gender = editedDoctor.gender;
            doctor.martialStatus = editedDoctor.martialStatus;
            doctor.name = editedDoctor.name;
            doctor.password = editedDoctor.password;
            doctor.personalId = editedDoctor.personalId;
            doctor.phoneNumber = editedDoctor.phoneNumber;
            doctor.surname = editedDoctor.surname;
            doctor.userLogged = editedDoctor.userLogged;
            doctor.username = editedDoctor.username;
            doctor.workTime = editedDoctor.workTime;
            doctor.doctorGrades = editedDoctor.doctorGrades;
            doctor.daysOff = editedDoctor.daysOff;
            doctor.onDuty = editedDoctor.onDuty;
            doctor.specialization = editedDoctor.specialization;
            doctor.available = editedDoctor.available;
        }
    }
}