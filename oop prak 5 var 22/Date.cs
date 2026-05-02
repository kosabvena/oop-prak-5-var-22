using System;

namespace oop_prak_5_var_22
{
    internal class Date
    {
        private int year, month, day;

        public int Year
        {
            set
            {
                if (value > 0)
                    year = value;
                else
                    Console.WriteLine("Рік має бути додатнім");
            }
        }

        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    Console.WriteLine("Місяць має бути від 1 до 12");
            }
        }

        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    Console.WriteLine("Некоректний день");
            }
        }

        private bool IsLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public bool IsValid()
        {
            if (month < 1 || month > 12) return false;

            int[] daysInMonth = {
                31,
                IsLeapYear() ? 29 : 28,
                31, 30, 31, 30,
                31, 31, 30, 31, 30, 31
            };

            return day >= 1 && day <= daysInMonth[month - 1];
        }

        public void Plus1()
        {
            int[] daysInMonth = {
                31,
                IsLeapYear() ? 29 : 28,
                31, 30, 31, 30,
                31, 31, 30, 31, 30, 31
            };

            day++;

            if (day > daysInMonth[month - 1])
            {
                day = 1;
                month++;

                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"{day:D2}.{month:D2}.{year}");
        }
    }
}