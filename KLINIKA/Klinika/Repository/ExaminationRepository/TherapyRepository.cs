using Klinika.Repository;
using Model.ExaminationModel;
using System;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class TherapyRepository : ITherapyRepository
    {
        private static TherapyRepository instance { get; set; }
        private FileRepository<Therapy> stream { get; set; }

        public static TherapyRepository GetInstance(FileRepository<Therapy> stream)
        {
            if (instance == null)
            {
                instance = new TherapyRepository(stream);
            }
            return instance;
        }

        private TherapyRepository(FileRepository<Therapy> stream)
        {
            this.stream = stream;
        }

        public Therapy AddTherapy(Therapy therapy)
        {
            var allTherapy = stream.GetAll().ToList();
            allTherapy.Add(therapy);
            stream.SaveAll(allTherapy);
            return therapy;
        }
    }
}