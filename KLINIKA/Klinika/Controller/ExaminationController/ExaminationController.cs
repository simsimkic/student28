using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using Service.ExaminationService;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class ExaminationController : IExaminationController
    {
        private static ExaminationController instance { get; set; }
        private ExaminationService examinationService { get; set; }
       
        public static ExaminationController GetInstance(ExaminationService examinationService)
        {
            if (instance == null)
            {
                instance = new ExaminationController(examinationService);
            }
            return instance;
        }

        private ExaminationController(ExaminationService examinationService)
        {
            this.examinationService = examinationService;
        }

        public Examination GetExaminationByPatient(Patient patient)
        {
            return examinationService.GetExaminationByPatient(patient);
        }

        public Examination GetExaminationByDoctor(Doctor doctor)
        {
            return examinationService.GetExaminationByDoctor(doctor);
        }

        public List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate)
        {
            return examinationService.GetPatientExaminationsByDate(patient, startDate, endDate);
        }

        public bool ApproveExamination(Examination examination)
        {
            return examinationService.ApproveExamination(examination);
        }

        public Examination GetExaminationById(int examinationId)
        {
            return examinationService.GetExaminationById(examinationId);
        }

        public ExaminationType GetExaminationTypeById(int examinationId)
        {
            return examinationService.GetExaminationTypeById(examinationId);
        }

        public Examination GetExaminationByAppointment(Appointment appointment)
        {
            return examinationService.GetExaminationByAppointment(appointment);
        }

        public List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType)
        {
            return examinationService.GetDoctorsByExaminationType(examinationType);
        }

        public List<Examination> GetPreviousPatientExaminations(Patient patient)
        {
            return examinationService.GetPreviousPatientExaminations(patient);
        }

        public Examination ChangeExaminationAppointment(Examination examination, Appointment appointment)
        {
            return examinationService.ChangeExaminationAppointment(examination, appointment);
        }

        public object Add(object obj)
        {
            return examinationService.Add(obj);
        }

        public object Edit(object obj)
        {
            return examinationService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return examinationService.Delete(obj);
        }

    }
}