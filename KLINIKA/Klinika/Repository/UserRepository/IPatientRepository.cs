using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Repository.UserRepository
{
    public interface IPatientRepository : IRepository
    {
        Patient GetPatientByUsername(String username);
        List<Patient> GetAllPatients();
        Patient RegisterGuestUser(Patient patient);
    }
}