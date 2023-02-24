using Model.DrugModel;
using System;
using System.Collections.Generic;

namespace Repository.DrugRepository
{
    public interface IDrugRepository : IRepository
    {
        Drug GetDrugById(int drugId);
        List<Ingredient> GetDrugIngredients(int drugId);
        List<Allergens> GetDrugAllergens(int drugId);
        List<Drug> GetAllDrugs();
    }
}