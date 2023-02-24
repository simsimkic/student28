using Model.ExaminationModel;
using System;

namespace Repository.ExaminationRepository
{
    public interface ITherapyRepository
    {
        Therapy AddTherapy(Therapy therapy);
    }
}