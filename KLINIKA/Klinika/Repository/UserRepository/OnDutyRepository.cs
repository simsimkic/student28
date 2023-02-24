using System;
using Klinika.Repository;
using Model.UserModel;
using System.Linq;

namespace Repository.UserRepository
{
    public class OnDutyRepository : IOnDutyRepository
    {
        private static OnDutyRepository instance { get; set; }
        private FileRepository<OnDuty> stream { get; set; }

        public static OnDutyRepository GetInstance(FileRepository<OnDuty> stream)
        {
            if (instance == null)
            {
                instance = new OnDutyRepository(stream);
            }
            return instance;
        }

        private OnDutyRepository(FileRepository<OnDuty> stream)
        {
            this.stream = stream;
        }

        public object Add(object obj)
        {
            var allOnDuty = stream.GetAll().ToList();
            allOnDuty.Add((OnDuty)obj);
            stream.SaveAll(allOnDuty);
            return obj;
        }

        public object Edit(object obj)
        {
            var allOnDutys = stream.GetAll().ToList();
            var editedOnDuty = (OnDuty)obj;
            foreach (OnDuty onDuty in allOnDutys)
            {
                EditOnDutyIfFound(onDuty, editedOnDuty);
            }
            stream.SaveAll(allOnDutys);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allOnDutys = stream.GetAll().ToList();
            if (allOnDutys.Remove((OnDuty)obj))
            {
                stream.SaveAll(allOnDutys);
                return true;
            }
            return false;
        }

        public void editAllOnDutyAttributes(OnDuty onDuty, OnDuty editedOnDuty)
        {
            onDuty.doctor= editedOnDuty.doctor;
            onDuty.startDate = editedOnDuty.startDate;
            onDuty.endDate = editedOnDuty.endDate;
            onDuty.startTime = editedOnDuty.startTime;
            onDuty.endTime = editedOnDuty.endTime;
        }

        private void EditOnDutyIfFound(OnDuty onDuty, OnDuty editedOnDuty)
        {
            if (editedOnDuty.doctor == onDuty.doctor)
            {
                editAllOnDutyAttributes(onDuty, editedOnDuty);
            }
        }
    }
}