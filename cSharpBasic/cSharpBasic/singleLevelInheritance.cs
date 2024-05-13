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