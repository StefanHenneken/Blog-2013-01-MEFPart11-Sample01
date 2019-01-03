using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace CarSample
{
    class Program
    {
        [Import]
        private ICarContract<int> carInt = null;

        [Import]
        private ICarContract<string> carString = null;

        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {           
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
           
            container.ComposeParts(this);

            Console.WriteLine(carInt.DoSomething(10));
            Console.WriteLine(carString.DoSomething("Hello"));
        }
    }
}
