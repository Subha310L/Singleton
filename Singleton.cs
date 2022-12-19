using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{

    // class singleton is seales - cls cannot be inherited and obj instantiation
    //class created with a private constructor
    
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        //only one instance of the cls is created based on the null condition

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
