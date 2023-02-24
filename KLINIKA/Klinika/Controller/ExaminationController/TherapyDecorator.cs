using Model.ExaminationModel;
using System;
using Model.UserModel;

namespace Controller.ExaminationController
{
    public class TherapyDecorator : ITherapyController
    {
        private ITherapyController iTherapyController { get; set; }
        private User user { get; set; }

        public TherapyDecorator(ITherapyController iTherapyController, User user)
        {
            this.iTherapyController = iTherapyController;
            this.user = user;
        }

        public Therapy AddTherapy(Therapy therapy)
        {
            return iTherapyController.AddTherapy(therapy);
        }
    }
}