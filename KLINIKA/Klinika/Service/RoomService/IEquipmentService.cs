using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Service.RoomService
{
    public interface IEquipmentService
    {
        Equipment AddEquipment(Equipment equipment);
        Equipment EditEquipement(Equipment equipment);
        void DecreaseEquipment(int equipmentId, int amount);
        void IncreaseEquipment(int equipmentId, int amount);
        int GetEquipmentAmountById(int equipmentId);
        List<Equipment> GetAllEquipment();
    }
}