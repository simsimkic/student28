using Model.ExaminationModel;
using System;

namespace Repository.ExaminationRepository
{
    public interface IPrescriptionRepository
    {
        Prescription AddPrescription(Prescription prescription);
    }
}