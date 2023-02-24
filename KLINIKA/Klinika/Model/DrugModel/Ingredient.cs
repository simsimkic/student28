using System;

namespace Model.DrugModel
{
    public class Ingredient
    {
        public String ingredientName { get; set; }

        public Ingredient(string ingredientName)
        {
            this.ingredientName = ingredientName;
        }
    }
}