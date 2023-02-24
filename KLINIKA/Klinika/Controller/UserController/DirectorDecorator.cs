using Model.UserModel;
using System;

namespace Controller.UserController
{
    public class DirectoryDecorator : IDirectorController
    {
        private IDirectorController iDirectoryController { get; set; }
        private User user { get; set; }

        public DirectoryDecorator(IDirectorController iDirectoryController, User user)
        {
            this.iDirectoryController = iDirectoryController;
            this.user = user;
        }

        public bool ChangePassword(User user)
        {
            return iDirectoryController.ChangePassword(user);
        }

        public User EditUser(User user)
        {
            return iDirectoryController.EditUser(user);
        }

        public User LogIn(string username, string password)
        {
            return iDirectoryController.LogIn(username, password);
        }

        public bool LogOut()
        {
            return iDirectoryController.LogOut();
        }
    }
}