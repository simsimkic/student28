using Model.UserModel;
using Model.WorkTimeModel;
using System;

namespace Controller.WorkTimeController
{
    public interface IWorkTimeController
    {
        WorkTime EditWorkTime(WorkTime workTime);
        WorkTime AddWorkTime(WorkTime workTime);
    }
}