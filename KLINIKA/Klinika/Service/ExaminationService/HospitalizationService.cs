using Model.ExaminationModel;
using Model.RoomModel;
using Repository.ExaminationRepository;
using System;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public class HospitalizationService : IHospitalizationService
    {
        private static HospitalizationService instance { get; set; }
        private HospitalizationRepository hospitalizationRepository { get; set; }

        public static HospitalizationService GetInstance(HospitalizationRepository hospitalizationRepository)
        {
            if (instance == null)
            {
                instance = new HospitalizationService(hospitalizationRepository);
            }
            return instance;
        }

        private HospitalizationService(HospitalizationRepository hospitalizationRepository)
        {
            this.hospitalizationRepository = hospitalizationRepository;
        }

        public Hospitalization AddHospitalization(Hospitalization hospitalization)
        {
            return hospitalizationRepository.AddHospitalization(hospitalization);
        }
    }
}