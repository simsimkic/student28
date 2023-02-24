using System;
using System.Collections.Generic;

namespace Model.UserModel
{
    public class Department
    {
        public List<Doctor> doctors { get; set; }
        public String specialization { get; set; }

        public Department(List<Doctor> doctors, string specialization)
        {
            this.doctors = doctors;
            this.specialization = specialization;
        }

    }
}