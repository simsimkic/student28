using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.UserService
{
    public class DoctorService : IDoctorService
    {
        private static DoctorService instance { get; set; }
        private DoctorRepository doctorRepository { get; set; }
        private DepartmentService departmentService { get; set; }

        public static DoctorService GetInstance(DoctorRepository doctorRepository, DepartmentService departmentService)
        {
            if(instance == null)
            {
                instance = new DoctorService(doctorRepository, departmentService);
            }
            return instance;
        }

        private DoctorService(DoctorRepository doctorRepository, DepartmentService departmentService)
        {
            this.doctorRepository = doctorRepository;
            this.departmentService = departmentService;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> allDoctors = doctorRepository.GetAllDoctors();
            return allDoctors;
        }

        public List<Doctor> GetDoctorsByDepartment(string specialization)
        {
            return doctorRepository.GetDoctorsByDepartment(specialization);
        }

        public List<Doctor> GetAvailableDoctors()
        {
            List<Doctor> allAvailableDoctors = doctorRepository.GetAvailableDoctors();
            return allAvailableDoctors;
        }

        public Doctor GetDoctorById(int employeeId)
        {
            return doctorRepository.GetDoctorById(employeeId);
        }

        public List<Doctor> GetAvailableSpecializedDoctors(String specialization)
        {
            return doctorRepository.GetAvailableSpecializedDoctors(specialization);
        }

        public Doctor RegisterDoctor(Doctor doctor)
        {
            if(GetDepartmentIfExists(doctor) != null)
            {
                Department department = GetDepartmentIfExists(doctor);
                AddDoctorToDepartment(doctor, department);
                return (Doctor)doctorRepository.Add(doctor);
            }
            List<Doctor> doctorsOnDepartment = new List<Doctor>();
            doctorsOnDepartment.Add(doctor);
            departmentService.Add(new Department(doctorsOnDepartment, doctor.specialization));
            return (Doctor)doctorRepository.Add(doctor);
        }

        public void GradeDoctor(int grade, int empId)
        {
            foreach (Doctor doctor in doctorRepository.GetAllDoctors())
            {
                if (doctor.employeeId == empId)
                {
                    doctor.doctorGrades.Add(new DoctorGrade(grade));
                    doctorRepository.Edit(doctor);
                }
            }
        }

        public double AverageDoctorGrade(int empId)
        {
            foreach(Doctor doctor in doctorRepository.GetAllDoctors())
            {
                if(doctor.employeeId == empId)
                {
                    double GradesNumber = doctor.doctorGrades.Count;
                    double gradeSum = 0;
                    foreach (DoctorGrade doctorGrade in doctor.doctorGrades)
                    {
                        gradeSum += doctorGrade.grade;
                    }
                    return gradeSum / GradesNumber;
                }
            }
            return 0;
        }

        public User EditUser(User user)
        {
            return (User)doctorRepository.Edit(user);
        }

        public bool DeleteDoctor(Doctor doctor)
        {
            return doctorRepository.Delete(doctor);
        }

        public bool ChangePassword(User user)
        {
            doctorRepository.Edit(user);
            return true;
        }

        public User LogIn(string username, string password)
        {
           List<Doctor> doctors =  doctorRepository.GetAllDoctors();
           foreach(Doctor doctor in doctors)
            {
                if(doctor.username.Equals(username) && doctor.password.Equals(password))
                {
                    doctor.userLogged = true;
                    doctorRepository.Edit(doctor);
                    return doctor;
                }
            }
            return null;
        }

        public bool LogOut()
        {
            List<Doctor> doctors = doctorRepository.GetAllDoctors();
            foreach (Doctor doctor in doctors)
            {
                if (doctor.userLogged == true)
                {
                    doctor.userLogged = false;
                    doctorRepository.Edit(doctor);
                    return true;
                }
            }
            return false;
        }

        public List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor)
        {
            return doctorRepository.GetWorkTimesByDoctor(startDate, endDate, doctor);
        }

        public int GetNumberOfReservedAppointmentsInWorkTime(WorkTime workTime)
        {
            int number = 0;
            foreach(Appointment appointment in workTime.appointment)
            {
                if(appointment.available == false)
                {
                    number++;
                } 
            }
            return number;
        }

        private Department GetDepartmentIfExists(Doctor doctor)
        {
            foreach (Department department in departmentService.GetAllDepartments().ToList())
            {
                if (doctor.specialization.Equals(department.specialization))
                {
                    return department;
                }
            }
            return null;
        }

        private void AddDoctorToDepartment(Doctor doctor, Department department)
        {
            department.doctors.Add(doctor);
            departmentService.Edit(department);
        }
    }
}