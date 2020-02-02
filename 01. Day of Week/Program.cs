﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {

        static void Main()
        {
            string dateText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}