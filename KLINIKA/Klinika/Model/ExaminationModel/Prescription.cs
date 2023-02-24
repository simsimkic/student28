using System;
using Model.DrugModel;

namespace Model.ExaminationModel
{
    public class Prescription
    {
        public Drug drug { get; set; }
        public Examination examination { get; set; }
        public String note { get; set; }

        public Prescription(Drug drug, Examination examination, string note)
        {
            this.drug = drug;
            this.examination = examination;
            this.note = note;
        }
    }
}