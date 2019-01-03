using System;
using System.ComponentModel.Composition;

namespace CarSample
{
    [Export(typeof(ICarContract<>))]
    public class CarPart<T> : ICarContract<T>
    {
        public string DoSomething(T foo)
        {
            return String.Format("Value: {0}  Type: {1}", foo.ToString(), foo.GetType().Name);
        }
    }
}
