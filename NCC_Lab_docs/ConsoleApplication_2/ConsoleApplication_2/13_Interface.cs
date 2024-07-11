using System;

/*
 * Program to demonstrate the use of Interface
 */

namespace ConsoleApplication_2
{
    interface IPerson
    {
        void Greetings();
    }

    class Ram : IPerson
    {
        public void Greetings()
        {
            Console.WriteLine("Hello, I am Ram.");
        }
    }
}