using System;

namespace Model.UserModel
{
    public class Poll
    {
        public Array questions { get; set; }
        public Array answers { get; set; }

        public Poll(Array questions, Array answers)
        {
            this.questions = questions;
            this.answers = answers;
        }
    }
}