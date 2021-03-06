using System;
using System.Collections.Generic;
using System.Linq;

namespace SofthillsTech
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            try
            {
            // Take in Position and Rating
            IDictionary<string, int> PositionRating = new Dictionary<string, int>();
            
            Console.WriteLine("Enter the number(N) of Positions: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if(N>=1 && N<=100)
            {
            for (int i = 0; i < N; i++)
            {
            Console.WriteLine("Enter the Position-Rating: ");
            string positionRat = Console.ReadLine();
            var positionRating = positionRat.Split("-", 2);
            PositionRating.Add(positionRating[0], Convert.ToInt32(positionRating[1]));
            }
            }else{
                Console.WriteLine("Input number is out of range");
                break;
            }

            // Take in Employee Details
            ICollection<Employee> employees = new List<Employee>();
            
            Console.WriteLine("Enter the number(M) of Employees: ");
            int M = Convert.ToInt32(Console.ReadLine());

            if(M>=1 && M<=100)
            {
            for (int i = 0; i < M; i++)
            {
            Console.WriteLine("Enter the Employee's name(firstName lastName)- Position: ");
            string namePosition = Console.ReadLine();
             
            var employeeInfo = namePosition.Split("-", 2);
            var firstLastN = employeeInfo[0].Split(" ", 2);
            Employee newEmployee = new Employee(firstLastN[0], firstLastN[1], employeeInfo[1]);
            employees.Add(newEmployee);
            }
            }else{
                Console.WriteLine("Input number is out of range");
                break;
            }

            // Print out Employee Details

            foreach (var employee in employees.OrderBy(e=>e.FirstName).OrderBy(e=>e.LastName).OrderByDescending(e=>PositionRating[e.Position]))
            {
                Console.WriteLine(employee);
            }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }

            }

        }
    }
}
