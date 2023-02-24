using System;

namespace Service
{
    public interface IService
    {
        Object Add(Object obj);
        Object Edit(Object obj);
        Object Delete(Object obj);
    }
}