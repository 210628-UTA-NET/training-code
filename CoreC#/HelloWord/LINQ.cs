using System;
using System.Linq;

namespace HelloWord
{
    public class LINQ
    {
        public static void LINQMain()
        {
            Console.WriteLine("=== LINQ Demo ===");
            int[] numbers = new int[]{1,2,3,4,5};

            //Query Syntax way
            //It is very similar to SQL Statement
            var queryResult = (from num in numbers
                                where num%2==0
                                select num);
            
            foreach (var num in queryResult)
            {
                Console.WriteLine(num);
            }

            //Method Syntax way
            
            var queryMethodResult = numbers.Where(num => num%2==0);

            Console.WriteLine("=========");
            foreach (var num in queryMethodResult)
            {
                Console.WriteLine(num);
            }
        }
    }
}