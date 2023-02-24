using Model.DrugModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Controller.DrugController
{
    public class DrugDecorator : IDrugController
    {
        private IDrugController iDrugController { get; set; }
        private User user { get; set; }

        public DrugDecorator(IDrugController iDrugController, User user)
        {
            this.iDrugController = iDrugController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iDrugController.Add(obj);
        }

        public Drug AddAlternativeDrug(AlternativeDrug alternativeDrug, Drug drug)
        {
            return iDrugController.AddAlternativeDrug(alternativeDrug, drug);
        }

        public bool ApproveDrug(Drug drug)
        {
            return iDrugController.ApproveDrug(drug);
        }

        public Drug DecreaseDrug(int drugId, int amount)
        {
            return iDrugController.DecreaseDrug(drugId, amount);
        }

        public object Delete(object obj)
        {
            return iDrugController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iDrugController.Edit(obj);
        }

        public List<Drug> GetAllDrugs()
        {
            return iDrugController.GetAllDrugs();
        }

        public List<Allergens> GetDrugAllergens(int drugId)
        {
            return iDrugController.GetDrugAllergens(drugId);
        }

        public Drug GetDrugById(int drugId)
        {
            return iDrugController.GetDrugById(drugId);
        }

        public List<Ingredient> GetDrugIngredients(int drugId)
        {
            return iDrugController.GetDrugIngredients(drugId);
        }

        public Drug IncreaseDrug(int drugId, int amount)
        {
            return iDrugController.IncreaseDrug(drugId, amount);
        }
    }
}