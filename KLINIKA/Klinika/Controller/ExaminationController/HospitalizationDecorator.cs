using Model.RoomModel;
using System;
using Model.UserModel;
using Model.ExaminationModel;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class HospitalizationDecorator : IHospitalizationController
    {
        private IHospitalizationController iHospitalizationController { get; set; }
        private User user { get; set; }

        public HospitalizationDecorator(IHospitalizationController iHospitalizationController, User user)
        {
            this.iHospitalizationController = iHospitalizationController;
            this.user = user;
        }

        public Hospitalization AddHospitalization(Hospitalization hospitalization)
        {
            return iHospitalizationController.AddHospitalization(hospitalization);
        }
    }
}