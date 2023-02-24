using Klinika.Repository;
using Model.RoomModel;
using Repository.RoomRepository;
using System;
using System.Linq;

namespace Repository.RoomRepository
{
    public class RenovationRepository : IRenovationRepository
    {
        private static RenovationRepository instance { get; set; }
        private FileRepository<Renovation> stream { get; set; }

        public static RenovationRepository GetInstance(FileRepository<Renovation> stream)
        {
            if (instance == null)
            {
                instance = new RenovationRepository(stream);
            }
            return instance;
        }

        private RenovationRepository(FileRepository<Renovation> stream)
        {
            this.stream = stream;
        }

        public Renovation AddRenovation(Renovation renovation)
        {
            var allRenovations = stream.GetAll().ToList();
            allRenovations.Add(renovation);
            stream.SaveAll(allRenovations);
            return renovation;
        }
    }
}