using Model.UserModel;
using System;
using Service.UserService;

namespace Controller.UserController
{
    public class FeedBackController : IFeedBackController
    {
        private static FeedBackController instance { get; set; }
        private FeedbackService feedbackService { get; set; }

        public static FeedBackController GetInstance(FeedbackService feedbackService)
        {
            if(instance == null)
            {
                instance = new FeedBackController(feedbackService);
            }
            return instance;
        }

        private FeedBackController(FeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }

        public Feedback AddFeedBack(int grade)
        {
            return feedbackService.AddFeedback(grade);
        }
    }
}