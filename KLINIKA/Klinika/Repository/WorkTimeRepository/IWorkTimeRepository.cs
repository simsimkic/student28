using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Repository.WorkTimeRepository
{
    public interface IWorkTimeRepository
    {
        WorkTime AddWorkTime(WorkTime workTime);
        WorkTime EditWorkTime(WorkTime workTime);
        bool DeletePreviousWorkTime();
    }
}