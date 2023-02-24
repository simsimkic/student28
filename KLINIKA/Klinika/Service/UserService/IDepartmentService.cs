using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Service.UserService
{
    public interface IDepartmentService : IService
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentBySpecialization(String specialization);
    }
}