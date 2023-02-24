using Klinika.Repository;
using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class ExaminationRepository : IExaminationRepository
    {
        private static ExaminationRepository instance { get; set; }
        private FileRepository<Examination> stream { get; set; }

        public static ExaminationRepository GetInstance(FileRepository<Examination> stream)
        {
            if (instance == null)
            {
                instance = new ExaminationRepository(stream);
            }
            return instance;
        }

        private ExaminationRepository(FileRepository<Examination> stream)
        {
            this.stream = stream;
        }

        public Examination GetExaminationByAppointment(Appointment appointment)
        {
            foreach(Examination examination in stream.GetAll().ToList())
            {
                if(examination.appointment == appointment)
                {
                    return examination;
                }
            }
            return null;
        }

        public Examination GetExaminationByPatient(Patient patient)
        {
            foreach (Examination examination in stream.GetAll().ToList())
            {
                if (examination.patient.personalId == patient.personalId)
                {
                    return examination;
                }
            }
            return null;
        }
        public Examination GetExaminationByDoctor(Doctor doctor)
        {
            foreach (Examination examination in stream.GetAll().ToList())
            {
                if (examination.doctor.employeeId == doctor.employeeId)
                {
                    return examination;
                }
            }
            return null;
        }

        public Examination GetExaminationById(int examinationId)
        {
            foreach (Examination examination in stream.GetAll().ToList())
            {
                if (examination.examinationId == examinationId)
                {
                    return examination;
                }
            }
            return null;
        }

        public List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate)
        {
            List<Examination> examinations = new List<Examination>();
            foreach (Examination examination in stream.GetAll().ToList())
            {
                if (examination.appointment.date.startTime >= startDate && examination.appointment.date.endTime <= endDate && examination.patient == patient)
                {
                    examinations.Add(examination);
                }
            }
            return examinations;
        }

        public List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType)
        {
            var doctorsByExaminationType = new List<Doctor>();
            foreach(Examination examination in stream.GetAll().ToList())
            {
                if(examination.examinationType == examinationType)
                {
                    doctorsByExaminationType.Add(examination.doctor);
                }
            }
            return doctorsByExaminationType;
        }

        public List<Examination> GetPreviousPatientExaminations(Patient patient)
        {
            List<Examination> previousExaminations = new List<Examination>();
            foreach (Examination examination in stream.GetAll().ToList())
            {
                if (examination.patient.personalId == patient.personalId && examination.appointment.date.date < DateTime.Today)
                {
                    previousExaminations.Add(examination);
                }
            }
            return previousExaminations;
        }

        public ExaminationType GetExaminationTypeById(int examinationId)
        {
            foreach(Examination examination in stream.GetAll().ToList())
            {
                if(examination.examinationId == examinationId)
                {
                    return examination.examinationType;
                }
            }
            return 0;
        }

        public object Add(object obj)
        {
            var allExaminations = stream.GetAll().ToList();
            allExaminations.Add((Examination)obj);
            stream.SaveAll(allExaminations);
            return obj;
        }

        public object Edit(object obj)
        {
            var allExaminations = stream.GetAll().ToList();
            var editedExamination = (Examination)obj;
            foreach (Examination examination in allExaminations)
            {
                EditExaminationIfFound(examination, editedExamination);
            }
            stream.SaveAll(allExaminations);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allExaminations = stream.GetAll().ToList();
            if (allExaminations.Remove((Examination)obj))
            {
                stream.SaveAll(allExaminations);
                return true;
            }
            return false;
        }

        private void EditExaminationAttributes(Examination examination, Examination editedExamination)
        {
            examination.appointment = editedExamination.appointment;
            examination.diagnosis = editedExamination.diagnosis;
            examination.prescription = editedExamination.prescription;
        }

        private void EditExaminationIfFound(Examination examination, Examination editedExamination)
        {
            if (examination.examinationId == editedExamination.examinationId)
            {
                EditExaminationAttributes(examination, editedExamination);
            }
        }
    }
}