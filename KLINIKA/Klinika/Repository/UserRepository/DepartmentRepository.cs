using Model.UserModel;
using System;
using Klinika.Repository;
using System.Linq;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private static DepartmentRepository instance { get; set; }
        private FileRepository<Department> stream { get; set; }

        public static DepartmentRepository GetInstance(FileRepository<Department> stream)
        {
            if(instance == null)
            {
                instance = new DepartmentRepository(stream);
            }
            return instance;
        }

        private DepartmentRepository(FileRepository<Department> stream)
        {
            this.stream = stream;
        }

        public Department GetDepartmentBySpecialization(string specialization)
        {
            foreach(Department department in stream.GetAll().ToList())
            {
                if (department.specialization.Equals(specialization))
                {
                    return department;
                }
            }
            return null;
        }

        public List<Department> GetAllDepartments()
        {
            return stream.GetAll().ToList();
        }

        public object Add(object obj)
        {
            var allDepartments = stream.GetAll().ToList();
            allDepartments.Add((Department)obj);
            stream.SaveAll(allDepartments);
            return obj;
        }

        public object Edit(object obj)
        {
            var allDepartments = stream.GetAll().ToList();
            var editedDepartment = (Department)obj;
            foreach(Department department in allDepartments)
            {
                if (department.specialization.Equals(editedDepartment.specialization))
                {
                    EditAllAttributes(department, editedDepartment);
                }
            }
            stream.SaveAll(allDepartments);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allDepartments = stream.GetAll().ToList();
            if (allDepartments.Remove((Department)obj))
            {
                stream.SaveAll(allDepartments);
                return true;
            }
            return false;
        }

        private void EditAllAttributes(Department department,Department editedDepartment)
        {
            department.doctors = editedDepartment.doctors;
            department.specialization = editedDepartment.specialization;
        }
    }
}