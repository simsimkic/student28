using Model.UserModel;
using Service.UserService;
using System;

namespace Controller.UserController
{
    public class GuestUserMedicalRecordController : IGuestUserMedicalRecordController
    {
        private static GuestUserMedicalRecordController instance { get; set; }
        private GuestUserMedicalRecordService guestUserMedicalRecordService { get; set; }

        public static GuestUserMedicalRecordController GetInstance(GuestUserMedicalRecordService guestUserMedicalRecordService)
        {
            if (instance == null)
            {
                instance = new GuestUserMedicalRecordController(guestUserMedicalRecordService);
            }
            return instance;
        }

        private GuestUserMedicalRecordController(GuestUserMedicalRecordService guestUserMedicalRecordService)
        {
            this.guestUserMedicalRecordService = guestUserMedicalRecordService;
        }

        public GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser)
        {
            return guestUserMedicalRecordService.GetGuestMedicalRecordByGuestUser(guestUser);
        }

        public object Add(object obj)
        {
            return guestUserMedicalRecordService.Add(obj);
        }

        public object Edit(object obj)
        {
            return guestUserMedicalRecordService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return guestUserMedicalRecordService.Delete(obj);
        }

    }
}