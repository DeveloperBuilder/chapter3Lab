using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Microsoft Visual Studio C# Express edition, create a console application that declares two int values and perform the following operations on these numbers:
            // 1.Display the numbers
            // 2.Add the numbers and display the sum of the values
            // 3.Calculate the average and display
            // 4.Calculate the percentage on ons number by another and display
            // 5.Convert the numbers to char values and display
            int a = 122;
            int b = 10;
            int c = a + b;
            double d = ((double) a + (double) b) / 2;
            double e = ((double) a * (double) b) / 100;
            char f = (char)a;
            Console.WriteLine(a + "\n" + b);    // Display the numbers
            Console.WriteLine(c);               // Add the numbers and display the sum of the values
            Console.WriteLine(d);               // Calculate the average and display
            Console.WriteLine(e);               // Calculate the percentage on ons number by another and display
            Console.WriteLine(f);               // Convert the numbers to char values and display
            Console.ReadLine();
        }
    }
}
