using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.UserModel;

namespace Repository.UserRepository
{
    public interface IDoctorGradeRepository 
    {
        DoctorGrade Add(Doctor doctor,int grade);
        List<DoctorGrade> GetGradesByDoctor(Doctor doctor);     
    }
}
