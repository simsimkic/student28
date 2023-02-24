using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Service.UserService
{
    public interface IHospitalGradeService
    {
        void AddHospitalGrade(int hospitalGrade);
        double AverageHospitalGrade();
    }
}