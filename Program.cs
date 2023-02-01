using System;

namespace Emp_Wage_Comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program");

            Random random= new Random();
            int ran=random.Next(0,2);

            if(ran == 0 )
            {
                Console.WriteLine("Employee is present" );

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
