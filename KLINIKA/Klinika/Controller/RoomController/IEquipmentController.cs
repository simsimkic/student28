using Model.RoomModel;
using System;

namespace Controller.RoomController
{
    public interface IEquipmentController
    {
        Equipment AddEquipment(Equipment equipment);
        Equipment EditEquipement(Equipment equipment);
        void IncreaseEquipment(int equipmentId, int amount);
        void DecreaseEquipment(int equipmentId, int amount);
        int GetEquipmentAmountById(int equipmentId);
    }
}