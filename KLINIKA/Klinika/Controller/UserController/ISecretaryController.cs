using System;
using System.Collections.Generic;
using Model.UserModel;
using Model.WorkTimeModel;

namespace Controller.UserController
{
    public interface ISecretaryController : IUserController
    {
        Secretary GetSecretaryById(int id);
        Secretary RegisterSecretary(Secretary secretary);
        bool DeleteSecretary(Secretary secretary);
        List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary);
    }
}