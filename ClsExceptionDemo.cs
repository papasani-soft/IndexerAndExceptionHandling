using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class ClsExceptionDemo
    {
        public void DivideByZero()
        {
            Console.WriteLine("enter first no.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no.");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("result is "+z);
        }
    }
}
