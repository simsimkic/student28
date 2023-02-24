using System;
using System.Collections;
using System.Collections.Generic;

namespace Model.DrugModel
{
    public class Drug
    {
        public List<Ingredient> ingredients { get; set; }
        public AlternativeDrug alternativeDrug { get; set; }
        public List<Allergens> allergens { get; set; }
        public int drugId { get; set; }
        public String name { get; set; }
        public int amount { get; set; }
        public Boolean approved { get; set; }


        public Drug(List<Ingredient> ingredients, AlternativeDrug alternativeDrug, List<Allergens> allergens, int drugId, string name, int amount, bool approved)
        {
            this.ingredients = ingredients;
            this.alternativeDrug = alternativeDrug;
            this.allergens = allergens;
            this.drugId = drugId;
            this.name = name;
            this.amount = amount;
            this.approved = approved;
        }
    }
}