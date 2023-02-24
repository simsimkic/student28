using System;
using Model.UserModel;

namespace Service.UserService
{
    public interface IGuestUserService : IService
    {
        GuestUser GetGuestUser(int personalId);
    }
}