using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IExpensiveOperation  expensiveOperation = new ExpensiveOperationProxy();

            Console.WriteLine(expensiveOperation.PerformOperation(5));

            Console.WriteLine(expensiveOperation.PerformOperation(5));

            Console.WriteLine(expensiveOperation.PerformOperation(5));

            Console.WriteLine(expensiveOperation.PerformOperation(5));

            Console.WriteLine(expensiveOperation.PerformOperation(5));
            Console.ReadLine();
        }
    }
}
