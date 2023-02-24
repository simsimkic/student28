using Model.ExaminationModel;
using System;
using Service.ExaminationService;

namespace Controller.ExaminationController
{
    public class PrescriptionController : IPrescriptionController
    {
        private static PrescriptionController instance { get; set; }
        private PrescriptionService prescriptionService { get; set; }

        public static PrescriptionController GetInstance(PrescriptionService prescriptionService)
        {
            if (instance == null)
            {
                instance = new PrescriptionController(prescriptionService);
            }
            return instance;
        }

        private PrescriptionController(PrescriptionService prescriptionService)
        {
            this.prescriptionService = prescriptionService;
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            return prescriptionService.AddPrescription(prescription);
        }
    }
}