using Klinika.Repository;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.UserRepository
{
    public class SecretaryRepository : ISecretaryRepository
    {
        private static SecretaryRepository instance { get; set; }
        private FileRepository<Secretary> stream { get; set; }

        public static SecretaryRepository GetInstance(FileRepository<Secretary> stream)
        {
            if (instance == null)
            {
                instance = new SecretaryRepository(stream);
            }
            return instance;
        }

        private SecretaryRepository(FileRepository<Secretary> stream)
        {
            this.stream = stream;
        }

        public Secretary GetSecretaryById(int employeeId)
        {
            foreach(Secretary secretary in stream.GetAll().ToList())
            {
                if(secretary.personalId == employeeId)
                {
                    return secretary;
                }
            }
            return null;
        }

        public object Add(object obj)
        {
            var allSecretaries = stream.GetAll().ToList();
            allSecretaries.Add((Secretary)obj);
            stream.SaveAll(allSecretaries);
            return obj;
        }

        public object Edit(object obj)
        {
            var allSecretaries = stream.GetAll().ToList();
            var editedSecretary = (Secretary)obj;
            foreach (Secretary secretary in allSecretaries)
            {
                EditSecretaryIfFound(secretary, editedSecretary);
            }
            stream.SaveAll(allSecretaries);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allSecretaries = stream.GetAll().ToList();
            if (allSecretaries.Remove((Secretary)obj))
            {
                stream.SaveAll(allSecretaries);
                return true;
            }
            return false;
        }

        public List<Secretary> GetAll()
        {
            return stream.GetAll().ToList();
        }

        public List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary)
        {
            List<WorkTime> workTimesBySecretary = new List<WorkTime>();
            foreach (Secretary secretaryIterable in stream.GetAll().ToList())
            {
                if (secretaryIterable.Equals(secretary))
                {
                    foreach(WorkTime workTime in secretary.workTime)
                    {
                        if(DateTime.Compare(startDate,workTime.startDate)<=0 && DateTime.Compare(endDate,workTime.endDate)>=0)
                        {
                            workTimesBySecretary.Add(workTime);
                        }
                    }
                }
            }
            return workTimesBySecretary;
        }

        public void editAllPatientsAttributes(Secretary secretary, Secretary editedSecretary)
        {
            secretary.daysOff = editedSecretary.daysOff;
            secretary.workTime = editedSecretary.workTime;
            secretary.adress = editedSecretary.adress;
            secretary.feedback = editedSecretary.feedback;
            secretary.name = editedSecretary.name;
            secretary.surname = editedSecretary.surname;
            secretary.personalId = editedSecretary.personalId;
            secretary.dateOfBirth = editedSecretary.dateOfBirth;
            secretary.gender = editedSecretary.gender;
            secretary.martialStatus = editedSecretary.martialStatus;
            secretary.username = editedSecretary.username;
            secretary.password = editedSecretary.password;
            secretary.email = editedSecretary.email;
            secretary.phoneNumber = editedSecretary.phoneNumber;
            secretary.appGraded = editedSecretary.appGraded;
            secretary.userLogged = editedSecretary.userLogged;
        }

        private void EditSecretaryIfFound(Secretary secretary, Secretary editedSecretary)
        {
            if (editedSecretary.personalId == secretary.personalId)
            {
                editAllPatientsAttributes(secretary, editedSecretary);
            }
        }
    }
}