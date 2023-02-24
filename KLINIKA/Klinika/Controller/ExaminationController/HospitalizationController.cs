using Model.RoomModel;
using System;
using Service.ExaminationService;
using Model.ExaminationModel;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class HospitalizationController : IHospitalizationController
    {
        private static HospitalizationController instance { get; set; }
        private HospitalizationService hospitalizationService { get; set; }

        public static HospitalizationController GetInstance(HospitalizationService hospitalizationService)
        {
            if (instance == null)
            {
                instance = new HospitalizationController(hospitalizationService);
            }
            return instance;
        }

        private HospitalizationController(HospitalizationService hospitalizationService)
        {
            this.hospitalizationService = hospitalizationService;
        }

        public Hospitalization AddHospitalization(Hospitalization hospitalization)
        {
            return hospitalizationService.AddHospitalization(hospitalization);
        }
    }
}