using Model.UserModel;
using System;

namespace Controller.UserController
{
    public class GuestUserDecorator : IGuestUserController
    {
        private IGuestUserController iGuestUserController { get; set; }
        private User user { get; set; }

        public GuestUserDecorator(IGuestUserController iGuestUserController, User user)
        {
            this.iGuestUserController = iGuestUserController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iGuestUserController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iGuestUserController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iGuestUserController.Edit(obj);
        }
    }
}