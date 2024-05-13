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