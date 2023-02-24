using System;
using Model.ExaminationModel;

namespace Model.UserModel
{
    public class GuestUserMedicalRecord
    {
        public Examination examination { get; set; }
        public int id { get; set; }

        public GuestUserMedicalRecord(Examination examination, int id)
        {
            this.examination = examination;
            this.id = id;
        }
    }
}