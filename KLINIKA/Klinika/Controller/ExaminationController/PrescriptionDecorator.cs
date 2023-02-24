using Model.ExaminationModel;
using System;
using Model.UserModel;

namespace Controller.ExaminationController
{
    public class PrescriptionDecorator : IPrescriptionController
    {
        private IPrescriptionController iPrescriptionController { get; set; }
        private User user { get; set; }

        public PrescriptionDecorator(IPrescriptionController iPrescriptionController, User user)
        {
            this.iPrescriptionController = iPrescriptionController;
            this.user = user;
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            return iPrescriptionController.AddPrescription(prescription);
        }
    }
}