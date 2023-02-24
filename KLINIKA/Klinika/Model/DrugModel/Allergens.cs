using System;

namespace Model.DrugModel
{
    public class Allergens
    {
        public String allergenName { get; set; }

        public Allergens(string allergenName)
        {
            this.allergenName = allergenName;
        }
    }
}