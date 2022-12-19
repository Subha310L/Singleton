using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton frombank = Singleton.GetInstance;
            frombank.PrintDetails("From Bank ");
            Singleton fromCustomer = Singleton.GetInstance;
            fromCustomer.PrintDetails("From customer");
            Console.ReadLine();
        }
    }
}


// https://dotnettutorials.net/lesson/singleton-design-pattern/ -- read