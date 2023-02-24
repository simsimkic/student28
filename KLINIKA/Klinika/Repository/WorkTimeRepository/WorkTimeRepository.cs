using Klinika.Repository;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.WorkTimeRepository
{
    public class WorkTimeRepository : IWorkTimeRepository
    {
        private static WorkTimeRepository instance { get; set; }
        private FileRepository<WorkTime> stream { get; set; }

        public static WorkTimeRepository GetInstance(FileRepository<WorkTime> stream)
        {
            if (instance == null)
            {
                instance = new WorkTimeRepository(stream);
            }
            return instance;
        }

        private WorkTimeRepository(FileRepository<WorkTime> stream)
        {
            this.stream = stream;
        }

        public WorkTime AddWorkTime(WorkTime workTime)
        {
            var allWorkTimes = stream.GetAll().ToList();
            allWorkTimes.Add(workTime);
            stream.SaveAll(allWorkTimes);
            return workTime;
        }

        public WorkTime EditWorkTime(WorkTime editedWorkTime)
        {
            var allWorkTimes = stream.GetAll().ToList();
            foreach (WorkTime workTime in allWorkTimes)
            {
                if (workTime.workTimeId == editedWorkTime.workTimeId)
                {
                    EditAllWorkTimeAttributes(workTime, editedWorkTime);
                }
            }
            stream.SaveAll(allWorkTimes);
            return editedWorkTime;
        }

        public bool DeletePreviousWorkTime()
        {
            var allWorkTimes = stream.GetAll().ToList();
            foreach (WorkTime workTime in allWorkTimes)
            {
                if (workTime.endDate >= DateTime.Today)
                {
                    allWorkTimes.Remove(workTime);
                    return true;
                }
            }
            return false;
        }

        private void EditAllWorkTimeAttributes(WorkTime workTime, WorkTime editedWorkTime)
        {
            workTime.user = editedWorkTime.user;
            workTime.appointment = editedWorkTime.appointment;
            workTime.room = editedWorkTime.room;
            workTime.startDate = editedWorkTime.startDate;
            workTime.startTime = editedWorkTime.startTime;
            workTime.endDate = editedWorkTime.endDate;
            workTime.endTime = editedWorkTime.endTime;
        }
    }
}