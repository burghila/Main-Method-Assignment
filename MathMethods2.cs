using System;

namespace MainMethodAssignment
{
    public class MathMethods2
    {
        // Adds 7 to the input integer and returns the result.
        public int MathOp(int number)
        {
            return number + 7;
        }

        // Converts the input decimal to an integer, multiplies it by 20, and returns the result.
        public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }

        // Converts the input string to an integer, calculates the remainder of division by 3, and returns the result.
        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}
