using Model.UserModel;
using System;
using Repository.UserRepository;

namespace Service.UserService
{
    public class FeedbackService : IFeedbackService
    {
        private static FeedbackService instance { get; set; }
        private FeedbackRepository feedbackRepository { get; set; }

        public static FeedbackService GetInstance(FeedbackRepository feedbackRepository)
        {
            if(instance == null)
            {
                instance = new FeedbackService(feedbackRepository);
            }
            return instance;
        }

        private FeedbackService(FeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public Feedback AddFeedback(int grade)
        {
            return feedbackRepository.AddFeedback(grade);
        }
    }
}