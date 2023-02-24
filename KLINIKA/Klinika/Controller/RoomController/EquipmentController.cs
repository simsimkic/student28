using Model.RoomModel;
using Service.RoomService;
using System;

namespace Controller.RoomController
{
    public class EquipmentController : IEquipmentController
    {
        private static EquipmentController instance { get; set; }
        private EquipmentService equipmentService { get; set; }
        
        public static EquipmentController GetInstance(EquipmentService equipmentService)
        {
            if (instance == null)
            {
                instance = new EquipmentController(equipmentService);
            }
            return instance;
        }

        private EquipmentController(EquipmentService equipmentService)
        {
            this.equipmentService = equipmentService;
        }

        public Equipment AddEquipment(Equipment equipment)
        {
            return equipmentService.AddEquipment(equipment);
        }

        public Equipment EditEquipement(Equipment equipment)
        {
            return equipmentService.EditEquipement(equipment);
        }

        public void IncreaseEquipment(int equipmentId, int amount)
        {
            equipmentService.IncreaseEquipment(equipmentId, amount);
        }

        public void DecreaseEquipment(int equipmentId, int amount)
        {
            equipmentService.DecreaseEquipment(equipmentId, amount);
        }

        public int GetEquipmentAmountById(int equipmentId)
        {
            return equipmentService.GetEquipmentAmountById(equipmentId);
        }
    }
}