using System;
using System.Collections.Generic;
using System.Text;

namespace _01_singleton
{
    /// <summary>
    /// Creational Patterns    
    /// </summary>
    class Program
    {
        public static void Main()
        {

            //Singleton singleton = new Singleton();
            Singleton nesne1 = Singleton.GetInstance();
            Singleton nesne2 = Singleton.GetInstance();

            if (nesne1 == nesne2)
            {
                Console.WriteLine("Test 1");
            }

            if (nesne1.Equals(nesne2))
            {
                Console.WriteLine("Test 2");
            }

            if (nesne1.GetHashCode() == nesne2.GetHashCode())
            {
                Console.WriteLine("Test 3");
            }
        }
    }
}
