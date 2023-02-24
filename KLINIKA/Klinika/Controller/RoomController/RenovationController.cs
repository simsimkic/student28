using Model.RoomModel;
using Service.RoomService;
using System;

namespace Controller.RoomController
{
    public class RenovationController : IRenovationController
    {
        private static RenovationController instance { get; set; }
        private RenovationService renovationService { get; set; }
        
        public static RenovationController GetInstance(RenovationService renovationService)
        {
            if (instance == null)
            {
                instance = new RenovationController(renovationService);
            }
            return instance;
        }

        private RenovationController(RenovationService renovationService)
        {
            this.renovationService = renovationService;
        }

        public Renovation AddRenovation(Renovation renovation)
        {
            return renovationService.AddRenovation(renovation);
        }
    }
}