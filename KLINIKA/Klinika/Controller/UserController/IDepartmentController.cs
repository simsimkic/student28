using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IDepartmentController : IController
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentBySpecialization(String specialization);
    }
}