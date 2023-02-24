using Model.RoomModel;
using System;

namespace Service.RoomService
{
    public interface IRenovationService
    {
        Renovation AddRenovation(Renovation renovation);
    }
}