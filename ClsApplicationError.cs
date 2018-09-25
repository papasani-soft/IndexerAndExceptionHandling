using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class ClsApplicationError
    {
        public void ApplicationError()
        {          
            Console.WriteLine("enter first no.");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y%2>0)
            {
                throw new ApplicationException("you given odd number in the divider");
            }
            int z = x / y;
            Console.WriteLine("result is " + z);   
            
        }
    }
}
