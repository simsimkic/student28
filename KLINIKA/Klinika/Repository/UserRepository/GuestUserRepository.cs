using Klinika.Repository;
using Model.UserModel;
using System;
using System.Linq;

namespace Repository.UserRepository
{
    public class GuestUserRepository : IGuestUserRepository
    {
        private static GuestUserRepository instance { get; set; }
        private FileRepository<GuestUser> stream { get; set; }

        public static GuestUserRepository GetInstance(FileRepository<GuestUser> stream)
        {
            if (instance == null)
            {
                instance = new GuestUserRepository(stream);
            }
            return instance;
        }

        private GuestUserRepository(FileRepository<GuestUser> stream)
        {
            this.stream = stream;
        }

        public GuestUser GetGuestUser(int personalId)
        {
            foreach(GuestUser guestUser in stream.GetAll().ToList())
            {
                if(guestUser.personalId == personalId)
                {
                    return guestUser;
                }
            }
            return null;
        }
        
        public object Add(object obj)
        {
            var allGuestUsers = stream.GetAll().ToList();
            allGuestUsers.Add((GuestUser)obj);
            stream.SaveAll(allGuestUsers);
            return obj;
        }

        public object Edit(object obj)
        {
            var allGuestUsers = stream.GetAll().ToList();
            var editedGuestUser = (GuestUser)obj;
            foreach (GuestUser guestUser in allGuestUsers)
            {
                if (editedGuestUser.personalId == guestUser.personalId)
                {
                    editAllGuestUserAttributes(guestUser, editedGuestUser);
                }
            }
            stream.SaveAll(allGuestUsers);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allGuestUsers = stream.GetAll().ToList();
            if (allGuestUsers.Remove((GuestUser)obj))
            {
                stream.SaveAll(allGuestUsers);
                return true;
            }
            return false;
        }

        public void editAllGuestUserAttributes(GuestUser guestUser, GuestUser editedGuestUser)
        {
            guestUser.name = editedGuestUser.name;
            guestUser.surname = editedGuestUser.surname;
            guestUser.personalId = editedGuestUser.personalId;
        }
    }
}