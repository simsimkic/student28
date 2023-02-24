using System;

namespace Model.UserModel
{
    public class Article
    {
        public Doctor doctor { get; set; }
        public String title { get; set; }
        public String text { get; set; }
        public DateTime date { get; set; }

        public Article(Doctor doctor, String title, String text, DateTime date)
        {
            this.doctor = doctor;
            this.title = title;
            this.text = text;
            this.date = date;
        }

    }
}