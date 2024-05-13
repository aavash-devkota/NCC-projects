// How can you create a custom exception demo? Asked in exam.

//To create own kind of exception:
// 1. Create a error class by inheriting superclass Exception and call the constructor with error message
// 2. use throw keyword to throw particular exception 

using System;

namespace cSharpBasic
{
    public class AgeException : Exception
    {
        public AgeException(string msg) : base(msg)
        {
            
        }
    }

    class customeExceptionDemo
    {
        public void setAge(int age)
        {
            if (age < 16)
            {
                throw new AgeException("age cannot be less than 16");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    } 
}