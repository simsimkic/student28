using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public interface IHospitalGradeController
    {
        void AddHospitalGrade(int hospitalGrade);
        Double AverageHospitalGrade();
    }
}