using System;

namespace Emp_Wage_Comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program");

            Random random= new Random();
            int Dailywage = 0;
            int FullDayHour = 8;
            int PerHour = 20;
            int ran=random.Next(0,2);

            if(ran == 0 )
            {
                Console.WriteLine("Employee is Absent" );

            }
            else
            {
                Dailywage = PerHour * FullDayHour;
                Console.WriteLine("Employee is present and his wage is: " + Dailywage);
            }
        }
    }
}
