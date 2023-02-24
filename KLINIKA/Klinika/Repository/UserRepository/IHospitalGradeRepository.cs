using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Repository.UserRepository
{
    public interface IHospitalGradeRepository
    {
        Object Add(object obj);
        List<HospitalGrade> GetAll();
    }
}