using System;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IUserController
    {
        User EditUser(User user);
        Boolean ChangePassword(User user);
        User LogIn(String username, String password);
        Boolean LogOut();
    }
}