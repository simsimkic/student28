using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class DepartmentDecorator : IDepartmentController
    {
        private IDepartmentController iDepartmentController { get; set; }
        private User user { get; set; }

        public DepartmentDecorator(IDepartmentController iDepartmentController, User user)
        {
            this.iDepartmentController = iDepartmentController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iDepartmentController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iDepartmentController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iDepartmentController.Edit(obj);
        }

        public List<Department> GetAllDepartments()
        {
            return iDepartmentController.GetAllDepartments();
        }

        public Department GetDepartmentBySpecialization(string specialization)
        {
            return iDepartmentController.GetDepartmentBySpecialization(specialization);
        }
    }
}