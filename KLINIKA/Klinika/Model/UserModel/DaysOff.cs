using System;

namespace Model.UserModel
{
    public class DaysOff
    {
        public int daysLeft { get; set; }

        public DaysOff(int daysLeft)
        {
            this.daysLeft = daysLeft;
        }
    }
}