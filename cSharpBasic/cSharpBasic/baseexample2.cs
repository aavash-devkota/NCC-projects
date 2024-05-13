//Base example 2 demo:

//(10 marks in exam)

//method overriding: if superclass and subclass have same method (same name, same return type,and same parameter)
// to call overridden method of superclass from subclass base keyword is usrd

//for method overriding two keywords are used
// virtual: rep overridden method in supercalss
// override: represent overridden method in subcalss

// This is also calledDynamic polymorphism

using System;

namespace PrimeBasic
{
    public class Calcualtions
    {
        public virtual void calc1()
        {
            Console.WriteLine("Default method of calc superclass");
        }

        public virtual void calc2(int x, int y)
        {
            Console.WriteLine("sum is: " + (x+y));
        }
        
    }

    class Solutions: Calcualtions
    {
        public override void calc1()
        {
            base.calc1();
            Console.WriteLine("Defalut method of subclass");
        }

        public override void calc2(int x, int y)
        {
            base.calc2(x,y);
            Console.WriteLine("Difference is: " + (x-y));
        }
    }
} 