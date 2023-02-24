using Klinika.Repository;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.UserRepository
{
    public class PatientRepository : IPatientRepository
    {
        private static PatientRepository instance { get; set; }
        private FileRepository<Patient> stream { get; set; }

        public static PatientRepository GetInstance(FileRepository<Patient> stream)
        {
            if(instance == null)
            {
                instance = new PatientRepository(stream);
            }
            return instance;
        }

        private PatientRepository(FileRepository<Patient> stream)
        {
            this.stream = stream;
        }

        public Patient GetPatientByUsername(string username)
        {
            foreach(Patient patient in stream.GetAll().ToList())
            {
                if(patient.username == username)
                {
                    return patient;
                }
            }
            return null;
        }

        public List<Patient> GetAllPatients()
        {
            return stream.GetAll().ToList(); ;
        }

        public Patient RegisterGuestUser(Patient patient)
        {
            var allPatients = stream.GetAll().ToList();
            allPatients.Add(patient);
            stream.SaveAll(allPatients);
            return patient;
        }

        public object Add(object obj)
        {
            var allPatients = stream.GetAll().ToList();
            allPatients.Add((Patient)obj);
            stream.SaveAll(allPatients);
            return obj;
        }

        public object Edit(object obj)
        {
            var allPatients = stream.GetAll().ToList();
            var editedPatient = (Patient)obj;
            foreach (Patient patient in allPatients)
            {
                editAllPatientsAttributes(patient, editedPatient);
            }
            stream.SaveAll(allPatients);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allPatients = stream.GetAll().ToList();
            if (allPatients.Remove((Patient)obj))
            {
                stream.SaveAll(allPatients);
                return true;
            }
            return false;
        }

        public void editAllPatientsAttributes(Patient patient, Patient editedPatient)
        {
            patient.medicalRecord = editedPatient.medicalRecord;
            patient.adress = editedPatient.adress;
            patient.feedback = editedPatient.feedback;
            patient.name = editedPatient.name;
            patient.surname = editedPatient.surname;
            patient.personalId = editedPatient.personalId;
            patient.dateOfBirth = editedPatient.dateOfBirth;
            patient.gender = editedPatient.gender;
            patient.martialStatus = editedPatient.martialStatus;
            patient.username = editedPatient.username;
            patient.password = editedPatient.password;
            patient.email = editedPatient.email;
            patient.phoneNumber = editedPatient.phoneNumber;
            patient.appGraded = editedPatient.appGraded;
            patient.userLogged = editedPatient.userLogged;
        }

        private void EditDirectorIfFound(Patient patient, Patient editedPatient)
        {
            if (editedPatient.personalId == patient.personalId)
            {
                editAllPatientsAttributes(patient, editedPatient);
            }
        }
    }
}