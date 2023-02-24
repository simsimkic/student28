using Model.ExaminationModel;
using Repository.ExaminationRepository;
using System;

namespace Service.ExaminationService
{
    public class TherapyService : ITherapyService
    {
        private static TherapyService instance { get; set; }
        private TherapyRepository therapyRepository { get; set; }

        public static TherapyService GetInstance(TherapyRepository therapyRepository)
        {
            if (instance == null)
            {
                instance = new TherapyService(therapyRepository);
            }
            return instance;
        }

        private TherapyService(TherapyRepository therapyRepository)
        {
            this.therapyRepository = therapyRepository;
        }

        public Therapy AddTherapy(Therapy therapy)
        {
            return therapyRepository.AddTherapy(therapy);
        }
    }
}