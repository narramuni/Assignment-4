using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentone
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student(100, "Jhon", 10);


            //Console.WriteLine(  "Enter StudentID:");
            //student.Studid = Convert.ToInt32(Console.ReadLine());

            student.Maths = 96;
            student.Science = 96;
            student.English = 92;

            double totalMarks = student.Calculate();
            Console.WriteLine($"Student: {student.Studname}, Total Marks:{totalMarks}");


            Employee employee = new Employee(1001, "Jon", 24, 2001, "HR", 22000);

            double  totalSalary = employee.CalculateSalary();

            Console.WriteLine($"Employee:{employee.Ename}, Total Salary: {totalSalary}"  );

            Console.Read();


        }
    }
}
