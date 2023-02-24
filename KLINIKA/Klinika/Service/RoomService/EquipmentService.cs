using Model.RoomModel;
using Repository.RoomRepository;
using System;
using System.Collections.Generic;

namespace Service.RoomService
{
    public class EquipmentService : IEquipmentService
    {
        private static EquipmentService instance { get; set; }
        private EquipmentRepository equipmentRepository { get; set; }

        public static EquipmentService GetInstance(EquipmentRepository equipmentRepository)
        {
            if (instance == null)
            {
                instance = new EquipmentService(equipmentRepository);
            }
            return instance;
        }

        private EquipmentService(EquipmentRepository equipmentRepository)
        {
            this.equipmentRepository = equipmentRepository;
        }

        public Equipment AddEquipment(Equipment equipment)
        {
            return equipmentRepository.AddEquipment(equipment);
        }

        public Equipment EditEquipement(Equipment equipment)
        {
            return equipmentRepository.EditEquipement(equipment);
        }

        public void DecreaseEquipment(int equipmentId, int amount)
        {
            Equipment equipment = equipmentRepository.getEquipmentById(equipmentId);
            equipment.equipmentAmount -= amount;
            equipment.equipmentAvailable -= amount;
            equipmentRepository.EditEquipement(equipment);
        }

        public void IncreaseEquipment(int equipmentId, int amount)
        {
            Equipment equipment = equipmentRepository.getEquipmentById(equipmentId);
            equipment.equipmentAmount += amount;
            equipment.equipmentAvailable += amount;
            equipmentRepository.EditEquipement(equipment);
        }

        public int GetEquipmentAmountById(int equipmentId)
        {
            foreach(Equipment equipment in equipmentRepository.GetAllEquipment())
            {
                if(equipment.equipmentId == equipmentId)
                {
                    return equipment.equipmentAmount;
                }
            }
            return 0;
        }

        public List<Equipment> GetAllEquipment()
        {
            return equipmentRepository.GetAllEquipment();
        }
    }
}