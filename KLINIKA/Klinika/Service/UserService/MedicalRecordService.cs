using Model.ExaminationModel;
using Model.UserModel;
using Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private static MedicalRecordService instance { get; set; }
        private MedicalRecordRepository medicalRecordRepository { get; set; }

        public static MedicalRecordService GetInstance(MedicalRecordRepository medicalRecordRepository)
        {
            if (instance == null)
            {
                instance = new MedicalRecordService(medicalRecordRepository);
            }
            return instance;
        }

        private MedicalRecordService(MedicalRecordRepository medicalRecordRepository)
        {
            this.medicalRecordRepository = medicalRecordRepository;
        }

        public Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord)
        {
            return medicalRecordRepository.AddExaminationToMedicalRecord(examination, medicalRecord);
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            return medicalRecordRepository.GetMedicalRecordByPatient(patient);
        }

        public object Add(object obj)
        {
            return medicalRecordRepository.Add((MedicalRecord)obj);
        }

        public object Edit(object obj)
        {
            return medicalRecordRepository.Edit((MedicalRecord)obj);
        }

        public object Delete(object obj)
        {
            return medicalRecordRepository.Delete((MedicalRecord)obj);
        }

        public List<Examination> GetExaminationsByDate(DateTime startDate, DateTime endTime, MedicalRecord medicalRecord)
        {
            List<Examination> examinations = new List<Examination>();
            foreach(Examination examination in medicalRecord.examination)
            {
                if(examination.appointment.date.date > startDate && examination.appointment.date.date < endTime)
                {
                    examinations.Add(examination);
                }
            }
            return examinations;
        }
    }
}