using System;

/*
 * * Program to demonstrate use of Method Overriding in C#
 */
namespace ConsoleApplication_2
{
    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent's Display() method");
        }
    }

    class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Child's Display() method");
        }
    }
}
