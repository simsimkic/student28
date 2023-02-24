using Model.ExaminationModel;
using Model.UserModel;
using System;

namespace Repository.UserRepository
{
    public interface IGuestUserMedicalRecordRepository : IRepository
    {
        GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser);
        Examination AddExaminationToGuestUserMedicalRecord(Examination examination, GuestUserMedicalRecord guestMedicalRecord);
    }
}