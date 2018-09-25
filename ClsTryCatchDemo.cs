using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class ClsTryCatchDemo
    {
        public void CreateTryCatch()
        {
            try
            {
                Console.WriteLine("enter first no.");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second no.");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("result is " + z);           
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("input must be numeric value");
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
        }
    }
}
