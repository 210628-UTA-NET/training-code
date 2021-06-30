using System;

namespace HelloWord
{
    public class BoxingAndUnboxing
    {
        public static void BoxingAndUnboxingMain()
        {
            Console.WriteLine("==== Boxing and Unboxing Demo ====");

            int num = 123;

            //Example of Implicit Conversion
            double doubled = num+0.235;
            Console.WriteLine(doubled);

            //Example of Explicit Conversion
            //Example of using a Cast
            int num1 = (int)doubled;
            Console.WriteLine(num1);

            //Boxing
            //It is when a value type gets casted into an object
            //What happens is that the value is wrapped to give it a reference type behavior
            //It is an example of implicit conversion (meaning you don't have to put any special syntax to do it)
            object obj = num;
            Console.WriteLine(obj);

            //Unboxing
            //It is when you extract the value type from the object and just get the value directly instead
            //A syntax is needed (Cast)
            //It is an example of explicit conversion
            int num3 = (int)obj;
            Console.WriteLine(num3);
        }
    }
}