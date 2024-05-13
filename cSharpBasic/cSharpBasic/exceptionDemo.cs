// excpeption is the type of error that disturb the normal flow of program. 
// if exception occurs then the whole program is stopped
// to deal with such errors exception handling mechanism is required
//it contains 4 keywords:
// 1. try : used to surround a code that can cause errors
// 2. catch: use to handel a exception
// 3. throw: use to throw own exception
// 4. this block is always executed, whether exception occurs or not

using System;

namespace cSharpBasic
{
    public class exceptionDemo
    {
        public void setData()
        {
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Numeber: ");
            int y = int.Parse(Console.ReadLine());
            try
            {
                int div = x / y;
                Console.WriteLine("div is: " + div);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Cannot divide! " + d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Always Executed!");
            }
            Console.WriteLine("Reached outside of try catch.");
        }
    }
}