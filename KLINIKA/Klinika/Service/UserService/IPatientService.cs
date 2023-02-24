using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public interface IPatientService : IUserService
    {
        Boolean DeletePatient(Patient patient);
        Patient GetPatientByUsername(String username);
        Patient RegisterPatient(Patient patient);
        List<Patient> GetFakeProfiles();
        Patient RegisterGuestUser(Patient patient);
    }
}