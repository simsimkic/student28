using Model.RoomModel;
using Model.UserModel;
using System;

namespace Controller.RoomController
{
    public class RenovationDecorator : IRenovationController
    {
        private IRenovationController iRenovationController { get; set; }
        private User user { get; set; }

        public RenovationDecorator(IRenovationController iRenovationController, User user)
        {
            this.iRenovationController = iRenovationController;
            this.user = user;
        }

        public Renovation AddRenovation(Renovation renovation)
        {
            return iRenovationController.AddRenovation(renovation);
        }
    }
}