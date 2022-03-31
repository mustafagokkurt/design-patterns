using System;

namespace _01_singleton
{    
    class Singleton
    {
        private static Singleton obj;

        //constructor private yapılarak nesne yaratma engellenir.
        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            if (obj == null)
            {
                obj = new Singleton();
            }

            return obj;
        }
    }
}
