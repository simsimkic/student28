using Model.UserModel;
using Model.WorkTimeModel;
using Repository.WorkTimeRepository;
using Service.WorkTimeService;
using System;

namespace Service.WorkTimeService
{
    public class WorkTimeService : IWorkTimeService
    {
        private static WorkTimeService instance { get; set; }
        private WorkTimeRepository workTimeRepository { get; set; }

        public static WorkTimeService GetInstance(WorkTimeRepository workTimeRepository)
        {
            if (instance == null)
            {
                instance = new WorkTimeService(workTimeRepository);
            }
            return instance;
        }

        private WorkTimeService(WorkTimeRepository workTimeRepository)
        {
            this.workTimeRepository = workTimeRepository;
        }

        public WorkTime AddWorkTime(WorkTime workTime)
        {
            return workTimeRepository.AddWorkTime(workTime);
        }

        public WorkTime EditWorkTime(WorkTime workTime)
        {
            return workTimeRepository.EditWorkTime(workTime);
        }

        public bool DeletePreviousWorkTime()
        {
            return workTimeRepository.DeletePreviousWorkTime();
        }
    }
}