using System;

namespace Model.UserModel
{
    public class Feedback
    {
        public int grade { get; set; }

        public Feedback(int grade)
        {
            this.grade = grade;
        }
    }
}