using Model.UserModel;
using System;
using Repository.UserRepository;
using System.Collections.Generic;

namespace Service.UserService
{
    public class DepartmentService : IDepartmentService
    {
        private static DepartmentService instance { get; set; }
        private DepartmentRepository departmentRepository { get; set; }

        public static DepartmentService GetInstance(DepartmentRepository departmentRepository)
        {
            if(instance == null)
            {
                instance = new DepartmentService(departmentRepository);
            }
            return instance;
        }

        private DepartmentService(DepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public List<Department> GetAllDepartments()
        {
            return departmentRepository.GetAllDepartments();
        }

        public Department GetDepartmentBySpecialization(string specialization)
        {
            return departmentRepository.GetDepartmentBySpecialization(specialization);
        }

        public object Add(object obj)
        {
            return departmentRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return departmentRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return departmentRepository.Delete(obj);
        }
    }
}