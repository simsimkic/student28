using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class SecretaryDecorator : ISecretaryController
    {
        private ISecretaryController iSecretaryController;
        private User user;

        public SecretaryDecorator(ISecretaryController iSecretaryController, User user)
        {
            this.iSecretaryController = iSecretaryController;
            this.user = user;
        }

        public bool ChangePassword(User user)
        {
            return iSecretaryController.ChangePassword(user);
        }

        public User EditUser(User user)
        {
            return iSecretaryController.EditUser(user);
        }

        public bool DeleteSecretary(Secretary secretary)
        {
            return iSecretaryController.DeleteSecretary(secretary);
        }

        public Secretary GetSecretaryById(int id)
        {
            return iSecretaryController.GetSecretaryById(id);
        }

        public List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary)
        {
            return iSecretaryController.GetWorkTimesBySecretary(startDate, endDate, secretary);
        }

        public User LogIn(string username, string password)
        {
            return iSecretaryController.LogIn(username, password);
        }

        public bool LogOut()
        {
            return iSecretaryController.LogOut();
        }

        public Secretary RegisterSecretary(Secretary secretary)
        {
            return iSecretaryController.RegisterSecretary(secretary);
        }
    }
}