using Model.ExaminationModel;
using Repository.ExaminationRepository;
using System;

namespace Service.ExaminationService
{
    public class PrescriptionService : IPrescriptionService
    {
        private static PrescriptionService instance { get; set; }
        private PrescriptionRepository prescriptionRepository { get; set; }

        public static PrescriptionService GetInstance(PrescriptionRepository prescriptionRepository)
        {
            if (instance == null)
            {
                instance = new PrescriptionService(prescriptionRepository);
            }
            return instance;
        }

        private PrescriptionService(PrescriptionRepository prescriptionRepository)
        {
            this.prescriptionRepository = prescriptionRepository;
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            return prescriptionRepository.AddPrescription(prescription);
        }
    }
}