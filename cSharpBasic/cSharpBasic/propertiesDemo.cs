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