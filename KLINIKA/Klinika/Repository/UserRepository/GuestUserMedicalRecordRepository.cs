using Klinika.Repository;
using Model.ExaminationModel;
using Model.RoomModel;
using Model.UserModel;
using System;
using System.Linq;

namespace Repository.UserRepository
{
    public class GuestUserMedicalRecordRepository : IGuestUserMedicalRecordRepository
    {
        private static GuestUserMedicalRecordRepository instance { get; set; }
        private FileRepository<GuestUserMedicalRecord> stream { get; set; }

        public static GuestUserMedicalRecordRepository GetInstance(FileRepository<GuestUserMedicalRecord> stream)
        {
            if (instance == null)
            {
                instance = new GuestUserMedicalRecordRepository(stream);
            }
            return instance;
        }

        private GuestUserMedicalRecordRepository(FileRepository<GuestUserMedicalRecord> stream)
        {
            this.stream = stream;
        }

        public GuestUserMedicalRecord GetGuestMedicalRecordByGuestUser(GuestUser guestUser)
        {
            foreach(GuestUserMedicalRecord guestMedRec in stream.GetAll().ToList())
            {
                if(guestUser.guestUserMedicalRecord == guestMedRec)
                {
                    return guestMedRec;
                }
            }
            return null;
        }

        public object Add(object obj)
        {
            var allGuestUserMedicalRecords = stream.GetAll().ToList();
            allGuestUserMedicalRecords.Add((GuestUserMedicalRecord)obj);
            stream.SaveAll(allGuestUserMedicalRecords);
            return obj;
        }

        public object Edit(object obj)
        {
            var allGuestUserMedicalRecords = stream.GetAll().ToList();
            var editedGuestUserMedicalRecord = (GuestUserMedicalRecord)obj;
            foreach(GuestUserMedicalRecord guestUserMedicalRecord in allGuestUserMedicalRecords)
            {
                if(editedGuestUserMedicalRecord.examination == guestUserMedicalRecord.examination)
                {
                    editAllGuestUserMedicalRecordAttributes(guestUserMedicalRecord,editedGuestUserMedicalRecord);
                }
            }
            stream.SaveAll(allGuestUserMedicalRecords);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allGuestUserMedicalRecords = stream.GetAll().ToList();
            allGuestUserMedicalRecords.Remove((GuestUserMedicalRecord)obj);
            stream.SaveAll(allGuestUserMedicalRecords);
            return true;
        }

        public void editAllGuestUserMedicalRecordAttributes(GuestUserMedicalRecord guestUserMedicalRecord, GuestUserMedicalRecord editedGuestUserMedicalRecord)
        {
            guestUserMedicalRecord.examination = editedGuestUserMedicalRecord.examination;
        }

        public Examination AddExaminationToGuestUserMedicalRecord(Examination examination, GuestUserMedicalRecord guestMedicalRecord)
        {
            var allGuestUserMedicalRecords = stream.GetAll().ToList();
            foreach (GuestUserMedicalRecord guestUsermedRec in allGuestUserMedicalRecords)
            {
                if (guestUsermedRec.id == guestMedicalRecord.id)
                {
                    guestUsermedRec.examination = examination;
                }
            }
            stream.SaveAll(allGuestUserMedicalRecords);
            return examination;
        }
    }
}