using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public interface ISecretaryService : IUserService
    {
        Secretary GetSecretaryById(int id);
        Secretary RegisterSecretary(Secretary secretary);
        bool DeleteSecretary(Secretary secretary);
        List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary);
    }
}