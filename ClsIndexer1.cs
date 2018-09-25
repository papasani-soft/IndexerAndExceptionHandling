using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)
                    Job = (string)value;
                else if (index == 3)
                    Salary = (double)value;
                else if (index == 4)
                    Dname = (string)value;
                else if (index == 5)
                    Location = (string)value;
               
            }
        }
    }
    class TestEmployee
    {
        public void MEmployee()
        {
        Employee emp = new Employee(102, "hari","manager",25000.00,"computers","bangalore");
            emp[2] = "hr";
            emp[3] = 25123.00;
            Console.WriteLine("Eno:"+emp[0]);
            Console.WriteLine("Ename:" + emp[1]);
            Console.WriteLine("Job:" + emp[2]);
            Console.WriteLine("Salary:" + emp[3]);
            Console.WriteLine("Dname:" + emp[4]);
            Console.WriteLine("Location:" + emp[5]);

           
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
