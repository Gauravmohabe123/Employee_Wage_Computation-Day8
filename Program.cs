using System;

namespace Emp_Wage_Comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program");

            Random random = new Random();
            int Day = 0;
            int totalday = 0;
            int fullDayPresent = 0;
            int halfDayPresent = 0;
            int absent = 0;
            int Dailywage = 0;
            int HalfDayHour = 4;
            int FullDayHour = 8;
            int PerHour = 20;
            int TotalHour = 0;
            for (int i = 0; i < Day && TotalHour <= 100; i++)
            {
                int ran = random.Next(0, 3);

            

            switch (ran)
            {
                case 0:                    
                    absent++;

                    break;

                case 1:
                    Dailywage = PerHour * HalfDayHour;
                    TotalHour += Dailywage;
                    halfDayPresent++;
                    TotalHour = TotalHour + HalfDayHour;

                    break;

                case 2:
                    Dailywage = PerHour * FullDayHour;
                    TotalHour += Dailywage;
                    fullDayPresent++;
                    TotalHour = TotalHour + FullDayHour;
                    break;
            }
                Console.WriteLine("Employee absent in a month " + absent);
                Console.WriteLine("Employee half day present in  month " + halfDayPresent);
                Console.WriteLine("Employee full day present in  month " + fullDayPresent);
                Console.WriteLine("Employee total wage " + TotalHour);
                Console.WriteLine("Employee present in a month " + (halfDayPresent + fullDayPresent));

            }
        }
    }
}
