using System;
using Model.UserModel;

namespace Service.UserService
{
    public interface IFeedbackService
    {
        Feedback AddFeedback(int grade);
    }
}