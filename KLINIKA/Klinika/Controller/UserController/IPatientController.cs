using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IPatientController : IUserController
    {
        Patient GetPatientByUsername(String username);
        Patient RegisterPatient(Patient patient);
        Boolean DeletePatient(Patient patient);
        List<Patient> GetFakeProfiles();
        Patient RegisterGuestUser(Patient patient);
    }
}