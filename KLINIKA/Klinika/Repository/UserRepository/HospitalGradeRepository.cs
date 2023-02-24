using System;
using System.Collections.Generic;
using System.Linq;
using Klinika.Repository;
using Model.UserModel;

namespace Repository.UserRepository
{
    public class HospitalGradeRepository : IHospitalGradeRepository
    {
        private FileRepository<HospitalGrade> stream { get; set; }
        private static HospitalGradeRepository instance { get; set; }

        public static HospitalGradeRepository GetInstance(FileRepository<HospitalGrade> stream)
        {
            if(instance == null)
            {
                instance = new HospitalGradeRepository(stream);
            }
            return instance;
        }

        private HospitalGradeRepository(FileRepository<HospitalGrade> stream)
        {
            this.stream = stream;
        }

        public Object Add(object obj)
        {
            var allHospitalGrades = stream.GetAll().ToList();
            allHospitalGrades.Add((HospitalGrade)obj);
            stream.SaveAll(allHospitalGrades);
            return obj;
        }

        public List<HospitalGrade> GetAll()
        {
            return stream.GetAll().ToList();
        }
    }
}