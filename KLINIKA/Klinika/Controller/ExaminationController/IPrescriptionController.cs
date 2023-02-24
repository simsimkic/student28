using Model.ExaminationModel;
using System;

namespace Controller.ExaminationController
{
    public interface IPrescriptionController
    {
        Prescription AddPrescription(Prescription prescription);
    }
}