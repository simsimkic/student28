using System;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IFeedBackController
    {
        Feedback AddFeedBack(int grade);
    }
}