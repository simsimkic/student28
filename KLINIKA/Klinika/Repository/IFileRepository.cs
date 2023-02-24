using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IFileRepository<T>
    {
        IEnumerable<T> GetAll();
        void SaveAll(IEnumerable<T> entities);

    }
}