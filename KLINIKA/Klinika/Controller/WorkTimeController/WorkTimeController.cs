using Model.UserModel;
using Model.WorkTimeModel;
using Service.WorkTimeService;
using System;

namespace Controller.WorkTimeController
{
    public class WorkTimeController : IWorkTimeController
    {
        private static WorkTimeController instance { get; set; }
        private WorkTimeService workTimeService { get; set; }

        public static WorkTimeController GetInstance(WorkTimeService workTimeService)
        {
            if (instance == null)
            {
                instance = new WorkTimeController(workTimeService);
            }
            return instance;
        }

        private WorkTimeController(WorkTimeService workTimeService)
        {
            this.workTimeService = workTimeService;
        }

        public WorkTime EditWorkTime(WorkTime workTime)
        {
            return workTimeService.EditWorkTime(workTime);
        }

        public WorkTime AddWorkTime(WorkTime workTime)
        {
            return workTimeService.AddWorkTime(workTime);
        }
    }
}