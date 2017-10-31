using System;

namespace ConditionalDemo
{
    class Program
    {
        static void Main()
        {
            #region Simple

            bool condition = true;
            if (condition)
            {
                // then
                Console.WriteLine("Condition is true");
            }
            else
            {
                Console.WriteLine("Condition is false");
            }

            #endregion

            #region Middle

            bool condition1 = true, 
                 condition2 = false;
            if (condition1)
            {
                if (condition2)
                    Console.WriteLine("Do smth");
                Console.WriteLine("and another operator");
            }
            else
                Console.WriteLine("Do smth else");

            #endregion

            #region Bad practice

            if (condition)
                if (condition1)
                    if (condition2)
                        Console.WriteLine("Very rare event!");

            #endregion

            #region Good practice

            if (condition && condition1 && condition2)
                Console.WriteLine("Very rare event!");

            #endregion

            #region Ternary statement vs conditional statement

            int baseValue = 11;
            int derivedValue = (baseValue > 0) ? baseValue * 2 :  -baseValue;

            int anotherValue;
            if (baseValue > 0)
                anotherValue = baseValue * 2;
            else
                anotherValue = -baseValue;

            #endregion
        }
    }
}
