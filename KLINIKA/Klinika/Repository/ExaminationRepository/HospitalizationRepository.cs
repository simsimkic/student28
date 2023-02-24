using Klinika.Repository;
using Model.ExaminationModel;
using System;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class HospitalizationRepository : IHospitalizationRepository
    {
        private static HospitalizationRepository instance { get; set; }
        private FileRepository<Hospitalization> stream { get; set; }

        public static HospitalizationRepository GetInstance(FileRepository<Hospitalization> stream)
        {
            if (instance == null)
            {
                instance = new HospitalizationRepository(stream);
            }
            return instance;
        }

        private HospitalizationRepository(FileRepository<Hospitalization> stream)
        {
            this.stream = stream;
        }

        public Hospitalization AddHospitalization(Hospitalization hospitalization)
        {
            var allHospitalization = stream.GetAll().ToList();
            allHospitalization.Add(hospitalization);
            stream.SaveAll(allHospitalization);
            return hospitalization;
        }
    }
}