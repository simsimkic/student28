using Model.UserModel;
using System;
using System.Collections.Generic;
using Model.WorkTimeModel;

namespace Repository.UserRepository
{
    public interface ISecretaryRepository : IRepository
    {
        Secretary GetSecretaryById(int employeeId);
        List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary);
        List<Secretary> GetAll();
    }
}