using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main()
        {
            // --- for loop

            #region Dummy for-loop demo

            // let a sum is 1 + 2 + 3 + ... + n where n = 100;
            int n = 100;
            int sum = 0;
            for (int element = 1; element <= n; element = element + 1)
                sum = sum + element;

            #endregion

            sum = 0;
            int current = n;
            for (; current >= 1; current--)
                sum += current;

            #region Increment demo

            // let we have i = 1, j
            int i = 1;
            int j = i++; // j = i; i = i + 1;

            i = 1;
            j = ++i;     // i = i + 1; j = i;

            j = (i = i + 1);

            #endregion

            #region Strange for-loop demo

            int total = 0;
            for (int z = 0; z < n; z++)
                total += z * (z + 1);

            #endregion

            #region Middle

            int m = 200;
            for (int k = 0; k < n || k * 10 < m; ++k)
                Console.WriteLine(k);

            #endregion

            #region Crazy

            for (int index1 = 0, index2 = n; index1 < n && index2 > m; index1++, index2--) ; // Alarm! It's empty statement!

            #endregion

            // --- while loop
            bool continuationCondition = true;
            while (continuationCondition)
            {
                // body
            }

            // --- do-while loop
            
            do { /* body */ } while (continuationCondition);

            // --- foreach

        }
    }
}
