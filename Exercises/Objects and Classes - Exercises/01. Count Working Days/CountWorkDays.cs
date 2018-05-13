﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._Count_Working_Days
{
    class CountWorkDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int countWorkingDays = 0;
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2016, 1, 1));
            holidays.Add(new DateTime(2016, 3, 3));
            holidays.Add(new DateTime(2016, 5, 1));
            holidays.Add(new DateTime(2016, 5, 6));
            holidays.Add(new DateTime(2016, 5, 24));
            holidays.Add(new DateTime(2016, 9, 6));
            holidays.Add(new DateTime(2016, 9, 22));
            holidays.Add(new DateTime(2016, 11, 1));
            holidays.Add(new DateTime(2016, 12, 24));
            holidays.Add(new DateTime(2016, 12, 25));
            holidays.Add(new DateTime(2016, 12, 26));

            for (var currDate = startDate; currDate <= endDate; currDate = currDate.AddDays(1))
            {
                if (!holidays.Any(d => d.Day == currDate.Day && d.Month == currDate.Month)
                    && !currDate.DayOfWeek.Equals(DayOfWeek.Saturday)
                    && !currDate.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    countWorkingDays++;
                }
            }
            Console.WriteLine(countWorkingDays);
        }
    }
}
