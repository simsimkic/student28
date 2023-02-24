using System;
using System.Collections;
using System.Collections.Generic;

namespace Model.ExaminationModel
{
    public class Diagnosis
    {
        public List<Symptom> symptoms { get; set; }
        public String description { get; set; }

        public Diagnosis(List<Symptom> symptoms, string description)
        {
            this.symptoms = symptoms;
            this.description = description;
        }
    }
}