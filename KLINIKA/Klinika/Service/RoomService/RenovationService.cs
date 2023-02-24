using Model.RoomModel;
using Repository.RoomRepository;
using System;

namespace Service.RoomService
{
    public class RenovationService : IRenovationService
    {
        private static RenovationService instance { get; set; }
        private RenovationRepository renovationRepository { get; set; }

        public static RenovationService GetInstance(RenovationRepository renovationRepository)
        {
            if (instance == null)
            {
                instance = new RenovationService(renovationRepository);
            }
            return instance;
        }

        private RenovationService(RenovationRepository renovationRepository)
        {
            this.renovationRepository = renovationRepository;
        }

        public Renovation AddRenovation(Renovation renovation)
        {
            return renovationRepository.AddRenovation(renovation);
        }

    }
}