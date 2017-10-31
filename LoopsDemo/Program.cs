using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    class Program
    {
        static void Main()
        {
            #region Dummy for-loop demo

            // let a sum is 1 + 2 + 3 + ... + n where n = 10;
            int n = 100;
            int sum = 0;
            for (int element = 1; element <= n; element = element + 1)
                sum = sum + element;

            #endregion

            #region Increment demo

            // let we have i = 1, j
            int i = 1;
            int j = i++;

            i = 1;
            j = ++i;

            #endregion

            #region Strange for-loop demo

            int total = 0;
            for (int i = 0; i < n; i++)
                total += i * (i + 1);

            #endregion

            #region Middle

            int m = 200;
            for (int k = 0; k < n || k * 10 < m; ++k)
                Console.WriteLine(k);

            #endregion

            #region Crazy

            for (int index1 = 0, index2 = n; index1 < n && index2 > m; index1++, index2--) ; // Alarm! It's empty statement!

            #endregion
        }
    }
}
