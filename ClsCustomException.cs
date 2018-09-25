using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class DivideByOddNoException :ApplicationException
    {
        public override string  Message
        {
            get
            {
                return "Attempted to divide by odd number";
            }
        }
    }
    class ClsCustomException
    {
        public void CreateCustomException()
        {
            Console.WriteLine("enter first no.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 2 > 0)
            {
                throw new DivideByOddNoException();
            }
            int z = x / y;
            Console.WriteLine("result is " + z);
        }
    }
}
