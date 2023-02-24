using System;

namespace Controller
{
    public interface IController
    {
        Object Add(Object obj);
        Object Edit(Object obj);
        Object Delete(Object obj);
    }
}