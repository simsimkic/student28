using Model.UserModel;
using Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Service.UserService
{
    public class PatientService : IPatientService
    {
        private static PatientService instance { get; set; }
        private PatientRepository patientRepository { get; set; }

        public static PatientService GetInstance(PatientRepository patientRepository)
        {
            if (instance == null)
            {
                instance = new PatientService(patientRepository);
            }
            return instance;
        }

        private PatientService(PatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public bool DeletePatient(Patient patient)
        {
            patientRepository.Delete(patient);
            return true;
        }

        public Patient GetPatientByUsername(string username)
        {
            List<Patient> allPatients = new List<Patient>();
            foreach(Patient patient in allPatients)
            {
                if (patient.username.Equals(username))
                {
                    return patient;
                }
            }
            return null;
        }

        public Patient RegisterPatient(Patient patient)
        {
            return (Patient)patientRepository.Add(patient);
        }

        public User EditUser(User user)
        {
            return (Patient)patientRepository.Edit(user);
        }

        public bool ChangePassword(User user)
        {
            patientRepository.Edit(user);
            return true;
        }

        public User LogIn(string username, string password)
        {
            List<Patient> allPatients = patientRepository.GetAllPatients();
            foreach (Patient patient in allPatients)
            {
                if (patient.username.Equals(username) && patient.password.Equals(password))
                {
                    patient.userLogged = true;
                    patientRepository.Edit(patient);
                    return patient;
                }
            }
            return null;
        }

        public bool LogOut()
        {
            List<Patient> allPatients = patientRepository.GetAllPatients();
            foreach (Patient patient in allPatients)
            {
                if (patient.userLogged == true)
                {
                    patient.userLogged = false;
                    return true;
                }
            }
            return false;
        }

        public List<Patient> GetFakeProfiles()
        {
            List<Patient> allPatients = patientRepository.GetAllPatients();
            List<Patient> fakeProfiles = new List<Patient>();
            foreach (Patient patient in allPatients)
            {
                if(patient.username.Length>20 || patient.name.Length>20 || patient.surname.Length > 20)
                {
                    fakeProfiles.Add(patient);
                }
            }
            return fakeProfiles;
        }

        public Patient RegisterGuestUser(Patient patient)
        {
            return patientRepository.RegisterGuestUser(patient);
        }
    }
}