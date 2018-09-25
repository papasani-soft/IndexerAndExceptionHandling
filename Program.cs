using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter program no. to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ClsIndexer obj1 = new ClsIndexer();
                    obj1.CreateIndexer();
                    break;
                case 2:
                    TestEmployee obj2 = new TestEmployee();
                    obj2.MEmployee();
                    break;
                default:
                    break;
            }
        }
    }
}
