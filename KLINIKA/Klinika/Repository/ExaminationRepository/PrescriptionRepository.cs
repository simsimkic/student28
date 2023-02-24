using Klinika.Repository;
using Model.ExaminationModel;
using System;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private static PrescriptionRepository instance { get; set; }
        private FileRepository<Prescription> stream { get; set; }

        public static PrescriptionRepository GetInstance(FileRepository<Prescription> stream)
        {
            if (instance == null)
            {
                instance = new PrescriptionRepository(stream);
            }
            return instance;
        }

        private PrescriptionRepository(FileRepository<Prescription> stream)
        {
            this.stream = stream;
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            var allPrescriptions = stream.GetAll().ToList();
            allPrescriptions.Add(prescription);
            stream.SaveAll(allPrescriptions);
            return prescription;
        }
    }
}