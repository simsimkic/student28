using System;
using Model.UserModel;

namespace Repository.UserRepository
{
    public interface IFeedbackRepository
    {
        Feedback AddFeedback(int grade);
    }
}