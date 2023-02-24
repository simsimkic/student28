using Model.UserModel;
using Repository.UserRepository;
using System;

namespace Service.UserService
{
    public class GuestUserService : IGuestUserService
    {
        private static GuestUserService instance { get; set; }
        private GuestUserRepository guestUserRepository { get; set; }

        public static GuestUserService GetInstance(GuestUserRepository guestUserRepository)
        {
            if (instance == null)
            {
                instance = new GuestUserService(guestUserRepository);
            }
            return instance;
        }

        private GuestUserService(GuestUserRepository guestUserRepository)
        {
            this.guestUserRepository = guestUserRepository;
        }

        public GuestUser GetGuestUser(int personalId)
        {
            return guestUserRepository.GetGuestUser(personalId);
        }

        public object Add(object obj)
        {
            return guestUserRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return guestUserRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return guestUserRepository.Delete(obj);
        }
    }
}