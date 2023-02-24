using Model.ExaminationModel;
using Model.UserModel;
using Repository.UserRepository;
using System;

namespace Service.UserService
{
    public class GuestUserMedicalRecordService : IGuestUserMedicalRecordService
    {
        private static GuestUserMedicalRecordService instance { get; set; }
        private GuestUserMedicalRecordRepository guestUserMedicalRecordRepository { get; set; }

        public static GuestUserMedicalRecordService GetInstance(GuestUserMedicalRecordRepository guestUserMedicalRecordRepository)
        {
            if (instance == null)
            {
                instance = new GuestUserMedicalRecordService(guestUserMedicalRecordRepository);
            }
            return instance;
        }

        private GuestUserMedicalRecordService(GuestUserMedicalRecordRepository guestUserMedicalRecordRepository)
        {
            this.guestUserMedicalRecordRepository = guestUserMedicalRecordRepository;
        }

        public GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser)
        {
            return guestUserMedicalRecordRepository.GetGuestMedicalRecordByGuestUser(guestUser);
        }

        public object Add(object obj)
        {
            return guestUserMedicalRecordRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return guestUserMedicalRecordRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return guestUserMedicalRecordRepository.Delete(obj);
        }

        public Examination AddExaminationToGuestUserMedicalRecord(Examination examination, GuestUserMedicalRecord guestMedicalRecord)
        {
            return guestUserMedicalRecordRepository.AddExaminationToGuestUserMedicalRecord(examination, guestMedicalRecord);
        }
    }
}