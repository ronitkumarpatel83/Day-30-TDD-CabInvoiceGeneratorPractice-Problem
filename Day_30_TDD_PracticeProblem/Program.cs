﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject;

namespace Day_30_TDD_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Console.WriteLine(invoiceGenerator.CalculateFare(5, 6));
            Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            Console.ReadLine();
        }
    }
}
