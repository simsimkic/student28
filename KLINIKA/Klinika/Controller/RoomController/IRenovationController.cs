using Model.RoomModel;
using System;

namespace Controller.RoomController
{
    public interface IRenovationController
    {
        Renovation AddRenovation(Renovation renovation);
    }
}