using Model.UserModel;
using System;

namespace Service.UserService
{
    public interface IUserService
    {
        User EditUser(User user);
        Boolean ChangePassword(User user);
        User LogIn(String username, String password);
        Boolean LogOut();
    }
}