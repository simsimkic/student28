using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Repository.UserRepository
{
    public interface IDepartmentRepository : IRepository
    {
        Department GetDepartmentBySpecialization(String specialization);
        List<Department> GetAllDepartments();
    }
}