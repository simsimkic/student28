using Model.ExaminationModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public interface IGuestUserMedicalRecordService : IService
    {
        Examination AddExaminationToGuestUserMedicalRecord(Examination examination, GuestUserMedicalRecord guestMedicalRecord);
        GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser);
    }
}