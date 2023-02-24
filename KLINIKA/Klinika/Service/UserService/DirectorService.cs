using System;
using Model.UserModel;
using Repository.UserRepository;
using System.Collections.Generic;

namespace Service.UserService
{
    public class DirectorService : IDirectorService
    {
        private static DirectorService instance { get; set; }
        private DirectorRepository directorRepository { get; set; }

        public static DirectorService GetInstance(DirectorRepository directoryRepository)
        {
            if(instance == null)
            {
                instance = new DirectorService(directoryRepository);
            }
            return null;
        }

        private DirectorService(DirectorRepository directoryRepository)
        {
            this.directorRepository = directoryRepository;
        }

        public User EditUser(User user)
        {
            return directorRepository.EditDirector((Director)user);
        }

        public bool ChangePassword(User user)
        {
            directorRepository.EditDirector((Director)user);
            return true;
        }

        public User LogIn(string username, string password)
        {
            List<Director> directors = directorRepository.getAllDirectors();
            foreach(Director director in directors)
            {
                if(director.username.Equals(username) && director.password.Equals(password))
                {
                    director.userLogged = true;
                    return director;
                }
            }
            return null;
        }

        public bool LogOut()
        {
            List<Director> directors = directorRepository.getAllDirectors();
            foreach (Director director in directors)
            {
                if (director.userLogged == true)
                {
                    director.userLogged = false;
                    return true;
                }
            }
            return false;
        }
    }
}