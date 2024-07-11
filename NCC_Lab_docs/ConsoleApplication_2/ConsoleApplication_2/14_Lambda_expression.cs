using System;

/*
 * Program to demonstrate Lambda Expression
 */
namespace ConsoleApplication_2
{
    delegate int MathOperation(int x, int y);
    class LambdaExpression
    {
        public void Lambda()
        {
            MathOperation add = (x, y) => x + y;
            Console.WriteLine(add(10, 20));
        }
    }
}
