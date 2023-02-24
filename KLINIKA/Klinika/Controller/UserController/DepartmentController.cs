using Model.UserModel;
using System;
using Service.UserService;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class DepartmentController : IDepartmentController
    {
        private static DepartmentController instance { get; set; }
        private DepartmentService departmentService { get; set; }       

        public static DepartmentController GetInstance(DepartmentService departmentService)
        {
            if(instance == null)
            {
                instance = new DepartmentController(departmentService);
            }
            return instance;
        }

        private DepartmentController(DepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        public List<Department> GetAllDepartments()
        {
            return departmentService.GetAllDepartments();
        }

        public Department GetDepartmentBySpecialization(string specialization)
        {
            return departmentService.GetDepartmentBySpecialization(specialization);
        }

        public object Add(object obj)
        {
            return departmentService.Add(obj);
        }

        public object Edit(object obj)
        {
            return departmentService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return departmentService.Delete(obj);
        }
    }
}