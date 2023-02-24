using System;
using System.Collections.Generic;
using Model.UserModel;
using Model.WorkTimeModel;

namespace Model.ExaminationModel
{
    public class Examination
    {
        public String patientSymptoms { get; set; }
        public Diagnosis diagnosis { get; set; }
        public List<Prescription> prescription { get; set; }
        public Appointment appointment { get; set; }
        public GuestUser guestUser { get; set; }
        public Doctor doctor { get; set; }
        public Patient patient { get; set; }
        public int examinationId { get; set; }
        public ExaminationType examinationType { get; set; }
        public Boolean guest { get; set; }
        public Boolean approved { get; set; }

        public Examination(Diagnosis diagnosis, List<Prescription> prescription, Appointment appointment, GuestUser guestUser, Doctor doctor, Patient patient, int examinationId, ExaminationType examinationType, bool guest, String patientSymptoms, Boolean approved)
        {
            this.diagnosis = diagnosis;
            this.prescription = prescription;
            this.appointment = appointment;
            this.guestUser = guestUser;
            this.doctor = doctor;
            this.patient = patient;
            this.examinationId = examinationId;
            this.examinationType = examinationType;
            this.guest = guest;
            this.patientSymptoms = patientSymptoms;
            this.approved = approved;
        }
    }
}