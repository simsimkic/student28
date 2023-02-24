using Model.UserModel;
using System;

namespace Repository.UserRepository
{
    public interface IGuestUserRepository : IRepository
    {
        GuestUser GetGuestUser(int personalId);
    }
}