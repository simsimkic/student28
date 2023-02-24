using Model.UserModel;
using System;

namespace Controller.UserController
{
    public class GuestUserMedicalRecordDecorator : IGuestUserMedicalRecordController
    {
        private IGuestUserMedicalRecordController iGuestUserMedicalRecordController { get; set; }
        private User user { get; set; }

        public GuestUserMedicalRecordDecorator(IGuestUserMedicalRecordController iGuestUserMedicalRecordController, User user)
        {
            this.iGuestUserMedicalRecordController = iGuestUserMedicalRecordController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iGuestUserMedicalRecordController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iGuestUserMedicalRecordController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iGuestUserMedicalRecordController.Edit(obj);
        }

        public GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser)
        {
            return iGuestUserMedicalRecordController.GetGuestMedicalRecordByGuestUser(guestUser);
        }
    }
}