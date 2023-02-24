using System;
using System.Collections.Generic;

namespace Model.DrugModel
{
    public class AlternativeDrug
    {
        public Drug drug { get; set; }

        public AlternativeDrug(Drug drug)
        {
            this.drug = drug;
        }
    }
}