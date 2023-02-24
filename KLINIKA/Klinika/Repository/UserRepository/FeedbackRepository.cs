using Model.UserModel;
using System;
using Klinika.Repository;
using System.Linq;

namespace Repository.UserRepository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private static FeedbackRepository instance { get; set; }
        private FileRepository<Feedback> stream { get; set; }

        public static FeedbackRepository GetInstance(FileRepository<Feedback> stream)
        {
            if(instance == null)
            {
                instance = new FeedbackRepository(stream);
            }
            return instance;
        }

        private FeedbackRepository(FileRepository<Feedback> stream)
        {
            this.stream = stream;
        }

        public Feedback AddFeedback(int grade)
        {
            var allFeedback = stream.GetAll().ToList();
            var feedback = new Feedback(grade);
            allFeedback.Add(new Feedback(grade));
            stream.SaveAll(allFeedback);
            return feedback;
        }
    }
}