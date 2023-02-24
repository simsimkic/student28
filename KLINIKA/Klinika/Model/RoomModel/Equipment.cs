using System;

namespace Model.RoomModel
{
    public class Equipment
    {
        public int equipmentId { get; set; }
        public String equipmentName { get; set; }
        public int equipmentAmount { get; set; }
        public int equipmentAvailable { get; set; }

        public Equipment(int equipmentId, string equipmentName, int equipmentAmount, int equipmentAvailable)
        {
            this.equipmentId = equipmentId;
            this.equipmentName = equipmentName;
            this.equipmentAmount = equipmentAmount;
            this.equipmentAvailable = equipmentAvailable;
        }

        public override string ToString()
        {
            return equipmentName + " " + equipmentAmount.ToString();
        }
    }
}