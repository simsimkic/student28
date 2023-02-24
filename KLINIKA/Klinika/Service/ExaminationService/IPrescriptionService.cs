using Model.ExaminationModel;
using System;

namespace Service.ExaminationService
{
    public interface IPrescriptionService
    {
        Prescription AddPrescription(Prescription prescription);
    }
}