using Model.UserModel;
using Service.UserService;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class PatientController : IPatientController
    {
        private static PatientController instance { get; set; }
        private PatientService patientService { get; set; }

        public static PatientController GetInstance(PatientService patientService)
        {
            if (instance == null)
            {
                instance = new PatientController(patientService);
            }
            return instance;
        }

        private PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        public Patient GetPatientByUsername(string username)
        {
            return patientService.GetPatientByUsername(username);
        }

        public Patient RegisterPatient(Patient patient)
        {
            return patientService.RegisterPatient(patient);
        }

        public bool DeletePatient(Patient patient)
        {
            return patientService.DeletePatient(patient);
        }

        public User EditUser(User user)
        {
            return patientService.EditUser(user);
        }

        public bool ChangePassword(User user)
        {
            return patientService.ChangePassword(user);
        }

        public User LogIn(string username, string password)
        {
            return patientService.LogIn(username, password);
        }

        public bool LogOut()
        {
            return patientService.LogOut();
        }

        public List<Patient> GetFakeProfiles()
        {
            return patientService.GetFakeProfiles();
        }

        public Patient RegisterGuestUser(Patient patient)
        {
            return patientService.RegisterGuestUser(patient);
        }
    }
}