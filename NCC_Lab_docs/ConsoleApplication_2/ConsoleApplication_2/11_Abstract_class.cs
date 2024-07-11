using System;

/*
 * Program to demonstrate abstract class
 */

namespace ConsoleApplication_2
{
    public abstract class NewShape
    {
        public abstract void Draw();
    }

    class NewCircle : NewShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
