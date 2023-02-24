using System;
using Model.UserModel;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public interface IDirectorRepository
    {
        List<Director> getAllDirectors();
        Director EditDirector(Director director);
    }
}