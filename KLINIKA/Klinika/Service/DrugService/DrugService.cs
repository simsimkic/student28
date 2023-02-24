using Model.DrugModel;
using Repository.DrugRepository;
using System;
using System.Collections.Generic;

namespace Service.DrugService
{
    public class DrugService : IDrugService
    {
        private static DrugService instance { get; set; }
        private DrugRepository drugRepository { get; set; }

        public static DrugService GetInstance(DrugRepository drugRepository)
        {
            if (instance == null)
            {
                instance = new DrugService(drugRepository);
            }
            return instance;
        }

        private DrugService(DrugRepository drugRepository)
        {
            this.drugRepository = drugRepository;
        }

        public Drug IncreaseDrug(int drugId, int amount)
        {
            Drug drugToDecrease = drugRepository.GetDrugById(drugId);
            drugToDecrease.amount += amount;
            return (Drug)drugRepository.Edit(drugToDecrease);
        }

        public Drug DecreaseDrug(int drugId, int amount)
        {
            Drug drugToDecrease = drugRepository.GetDrugById(drugId);
            drugToDecrease.amount = drugToDecrease.amount - amount;
            return (Drug)drugRepository.Edit(drugToDecrease);          
        }

        public bool ApproveDrug(Drug drug)
        {
            Drug drugToApprove = drugRepository.GetDrugById(drug.drugId);
            drugToApprove.approved = true;
            drugRepository.Edit(drugToApprove);
            return true;
        }

        public Drug AddAlternativeDrug(AlternativeDrug alternativeDrug, Drug drug)
        {
            drug.alternativeDrug = alternativeDrug;
            return (Drug)drugRepository.Edit(drug);          
        }

        public Drug GetDrugById(int drugId)
        {
            return drugRepository.GetDrugById(drugId);
        }

        public List<Ingredient> GetDrugIngredients(int drugId)
        {
            return drugRepository.GetDrugIngredients(drugId);
        }

        public List<Allergens> GetDrugAllergens(int drugId)
        {
            return drugRepository.GetDrugAllergens(drugId);
        }

        public List<Drug> GetAllDrugs()
        {
            return drugRepository.GetAllDrugs();
        }

        public object Add(object obj)
        {
            return drugRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return drugRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return drugRepository.Delete(obj);
        }
    }
}