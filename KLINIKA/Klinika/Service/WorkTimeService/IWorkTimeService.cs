using Model.UserModel;
using Model.WorkTimeModel;
using System;

namespace Service.WorkTimeService
{
    public interface IWorkTimeService
    {
        WorkTime AddWorkTime(WorkTime workTime);
        WorkTime EditWorkTime(WorkTime workTime);
        Boolean DeletePreviousWorkTime();
    }
}