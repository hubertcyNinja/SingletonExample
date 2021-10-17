using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DIHeater newDIHeater1 = DIHeater.GetInstance();
            DIHeater newDIHeater2 = DIHeater.GetInstance();
            IRHeater newIRHeater1 = IRHeater.Instance;
            IRHeater newIRHeater2 = IRHeater.Instance;

            Console.WriteLine("DIHeater1 hashcode: {0}", newDIHeater1.GetHashCode());
            Console.WriteLine("DIHeater1 hashcode: {0}", newDIHeater2.GetHashCode());
            Console.WriteLine("IRHeater1 hashcode: {0}", newIRHeater1.GetHashCode());
            Console.WriteLine("IRHeater2 hashcode: {0}", newIRHeater2.GetHashCode());
            
        }
    }
}
