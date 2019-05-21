using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Singleton
    {
        private static int counter = 0;

        //this will be returned everytime from static property which will be used in other classes
        public static Singleton singletonObj = null;

        //constructor should be private so that no other class should create instance of this singleton class 
        private Singleton()
        {
            counter++;
            Console.WriteLine(string.Format("Number of instances created {0}", counter));
        }

        //this property should be public so that anyone can access this to get instance
        public static Singleton GetInstance
        {
            get
            {
                if (singletonObj == null)
                    singletonObj = new Singleton();
                return singletonObj;
            }
        }

        public void HelloFromSinglton()
        {
            Console.WriteLine("Hello from Singleton");
        }
    }
}
