using Model.UserModel;
using Service.UserService;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class HospitalGradeController : IHospitalGradeController
    {
        private static HospitalGradeController instance { get; set; }
        private HospitalGradeService hospitalGradeService { get; set; }

        public static HospitalGradeController GetInstance(HospitalGradeService gradeService)
        {
            if (instance == null)
            {
                instance = new HospitalGradeController(gradeService);
            }
            return instance;
        }

        private HospitalGradeController(HospitalGradeService gradeService)
        {
            this.hospitalGradeService = gradeService;
        }

        public double AverageHospitalGrade()
        {
            return hospitalGradeService.AverageHospitalGrade();
        }

        public void AddHospitalGrade(int hospitalGrade)
        {
            hospitalGradeService.AddHospitalGrade(hospitalGrade);
        }
    }
}