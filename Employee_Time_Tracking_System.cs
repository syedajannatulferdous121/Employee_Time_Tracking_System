using System;

namespace EmployeeTimeTrackingSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee Time Tracking System");
            Console.WriteLine("-------------------------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your position: ");
            string position = Console.ReadLine();

            var employee = new Employee(name, position);

            Console.WriteLine();
            Console.WriteLine("Employee: " + employee.Name);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Current Date and Time (German Time Zone): " + DateTime.Now.ToUniversalTime().AddHours(2));

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Employee Time Tracking System!");
        }
    }
}
