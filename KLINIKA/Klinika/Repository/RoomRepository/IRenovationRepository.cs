using Model.RoomModel;
using System;

namespace Repository.RoomRepository
{
    public interface IRenovationRepository
    {
        Renovation AddRenovation(Renovation renovation);
    }
}