# Array Demo

```
using System;

namespace cSharpBasic
{
public class array_demo
{
public void setArray()
{
//1d Array

            //direct method
            int[] array1 = { 1, 2, 3, 4, 5 };
            
            //size
            int[] array2 = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("\n\n------Using For Loop------");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            
            //2d array
            int[,] array3 =
            {
                { 2, 3, 4 }, //0th row 3 col (0-2)
                { 5, 6, 7 },
                { 1, 5, 9 }
            };
            Console.WriteLine("\nUsing for each loop:");
            foreach (int a in array3)
            {
                Console.Write(a);
            }
            
            Console.WriteLine("\nUsing for loop array:");
            
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j<array3.GetLength(1); j++)
                {
                    Console.Write(array3[i,j]);
                }
                Console.WriteLine(" ");
            }
            
            //jagged array:variation in column
            int[][] jagged = new int[3][];
            jagged[0] = new[] { 1, 2, 3 };
            jagged[1] = new[] { 4, 5, 6, 7 };
            jagged[2] = new[] { 7, 8 };
            
            Console.WriteLine("\nUsing for loop for jagged array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j<jagged.Length; j++)
                {
                    Console.Write(jagged[i][j]);
                }
                Console.WriteLine(" ");
            }
            
            Console.WriteLine("\nUsing for each loop for jagged array");
            foreach (int []i in jagged)    
            {
                foreach (int j in i)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}
```

# Properties Demo

```
using System;

namespace basic
{
    public class Rectangle
    {
        //properties is used to initialize instance variable and to to return value of instance variable 
        // it is same line getter and setter method 
        // set is used to initialize instance variable and get is used to return the value of instance variable

        private int length;
        private int breadth;
        //using properties:
        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public int Breadth
        {
            get { return this.breadth; }
            set { this.breadth = value; }

        } 
    }
}
```
# Base Demo

```
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
```

# Constructor

```
using System;

namespace basic
{
    public class box
    {
        //instance variable : class data 
        private int length;
        private int breadth;
        private int height;
        
        //constructor: used to initialize instance variables 
        // default constructor: without parameter

        public box()
        {
            length = 0;
            breadth = 0;
            height = 0;
        }
        
        //parameterized constructor:

        public box(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        
        //method: used to provide some services
        // method without returning value:

        public void calcArea()
        {
            int area = this.length * this.breadth * this.height;
            Console.WriteLine("Area of box is:" + area);
        }
    }
}
```

# Calling Superclass Constructor Demo

```
// Base example 1  demo:

//(10 marks in exam)

//subclass cannot call the constructor of super class directly because constructor 
//is called whenever object of particular class is created

//to call the constructor of the superclass 

using System;

namespace basic
{
    public class Student
    {
        private int id;
        private string name;
        private string faculty;

        //default constructor:
        public Student()
        {
            Console.WriteLine("\n\nDefault constructor of student:\n");

        }

        public Student(int id, string name, string faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }

        public void displayStudent()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name" + name);
            Console.WriteLine("Faculty:" + faculty);
        }
    }

    class Captain : Student
        {
            public string res;

            public Captain():base()
            {
                Console.WriteLine("\n\nDefault cons of captain:\n");
            }

            public Captain(string res, int id, string name, string faculty) : base(id, name, faculty)
            {
                this.res = res;
            }

            public void diaplayCaptain()
            {
                Console.WriteLine("Res is: " + res);
            }
        }
}
```


# Single Level Inheritance

```
using System;
using System.Runtime.CompilerServices;

namespace basic
{
        //inheritance is a process of acquiring properties of one class by another class. it is used to reuse code and to reduce code redundancy.
        //1. single level: one or more child class inherits one parent class
        //2. multilevel: if first calss gets inherited by second and second class inturns gets inherited third and so no
        //3. Multiple: If one child can inherit more than one parent then such condition is multiple inheritnce
        //class that inherits other class is sub class, derived
        //class that gets inherit by other class id called super class
        public class Employee
        {
                private int eid;
                private string name;
                private string address;
                private string depart;
                //methods to set initialize instance variables

                public void setEmp(int eid, string name, string address, string depart)
                {
                        this.eid = eid;
                        this.name = name;
                        this.address = address;
                        this.depart = depart;
                }

                public void displayEmp()
                {
                        Console.WriteLine("id is:" + this.eid);
                        Console.WriteLine("name is:" + this.name);
                        Console.WriteLine("address is: " + this.address);
                        Console.WriteLine(("department is:" + this.depart));
                }
        }

        //creating child class that will inherit Employee class
                class Teacher : Employee
                {
                        private string specialization;
                        private string salary;
                

                public void setTeacher(string specialization, string salary)
                {
                        this.specialization = specialization;
                        this.salary = salary;
                }

                public void getTeacher()
                {
                        Console.WriteLine("Salary is:" + this.salary);
                        Console.WriteLine("salary is:" + this.salary);
                        
                }
                
        }
}
```

# Multilevel Inheritance

```
//multilevel inheritance: one class inherits another and such class inturns get inherited by other class. it is like grandparent, parent and child relation
namespace basic
{
    public class TwoWheelers
    {
        private int reg;
        private string name;
        private string brand;
        
        //properties 
        public int Reg
        {
            get { return reg; }
            set { reg = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    class Bike : TwoWheelers
    {
        private string cc;
        private string fuelCapacity;

        public string Cc
        {
            get { return cc; }
            set { cc = value; }
        }

        public string FuelCapacity
        {
            get { return fuelCapacity; }
            set { fuelCapacity = value; }
        }
    }

    class ElectricBike : Bike
    {
        private string range;

        public string Range
        {
            get { return range; }
            set { range = value; }
        }
    }
}
```

# Method Overloading

```
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
```

# Exception Demo

```
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
```

# Exception(Custume) Demo

```
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
```

# File Read Write Demo

```
using System;
using System.IO;

namespace cSharpBasic
{
    public class fileReadWriteDemo
    {
        public void writeFile()
        {
            StreamWriter sw = new StreamWriter("/home/aavash/RiderProjects/cSharpBasic/cSharpBasic/files/1.txt");
            Console.WriteLine("insert text to enter: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
        }

        public void readFile()
        {
            StreamReader sr = new StreamReader("/home/aavash/RiderProjects/cSharpBasic/cSharpBasic/files/1.txt");
            string data1 = sr.ReadLine();
            Console.WriteLine();
            sr.Close();
        }
    }
}
```