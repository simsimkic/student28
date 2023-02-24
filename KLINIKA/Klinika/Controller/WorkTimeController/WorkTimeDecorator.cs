using Model.UserModel;
using Model.WorkTimeModel;
using System;

namespace Controller.WorkTimeController
{
    public class WorkTimeDecorator : IWorkTimeController
    {
        private IWorkTimeController iWorkTimeController { get; set; }
        private User user { get; set; }

        public WorkTimeDecorator(IWorkTimeController iWorkTimeController, User user)
        {
            this.iWorkTimeController = iWorkTimeController;
            this.user = user;
        }

        public WorkTime AddWorkTime(WorkTime workTime)
        {
            return iWorkTimeController.AddWorkTime(workTime);
        }

        public WorkTime EditWorkTime(WorkTime workTime)
        {
            return iWorkTimeController.EditWorkTime(workTime);
        }
    }
}