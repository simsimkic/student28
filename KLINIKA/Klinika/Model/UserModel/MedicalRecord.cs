using System;
using System.Collections.Generic;
using Model.ExaminationModel;

namespace Model.UserModel
{
    public class MedicalRecord
    {
        public List <Examination>  examination { get; set; }
        public String bloodType { get; set; }
        public Double height { get; set; }
        public Double weight { get; set; }
        public String alergies { get; set; }
        public int id { get; set; }

        public MedicalRecord(List<Examination> examination, string bloodType, double height, double weight, string alergies, int id)
        {
            this.examination = examination;
            this.bloodType = bloodType;
            this.height = height;
            this.weight = weight;
            this.alergies = alergies;
            this.id = id;
        }
    }
}