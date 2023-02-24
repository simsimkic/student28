using Model.UserModel;
using Model.WorkTimeModel;
using Service.UserService;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class SecretaryController : ISecretaryController
    {
        private static SecretaryController instance { get; set; }
        private SecretaryService secretaryService { get; set; }

        public static SecretaryController GetInstance(SecretaryService secretaryService)
        {
            if (instance == null)
            {
                instance = new SecretaryController(secretaryService);
            }
            return instance;
        }

        private SecretaryController(SecretaryService secretaryService)
        {
            this.secretaryService = secretaryService;
        }

        public Secretary GetSecretaryById(int id)
        {
            return secretaryService.GetSecretaryById(id);
        }

        public Secretary RegisterSecretary(Secretary secretary)
        {
            return secretaryService.RegisterSecretary(secretary);
        }

        public User EditUser(User user)
        {
            return secretaryService.EditUser(user);
        }

        public bool DeleteSecretary(Secretary secretary)
        {
            return secretaryService.DeleteSecretary(secretary);
        }

        public bool ChangePassword(User user)
        {
            return secretaryService.ChangePassword(user);
        }

        public User LogIn(string username, string password)
        {
            return secretaryService.LogIn(username, password);
        }

        public bool LogOut()
        {
            return secretaryService.LogOut();
        }

        public List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary)
        {
            return secretaryService.GetWorkTimesBySecretary(startDate, endDate, secretary);
        }
    }
}