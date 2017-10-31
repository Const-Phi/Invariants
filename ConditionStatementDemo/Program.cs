using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatementDemo
{
    class Program
    {
        static void Main()
        {
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
        }
    }
}
