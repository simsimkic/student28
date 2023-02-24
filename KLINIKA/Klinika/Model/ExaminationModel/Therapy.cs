using System;

namespace Model.ExaminationModel
{
    public class Therapy
    {
        public Hospitalization hospitalization { get; set; }
        public String description { get; set; }

        public Therapy(Hospitalization hospitalization, string description)
        {
            this.hospitalization = hospitalization;
            this.description = description;
        }
    }
}