using Model.UserModel;
using System;

namespace Controller.UserController
{
    public class FeedBackDecorator : IFeedBackController
    {
        private IFeedBackController iFeedBackController { get; set; }
        private User user { get; set; }

        public FeedBackDecorator(IFeedBackController iFeedBackController, User user)
        {
            this.iFeedBackController = iFeedBackController;
            this.user = user;
        }

        public Feedback AddFeedBack(int grade)
        {
            return iFeedBackController.AddFeedBack(grade);
        }
    }
}