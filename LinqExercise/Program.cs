using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"The sum of all the numbers is {sum}");
            var average = numbers.Average();
            Console.WriteLine();
            Console.WriteLine($"The average of all the numbers is {average}");
            Console.WriteLine();

            //Order numbers in ascending order and decsending order. Print each to console.
            Console.WriteLine("Numbers Descending:");
            var descending = numbers.OrderByDescending(x => x).ToList();
            descending.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Numbers Ascending:");
            var ascending = numbers.OrderBy(x => x).ToList();
            ascending.ForEach(x => Console.WriteLine(x));


            //Print to the console only the numbers greater than 6
            Console.WriteLine();
            Console.WriteLine("Numbers greater than six");
            var greaterThanSix = numbers.Where(x => x > 6).ToList();
            greaterThanSix.ForEach(x => Console.WriteLine(x));

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine();
            Console.WriteLine("Only four numbers:");
            foreach (var item in ascending)
            {
                if (item <= 4)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
            //Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("My age at index 4");
            ascending[4] = 22;
            ascending.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("---------------------------");
            Console.WriteLine("Employee");
            Console.WriteLine("---------------------------");
            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            var cOrS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).ToList();
            cOrS.ForEach(x => Console.WriteLine(x.FullName));
            //Order this in acesnding order by FirstName.
            Console.WriteLine();
            Console.WriteLine("Ordered by First Name:");
            Console.WriteLine();
            var ascendingcORS = cOrS.OrderBy(x => x.FirstName).ToList();
            ascendingcORS.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            Console.WriteLine("Employees older than 26");
            //Print all the employees' FullName and Age who are over the age 26 to the console.
            var over26 = employees.Where(x => x.Age > 26).ToList();
            over26.ForEach(x => Console.WriteLine(x.FullName, x.Age));
            //Order this by Age first and then by FirstName in the same result.
            var orderedByAge = over26.OrderBy(x => x.Age);           //can't order by int and by string
            var orderedByFirst = over26.OrderBy(x => x.FirstName);             //TODO order in the same result

            //Print the Sum and then the Average of the employees' YearsOfExperience
            var sumEmployess = employees.Sum(x => x.YearsOfExperience);
            var averageEmployees = employees.Average(x => x.YearsOfExperience);
            Console.WriteLine();
            Console.WriteLine($"Sum of employees years of experience is {sumEmployess}. Average of employees years of experience is {averageEmployees}");
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var last = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            Console.WriteLine();
            Console.WriteLine("List of employees who's YOE <= 10 and Age is > 35:");
            last.ForEach(x => Console.WriteLine(x.FullName));
            //Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee());
            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
