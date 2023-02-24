using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Repository.RoomRepository
{
    public interface IEquipmentRepository 
    {
        Equipment AddEquipment(Equipment equipment);
        Equipment EditEquipement(Equipment equipment);
        int GetEquipmentAmountById(int equipmentId);
        List<Equipment> GetAllEquipment();
        Equipment getEquipmentById(int equipmentId);
    }
}