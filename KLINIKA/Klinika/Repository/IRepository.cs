using System;

namespace Repository
{
    public interface IRepository 
    {
        Object Add(Object obj);
        Object Edit(Object obj);
        Boolean Delete(Object obj);
    }
}