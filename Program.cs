using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MathMethods2.
            MathMethods2 math1 = new MathMethods2();

            // Call the first method with an integer parameter and display the result.
            Console.WriteLine(math1.MathOp(7));

            // Call the second method with a decimal parameter and display the result.
            Console.WriteLine(math1.MathOp(7.3m));

            // Call the third method with a string parameter and display the result.
            Console.WriteLine(math1.MathOp("7"));
        }
    }
}
