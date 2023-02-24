using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class ExaminationDecorator : IExaminationController
    {
        private IExaminationController iExaminationController { get; set; }
        private User user { get; set; }

        public ExaminationDecorator(IExaminationController iExaminationController, User user)
        {
            this.iExaminationController = iExaminationController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iExaminationController.Add(obj);
        }

        public bool ApproveExamination(Examination examination)
        {
            return iExaminationController.ApproveExamination(examination);
        }

        public object Delete(object obj)
        {
            return iExaminationController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iExaminationController.Edit(obj);
        }

        public Examination GetExaminationByAppointment(Appointment appointment)
        {
            return iExaminationController.GetExaminationByAppointment(appointment);
        }

        public Examination GetExaminationByDoctor(Doctor doctor)
        {
            return iExaminationController.GetExaminationByDoctor(doctor);
        }

        public Examination GetExaminationById(int examinationId)
        {
            return iExaminationController.GetExaminationById(examinationId);
        }

        public Examination GetExaminationByPatient(Patient patient)
        {
            return iExaminationController.GetExaminationByPatient(patient);
        }

        public List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate)
        {
            return iExaminationController.GetPatientExaminationsByDate(patient, startDate, endDate);
        }

        public ExaminationType GetExaminationTypeById(int examinationId)
        {
            return iExaminationController.GetExaminationTypeById(examinationId);
        }

        public List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType)
        {
            return iExaminationController.GetDoctorsByExaminationType(examinationType);
        }

        public List<Examination> GetPreviousPatientExaminations(Patient patient)
        {
            return iExaminationController.GetPreviousPatientExaminations(patient);
        }

        public Examination ChangeExaminationAppointment(Examination examination, Appointment appointment)
        {
            return iExaminationController.ChangeExaminationAppointment(examination, appointment);
        }
    }
}