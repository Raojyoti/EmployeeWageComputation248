using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //constants
            const int EMP_PER_HRS = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WORKING_DAYS = 20;
            Console.WriteLine("Welcome to the Employee Wage Computation");

            //UC5- Calculating Wages  for a Month

            Random random = new Random();
            for(int day = 0; day <= WORKING_DAYS; day++) 
            {
                int empAttendence = random.Next(0, 3);//0,1,2
                switch (empAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Employee is Full Time Present");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Employee is Part Time Present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empWage = empHrs * EMP_PER_HRS;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee Wage is : " + empWage);
            }
            Console.WriteLine("Total Employee Wages are : " + totalEmpWage);
            Console.ReadLine();
        }
    }
}
