using System;
using System.Diagnostics.SymbolStore;
using System.Net.Mail;
using cSharpBasic;
using PrimeBasic;

namespace basic
{
    class rectangle
    {
        //instance variables
        private double length;
        private double breadth;
        // default constructor: Constructor without any parameter 
        public rectangle()
        {
            Console.WriteLine("This is default constructor");
        }
        
        //parameterized constructor
        public rectangle(double length1, double breadth1)
        {
            length = length1;   //this.length=length1; this.breadth=breadth1;
            breadth = breadth1;
        }
        
        //method
        public void calcArea()
        {
            double area = length * breadth;
            Console.WriteLine("Area is " + area);
        }

        public double calcPerimeter()
        {
            return (2 * (length + breadth));
        }

        public class rect1
        {
            static void Main(string[] args)
            {
                rectangle r1 = new rectangle();
                rectangle r2 = new rectangle(10.5, 22);
                    
                    //calling methods of rectangle
                    r2.calcArea();
                    double perimeteris = r2.calcPerimeter();
                    Console.WriteLine("Perimeter is " + perimeteris);
                    
                    //creating object of box
                    box b0 = new box();
                    b0.calcArea();

                    box b1 = new box(11, 22, 33);
                    b1.calcArea();
                    
                    //Proporties demo
                    Console.WriteLine("-------Example on Properties--------");
                    Rectangle rec1 = new Rectangle();

                    //calling set of length and breadth
                    rec1.Length = 2; //calls set of Length 
                    rec1.Breadth = 4; //calls get of Length
                    
                    //calling get of length and breadth
                    Console.WriteLine("Length is:" + rec1.Length);
                    Console.WriteLine("Breadth is :" + rec1.Breadth);

                    int propArea = rec1.Breadth * rec1.Breadth;
                    Console.WriteLine("Area is:" + propArea);
                   
                    //method overloading:
                    Console.WriteLine("\n\n Method Overloading Demo:\n");
                    Calculations c1 = new Calculations();
                    //calling first method
                    c1.calc();
                    c1.calc(2, 4);
                    c1.calc(2.2, 4.5);
                    int mulc1 = c1.calc(2, 3, 4);
                    Console.WriteLine("Multiplication is: " + mulc1);
                    
                    //Single level inheritance
                    Console.WriteLine("Single level inheritance");
                    Teacher t1 = new Teacher();
                    t1.setEmp(1, "aavash", "balaju", "csit");
                    t1.displayEmp();
                    t1.setTeacher("OperatingSystem","40k");
                    t1.getTeacher();

                    Employee e1 = new Employee();
                    e1.setEmp(1, "bijju", "maipi", "marketing");
                    e1.displayEmp();
                    
                    //multilevel Inheritance:
                    Console.WriteLine("\n*********** Example on multilevel **************\n");
                    
                    //creating object of electric bike:
                    ElectricBike eb = new ElectricBike();
                    //using grandparent (two wheeler properties):
                    eb.Reg = 2;
                    eb.Name = "P10";
                    eb.Brand = "Yatri";
                    
                    //using property of child( bike)
                    eb.Cc = "--";
                    eb.FuelCapacity = "--";
                    
                    //using property of own (Electric Bike)
                    eb.Range = "300km";
                    Console.WriteLine("Reg: "  + eb.Reg);
                    Console.WriteLine("Name: " + eb.Name);
                    Console.WriteLine("Brand: " + eb.Brand);
                    Console.WriteLine("CC: " + eb.Cc);
                    Console.WriteLine("Fuel: " + eb.FuelCapacity);
                    Console.WriteLine("Range:" + eb.Range);
                    
                    //creating object of parent(bike)

                    Bike bk = new Bike();
                    bk.Reg = 3;
                    bk.Name = "Pulsar";
                    bk.Brand = "Yamaha";
                    bk.Cc = "220";
                    bk.FuelCapacity = "15l";
                    
                    Console.WriteLine("\n\nReg: "  + bk.Reg);
                    Console.WriteLine("Name: " + bk.Name);
                    Console.WriteLine("Brand: " + bk.Brand);
                    Console.WriteLine("CC: " + bk.Cc);
                    Console.WriteLine("Fuel: " + bk.FuelCapacity);
                    
                    //Example on method overriding "baseexaple2.cs"
                    Console.WriteLine("\n\n Exaample on Method of overriding");
                    Solutions sol1 = new Solutions();
                    sol1.calc1();
                    sol1.calc2(30,40);
                    
                    //Exception Demo 
                    Console.WriteLine("\n\nException demo:");
                    exceptionDemo ed = new exceptionDemo();
                    ed.setData();
                    
                    //Custom Exception
                    Console.WriteLine("\n\n ----Custom Exception---");
                    customeExceptionDemo ce = new customeExceptionDemo();
                    try
                    {
                        ce.setAge(14);
                    }
                    catch (AgeException a)
                    {
                        Console.WriteLine(a);
                    }
                    
                    // File demo:
                    
                    Console.WriteLine("\n\n File Demo: \n");
                    fileReadWriteDemo fd = new fileReadWriteDemo();
                    fd.readFile();
                    fd.writeFile();
                    
                    //array demo
                    Console.WriteLine("\n\n-------Array Demo--------");
                    array_demo ad = new array_demo();
                    ad.setArray();
                    
                    Console.ReadKey();
            }
        }
    }
}