using Model.DrugModel;
using System;
using Service.DrugService;
using System.Collections.Generic;

namespace Controller.DrugController 
{
    public class DrugController : IDrugController
    {
        private static DrugController instance { get; set; }
        private DrugService drugService { get; set; }

        public static DrugController GetInstance(DrugService drugService)
        {
            if (instance == null)
            {
                instance = new DrugController(drugService);
            }
            return instance;
        }

        private DrugController(DrugService drugService)
        {
            this.drugService = drugService;
        }

        public Drug IncreaseDrug(int drugId, int amount)
        {
            return drugService.IncreaseDrug(drugId, amount);
        }

        public Drug DecreaseDrug(int drugId, int amount)
        {
            return drugService.DecreaseDrug(drugId, amount);
        }

        public bool ApproveDrug(Drug drug)
        {
            return drugService.ApproveDrug(drug);
        }

        public Drug AddAlternativeDrug(AlternativeDrug alternativeDrug, Drug drug)
        {
            return drugService.AddAlternativeDrug(alternativeDrug, drug);
        }

        public Drug GetDrugById(int drugId)
        {
            return drugService.GetDrugById(drugId);
        }

        public List<Ingredient> GetDrugIngredients(int drugId)
        {
            return drugService.GetDrugIngredients(drugId);
        }

        public List<Allergens> GetDrugAllergens(int drugId)
        {
            return drugService.GetDrugAllergens(drugId);
        }

        public List<Drug> GetAllDrugs()
        {
            return drugService.GetAllDrugs();
        }

        public object Add(object obj)
        {
            return drugService.Add(obj);
        }

        public object Edit(object obj)
        {
            return drugService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return drugService.Delete(obj);
        }
    }
}