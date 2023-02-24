using System;
using Model.UserModel;

namespace Controller.UserController
{
    public class OnDutyDecorator : IOnDutyController
    {
        private IOnDutyController iOnDutyController { get; set; }
        private User user { get; set; }

        public OnDutyDecorator(IOnDutyController iOnDutyController, User user)
        {
            this.iOnDutyController = iOnDutyController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iOnDutyController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iOnDutyController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iOnDutyController.Edit(obj);
        }
    }
}