using Klinika.Repository;
using Model.DrugModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.DrugRepository
{
    public class DrugRepository : IDrugRepository
    {
        private static DrugRepository instance { get; set; }
        private FileRepository<Drug> stream { get; set; }

        public static DrugRepository GetInstance(FileRepository<Drug> stream)
        {
            if (instance == null)
            {
                instance = new DrugRepository(stream);
            }
            return instance;
        }

        private DrugRepository(FileRepository<Drug> stream)
        {
            this.stream = stream;
        }

        public Drug GetDrugById(int drugId)
        {
            foreach(Drug drug in stream.GetAll().ToList())
            {
                if(drug.drugId == drugId)
                {
                    return drug;
                }
            }
            return null;
        }

        public List<Ingredient> GetDrugIngredients(int drugId)
        {
            foreach (Drug drug in stream.GetAll().ToList())
            {
                if (drug.drugId == drugId)
                {
                    return drug.ingredients;
                }
            }
            return null;
        }

        public List<Allergens> GetDrugAllergens(int drugId)
        {
            foreach (Drug drug in stream.GetAll().ToList())
            {
                if (drug.drugId == drugId)
                {
                    return drug.allergens;
                }
            }
            return null;
        }

        public List<Drug> GetAllDrugs()
        {
            return stream.GetAll().ToList();
        }

        public object Add(object obj)
        {
            var allDrugs = stream.GetAll().ToList();
            allDrugs.Add((Drug)obj);
            stream.SaveAll(allDrugs);
            return obj;
        }

        public object Edit(object obj)
        {
            var allDrugs = stream.GetAll().ToList();
            var editedDrug = (Drug)obj;
            foreach(Drug drug in allDrugs)
            {
                EditDrugIfFound(drug, editedDrug);
            }
            stream.SaveAll(allDrugs);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allDrugs = stream.GetAll().ToList();
            if (allDrugs.Remove((Drug)obj))
            {
                stream.SaveAll(allDrugs);
                return true;
            }
            return false;
        }

        private void EditAllDrugAttributes(Drug drug, Drug editedDrug)
        {
            drug.allergens = editedDrug.allergens;
            drug.alternativeDrug = editedDrug.alternativeDrug;
            drug.amount = editedDrug.amount;
            drug.approved = editedDrug.approved;
            drug.ingredients = editedDrug.ingredients;
            drug.name = editedDrug.name;
        }

        private void EditDrugIfFound(Drug drug, Drug editedDrug)
        {
            if (drug.drugId == editedDrug.drugId)
            {
                EditAllDrugAttributes(drug, editedDrug);
            }
        }
    }
}