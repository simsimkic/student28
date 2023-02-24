using Model.UserModel;
using System;
using Service.UserService;

namespace Controller.UserController
{
    public class DirectorController : IDirectorController
    {
        private static DirectorController instance { get; set; }
        private DirectorService directorService { get; set; }

        public static DirectorController GetInstance(DirectorService directorService)
        {
            if(instance == null)
            {
                instance = new DirectorController(directorService);
            }
            return instance;
        }

        private DirectorController(DirectorService directorService)
        {
            this.directorService = directorService;
        }

        public User EditUser(User user)
        {
            return directorService.EditUser(user);
        }

        public bool ChangePassword(User user)
        {
            return directorService.ChangePassword(user);
        }

        public User LogIn(string username, string password)
        {
            return directorService.LogIn(username,password);
        }

        public bool LogOut()
        {
            return directorService.LogOut();
        }
    }
}