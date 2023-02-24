using Model.DrugModel;
using System;
using System.Collections.Generic;

namespace Service.DrugService
{
    public interface IDrugService : IService
    {
        Drug IncreaseDrug(int drugId, int amount);
        Drug DecreaseDrug(int drugId, int amount);
        Boolean ApproveDrug(Drug drug);
        Drug AddAlternativeDrug(AlternativeDrug alternativeDrug, Drug drug);
        Drug GetDrugById(int drugId);
        List<Ingredient> GetDrugIngredients(int drugId);
        List<Allergens> GetDrugAllergens(int drugId);
        List<Drug> GetAllDrugs();
    }
}