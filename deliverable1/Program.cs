﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2, value3, adverage, largest, smallest, totalUSD, totalYen, totalKr, totalBaht;

            Console.WriteLine("Please enter USD amount 1.");
            Console.Write("$");
            double.TryParse(Console.ReadLine(), out value1);

            Console.WriteLine("Please enter USD amount 2.");
            Console.Write("$");
            double.TryParse(Console.ReadLine(), out value2);

            Console.WriteLine("Please enter USD amount 3.");
            Console.Write("$");
            double.TryParse(Console.ReadLine(), out value3);

            adverage = adv(value1, value2, value3);
            largest = BIG(value1, value2, value3);
            smallest = Small(value1, value2, value3);
            totalUSD = Total(value1, value2, value3);
            totalYen = Yen(totalUSD);
            totalKr = Kr(totalUSD);
            totalBaht = Baht(totalUSD);


            Console.WriteLine();

            Console.WriteLine("Adverage amount = $" + adverage);
            Console.WriteLine("Smallest amount = $" + smallest);
            Console.WriteLine("Largest amount = $" + largest);

            Console.WriteLine();

            Console.WriteLine("Total value in USD = $" + totalUSD);
            Console.WriteLine("Total in Japanaise Yen = " + totalYen + " Yen");
            Console.WriteLine("Total in Swedish Krona = " + totalKr + " Kr");
            Console.WriteLine("Total in Thai Baht = " + totalBaht + " Baht");

            Console.ReadKey();
        }
        private static double adv(double x, double y, double z)
        {
            double adverage = (x + y + z) / 3;
            adverage = Math.Round(adverage, 2);
            return adverage;
        }
        private static double BIG(double x, double y, double z)
        {
            double BIG;
            if (x > y)
            {
                BIG = x;
            }
            else
            {
                BIG = y;
            }
            if (BIG > z)
            {
                return Math.Round(BIG, 2);
            }
            else
            {
                return Math.Round(z, 2);
            }
        }
        private static double Small(double x, double y, double z)
        {
            double small;
            if (x < y)
            {
                small = x;
            }
            else
            {
                small = y;
            }
            if (small < z)
            {
                return Math.Round(small, 2);
            }
            else
            {
                return Math.Round(z, 2);
            }
        }
        private static double Total(double x, double y, double z)
        {
            double usd;
            usd = x + y + z;
            return Math.Round(usd, 2);
        }
        private static double Yen(double usd)
        {
            return Math.Round((usd * 109.36), 0);
        }
        private static double Kr(double usd)
        {
            return Math.Round((usd * 9.59), 2);
        }
        private static double Baht(double usd)
        {
            return Math.Round((usd * 31.83), 2);
        }
    }
}