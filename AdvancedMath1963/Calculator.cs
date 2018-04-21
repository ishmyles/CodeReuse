using System;

namespace AdvancedMath1963
{
    public class Calculator
    {
        public static int Factorial (int input)
        {
            int sum = input;

            for (int i = input; i != 1; i--)
            {
                sum *= (i - 1);
            }

            return sum;

            #region RecursiveMethod Solution
            //if (input <= 1)
            //    return 1;
            //return input * Factorial(input - 1);
            #endregion
        }
    }
}
