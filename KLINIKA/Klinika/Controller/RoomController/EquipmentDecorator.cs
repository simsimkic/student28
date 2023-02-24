using Model.RoomModel;
using Model.UserModel;
using System;

namespace Controller.RoomController
{
    public class EquipmentDecorator : IEquipmentController
    {
        private IEquipmentController iEquipmentController { get; set; }
        private User user { get; set; }

        public EquipmentDecorator(IEquipmentController iEquipmentController, User user)
        {
            this.iEquipmentController = iEquipmentController;
            this.user = user;
        }

        public Equipment AddEquipment(Equipment equipment)
        {
            return iEquipmentController.AddEquipment(equipment);
        }

        public Equipment EditEquipement(Equipment equipment)
        {
            return iEquipmentController.EditEquipement(equipment);
        }

        public int GetEquipmentAmountById(int equipmentId)
        {
            return iEquipmentController.GetEquipmentAmountById(equipmentId);
        }

        public void IncreaseEquipment(int equipmentId, int amount)
        {
            iEquipmentController.IncreaseEquipment(equipmentId, amount);
        }

        public void DecreaseEquipment(int equipmentId, int amount)
        {
            iEquipmentController.DecreaseEquipment(equipmentId, amount);
        }
    }
}