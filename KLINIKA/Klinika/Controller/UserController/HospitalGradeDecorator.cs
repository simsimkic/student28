using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class HospitalGradeDecorator : IHospitalGradeController
    {
        private IHospitalGradeController iGradeController { get; set; }
        private User user { get; set; }

        public HospitalGradeDecorator(IHospitalGradeController iGradeController, User user)
        {
            this.iGradeController = iGradeController;
            this.user = user;
        }

        public void AddHospitalGrade(int hospitalGrade)
        {
            iGradeController.AddHospitalGrade(hospitalGrade);
        }

        public double AverageHospitalGrade()
        {
            return iGradeController.AverageHospitalGrade();
        }
    }
}