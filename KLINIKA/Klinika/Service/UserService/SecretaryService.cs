using Model.UserModel;
using Model.WorkTimeModel;
using Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public class SecretaryService : ISecretaryService
    {
        private static SecretaryService instance { get; set; }
        private SecretaryRepository secretaryRepository { get; set; }

        public static SecretaryService GetInstance(SecretaryRepository secretaryRepository)
        {
            if (instance == null)
            {
                instance = new SecretaryService(secretaryRepository);
            }
            return instance;
        }

        private SecretaryService(SecretaryRepository secretaryRepository)
        {
            this.secretaryRepository = secretaryRepository;
        }

        public Secretary GetSecretaryById(int id)
        {
            return ((ISecretaryService)instance).GetSecretaryById(id);
        }

        public Secretary RegisterSecretary(Secretary secretary)
        {
            return (Secretary)secretaryRepository.Add(secretary);
        }

        public bool DeleteSecretary(Secretary secretary)
        {
            return secretaryRepository.Delete(secretary);
        }

        public User EditUser(User user)
        {
            return (User)secretaryRepository.Edit(user);
        }

        public bool ChangePassword(User user)
        {
            secretaryRepository.Edit(user);
            return true;
        }

        public User LogIn(string username, string password)
        {
            foreach(Secretary secretary in secretaryRepository.GetAll())
            {
                if(secretary.username.Equals(username) && secretary.password.Equals(password))
                {
                    return SetUserLogged(secretary);    //return value is changed secretary
                }
            }
            return null;
        }

        public bool LogOut()
        {
            foreach (Secretary secretary in secretaryRepository.GetAll())
            {
                if(secretary.userLogged == true)
                {
                    return SetUserLoggedOff(secretary); //return true
                }
            }
            return false;
        }

        public List<WorkTime> GetWorkTimesBySecretary(DateTime startDate, DateTime endDate, Secretary secretary)
        {
            return secretaryRepository.GetWorkTimesBySecretary(startDate, endDate, secretary);
        }

        private Secretary SetUserLogged(Secretary secretary)
        {
            secretary.userLogged = true;
            secretaryRepository.Edit(secretary);
            return secretary;
        }

        private bool SetUserLoggedOff(Secretary secretary)
        {
            secretary.userLogged = false;
            secretaryRepository.Edit(secretary);
            return true;
        }
    }
}