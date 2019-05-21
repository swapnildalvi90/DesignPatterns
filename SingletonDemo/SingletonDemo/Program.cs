using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetInstance;
            obj1.HelloFromSinglton();

            Singleton obj2 = Singleton.GetInstance;
            obj2.HelloFromSinglton();

            Console.ReadKey();
        }
    }
}
