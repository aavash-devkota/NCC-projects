using System;

namespace basic
{
    public class Calculations
    {
        public void calc()
        {
            Console.WriteLine("This is default calc");
        }

        public void calc(int x, int y)
        {
            Console.WriteLine("Sum is: " + (x+y));
        }

        public void calc(double x, double y)
        {
            Console.WriteLine("Difference is: " + (x-y));
        }
        
        //method with return type
        public int calc(int x, int y, int z)
        {
            return (x*y*z);
        }
    }
}