using System;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IGuestUserMedicalRecordController : IController
    {
        GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser);
    }
}