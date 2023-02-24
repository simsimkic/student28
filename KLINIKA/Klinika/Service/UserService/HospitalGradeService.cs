using Model.UserModel;
using Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public class HospitalGradeService : IHospitalGradeService
    {
        private static HospitalGradeService instance { get; set; }
        private HospitalGradeRepository hospitalGradeRepository { get; set; }

        public static HospitalGradeService GetInstance(HospitalGradeRepository hospitalGradeRepository)
        {
            if(instance == null)
            {
                instance = new HospitalGradeService(hospitalGradeRepository);
            }
            return instance;
        }

        private HospitalGradeService(HospitalGradeRepository hospitalGradeRepository)
        {
            this.hospitalGradeRepository = hospitalGradeRepository;
        }

        public double AverageHospitalGrade()
        {
            double GradesNumber = hospitalGradeRepository.GetAll().Count;
            double gradeSum = 0;
            foreach (HospitalGrade hospitalGrade in hospitalGradeRepository.GetAll())
            {
                gradeSum += hospitalGrade.grade;
            }
            return gradeSum/GradesNumber;
        }

        public void AddHospitalGrade(int hospitalGrade)
        {
            hospitalGradeRepository.Add(hospitalGrade);
        }
    }
}