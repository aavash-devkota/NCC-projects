using System;

/*
 * Program to demonstrate use of Base keyword in C#
 */

namespace ConsoleApplication_2
{
    class Base
    {
        private int id;
        public Base(int id)
        {
            this.id = id;
            Console.WriteLine(id);
        }
    }

    class Derived : Base
    {
        public Derived(int id) : base(id) { }
    }
}
