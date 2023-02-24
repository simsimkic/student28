using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using Repository.ExaminationRepository;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public class ExaminationService : IExaminationService
    {
        private static ExaminationService instance { get; set; }
        private ExaminationRepository examinationRepository { get; set; }

        public static ExaminationService GetInstance(ExaminationRepository examinationRepository)
        {
            if (instance == null)
            {
                instance = new ExaminationService(examinationRepository);
            }
            return instance;
        }

        private ExaminationService(ExaminationRepository examinationRepository)
        {
            this.examinationRepository = examinationRepository;
        }

        public Examination GetExaminationByAppointment(Appointment appointment)
        {
            return examinationRepository.GetExaminationByAppointment(appointment);
        }

        public Examination GetExaminationByPatient(Patient patient)
        {
            return examinationRepository.GetExaminationByPatient(patient);
        }

        public Examination GetExaminationByDoctor(Doctor doctor)
        {
            return examinationRepository.GetExaminationByDoctor(doctor);
        }

        public List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate)
        {
            return examinationRepository.GetPatientExaminationsByDate(patient, startDate, endDate);
        }

        public bool ApproveExamination(Examination examination)
        {
            examination.approved = true;
            examinationRepository.Edit(examination);
            return true;
        }

        public Examination GetExaminationById(int examinationId)
        {
            return examinationRepository.GetExaminationById(examinationId);
        }

        public ExaminationType GetExaminationTypeById(int examinationId)
        {
            return examinationRepository.GetExaminationTypeById(examinationId);
        }

        public List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType)
        {
            return examinationRepository.GetDoctorsByExaminationType(examinationType);
        }

        public List<Examination> GetPreviousPatientExaminations(Patient patient)
        {
            return examinationRepository.GetPreviousPatientExaminations(patient);
        }

        public Examination ChangeExaminationAppointment(Examination examination, Appointment appointment)
        {
            examination.appointment = appointment;
            return (Examination)examinationRepository.Edit(examination);
        }

        public object Add(object obj)
        {
            Examination examination = (Examination)obj;
            SetGuestInExamination(examination);
            return examinationRepository.Add(examination);
        }

        public object Edit(object obj)
        {
            return examinationRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return examinationRepository.Delete(obj);
        }

        private void SetGuestInExamination(Examination examination)
        {
            if (examination.guestUser != null)
            {
                examination.guest = true;
            }
            else
            {
                examination.guest = false;
            }
        }
    }
}