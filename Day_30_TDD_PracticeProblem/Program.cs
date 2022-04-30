using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_30_TDD_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Console.WriteLine(invoiceGenerator.CalculateFare(5, 6));
            Console.ReadLine();
        }
    }
}
