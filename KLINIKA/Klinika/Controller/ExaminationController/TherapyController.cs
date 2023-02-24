using Model.ExaminationModel;
using System;
using Service.ExaminationService;

namespace Controller.ExaminationController
{
    public class TherapyController : ITherapyController
    {
        private static TherapyController instance { get; set; }
        private TherapyService therapyService { get; set; }

        public static TherapyController GetInstance(TherapyService therapyService)
        {
            if (instance == null)
            {
                instance = new TherapyController(therapyService);
            }
            return instance;
        }

        private TherapyController(TherapyService therapyService)
        {
            this.therapyService = therapyService;
        }

        public Therapy AddTherapy(Therapy therapy)
        {
            return therapyService.AddTherapy(therapy);
        }
    }
}