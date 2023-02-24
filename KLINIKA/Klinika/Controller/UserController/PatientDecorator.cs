using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class PatientDecorator : IPatientController
    {
        private IPatientController iPatientController { get; set; }
        private User user { get; set; }

        public PatientDecorator(IPatientController iPatientController, User user)
        {
            this.iPatientController = iPatientController;
            this.user = user;
        }

        public bool ChangePassword(User user)
        {
            return iPatientController.ChangePassword(user);
        }

        public bool DeletePatient(Patient patient)
        {
            return iPatientController.DeletePatient(patient);
        }

        public User EditUser(User user)
        {
            return iPatientController.EditUser(user);
        }

        public Patient GetPatientByUsername(string username)
        {
            return iPatientController.GetPatientByUsername(username);
        }

        public User LogIn(string username, string password)
        {
            return iPatientController.LogIn(username, password);
        }

        public bool LogOut()
        {
            return iPatientController.LogOut();
        }

        public Patient RegisterPatient(Patient patient)
        {
            return iPatientController.RegisterPatient(patient);
        }

        public List<Patient> GetFakeProfiles()
        {
            return iPatientController.GetFakeProfiles();
        }

        public Patient RegisterGuestUser(Patient patient)
        {
            return iPatientController.RegisterGuestUser(patient);
        }
    }
}