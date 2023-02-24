using System;

namespace Model.ExaminationModel
{
    public class Symptom
    {
        public String symptomName { get; set; }

        public Symptom(string symptomName)
        {
            this.symptomName = symptomName;
        }
    }
}