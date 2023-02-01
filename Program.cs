using System;

namespace Emp_Wage_Comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program");

            Random random = new Random();
            int Dailywage = 0;
            int HalfDayHour = 4;
            int FullDayHour = 8;
            int PerHour = 20;
            int ran = random.Next(0, 3);

            switch (ran)
            {
                case 0:
                Console.WriteLine("Employee is Absent");
                    break;

                case 1:  
                Dailywage=PerHour*HalfDayHour; 
                Console.WriteLine("Employee is present Half day and his wage is: " +Dailywage);
                    break;
            
                    case 2:
                Dailywage = PerHour * FullDayHour;
                Console.WriteLine("Employee is present full day and his wage is: " + Dailywage);
                    break;
            }
        }
    }
}
