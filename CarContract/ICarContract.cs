using System;

namespace CarSample
{
    public interface ICarContract<T>
    {
        string DoSomething(T foo);
    }
}
