using Klinika.Repository;
using Model.ExaminationModel;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.UserRepository
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {
        private static MedicalRecordRepository instance { get; set; }
        private FileRepository<MedicalRecord> stream { get; set; }

        public static MedicalRecordRepository GetInstance(FileRepository<MedicalRecord> stream)
        {
            if (instance == null)
            {
                instance = new MedicalRecordRepository(stream);
            }
            return instance;
        }

        private MedicalRecordRepository(FileRepository<MedicalRecord> stream)
        {
            this.stream = stream;
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            foreach(MedicalRecord medicalRecord in stream.GetAll().ToList())
            {
                if(patient.medicalRecord == medicalRecord)
                {
                    return medicalRecord;
                }
            }
            return null;
        }

        public object Add(object obj)
        {
            var allMedicalRecords = stream.GetAll().ToList();
            allMedicalRecords.Add((MedicalRecord)obj);
            stream.SaveAll(allMedicalRecords);
            return obj;
        }

        public object Edit(object obj)
        {
            var allMedicalRecords = stream.GetAll().ToList();
            var editedMedicalRecord = (MedicalRecord)obj;
            foreach (MedicalRecord medicalRecord in allMedicalRecords)
            {
                if (editedMedicalRecord.id == medicalRecord.id)
                {
                    editAllMedicalRecordAttributes(medicalRecord, editedMedicalRecord);
                }
            }
            stream.SaveAll(allMedicalRecords);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allMedicalRecords = stream.GetAll().ToList();
            if (allMedicalRecords.Remove((MedicalRecord)obj))
            {
                stream.SaveAll(allMedicalRecords);
                return true;
            }
            return false;

        }

        public void editAllMedicalRecordAttributes(MedicalRecord medicalRecord, MedicalRecord editedMedicalRecord)
        {
            medicalRecord.examination = editedMedicalRecord.examination;
            medicalRecord.bloodType = editedMedicalRecord.bloodType;
            medicalRecord.height = editedMedicalRecord.height;
            medicalRecord.weight = editedMedicalRecord.weight;
            medicalRecord.alergies = editedMedicalRecord.alergies;
            medicalRecord.id = editedMedicalRecord.id;
        }

        public Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord)
        {
            var allMedicalRecords = stream.GetAll().ToList();
            foreach (MedicalRecord medRec in allMedicalRecords)
            {
                if (medRec.id == medicalRecord.id)
                {
                    medRec.examination.Add(examination);
                }
            }
            stream.SaveAll(allMedicalRecords);
            return examination;
        }

    }
}