using Klinika.Repository;
using Model.RoomModel; 
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.RoomRepository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private static EquipmentRepository instance { get; set; }
        private FileRepository<Equipment> stream { get; set; }

        public static EquipmentRepository GetInstance(FileRepository<Equipment> stream)
        {
            if (instance == null)
            {
                instance = new EquipmentRepository(stream);
            }
            return instance;
        }

        private EquipmentRepository(FileRepository<Equipment> stream)
        {
            this.stream = stream;
        }
        
        public Equipment AddEquipment(Equipment equipment)
        {
            var allEquipments = stream.GetAll().ToList();
            allEquipments.Add(equipment);
            stream.SaveAll(allEquipments);
            return equipment;
        }

        public Equipment EditEquipement(Equipment editedEquipment)
        {
            var allEquipments = stream.GetAll().ToList();
            foreach (Equipment equipment in allEquipments)
            {
                EditEquipmentIfFound(equipment, editedEquipment);
            }
            stream.SaveAll(allEquipments);
            return editedEquipment;
        }

        public int GetEquipmentAmountById(int equipmentId)
        {
            foreach (Equipment equipment in stream.GetAll().ToList())
            {
                if (equipment.equipmentId == equipmentId)
                {
                    return equipment.equipmentAmount;
                }
            }
            return 0;
        }

        public Equipment getEquipmentById(int eqId)
        {
            foreach(Equipment equipment in stream.GetAll().ToList())
            {
                if(eqId == equipment.equipmentId)
                {
                    return equipment;
                }
            }
            return null;
        }

        public List<Equipment> GetAllEquipment()
        {
            var allEquipments = stream.GetAll().ToList();
            return allEquipments;
        }

        private void EditAllEquipmentAttributes(Equipment equipment1, Equipment equipment2)
        {
            equipment1.equipmentAmount = equipment2.equipmentAmount;
            equipment1.equipmentAvailable = equipment2.equipmentAvailable;
            equipment1.equipmentName = equipment2.equipmentName;
        }

        private void EditEquipmentIfFound(Equipment equipment, Equipment editedEquipment)
        {
            if (equipment.equipmentId == editedEquipment.equipmentId)
            {
                EditAllEquipmentAttributes(equipment, editedEquipment);
            }
        }
    }
}