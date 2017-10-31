﻿using System;

namespace InputOutputDemo
{
    class Program
    {
        static void Main()
        {
            #region Input and error check

            Console.Write("number = ");
            string userInput = Console.ReadLine();
            int number;
            bool isInt = int.TryParse(userInput, out number);
            if (!isInt)
            {
                Console.WriteLine("Error!");
                return;
            }

            #endregion

            #region Output

            Console.WriteLine("number + 1 = {0}", number + 1);

            #endregion
        }
    }
}
