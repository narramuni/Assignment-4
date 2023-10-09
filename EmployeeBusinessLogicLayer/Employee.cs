using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentone
{
    public class Employee : Student
    {
        private int _Empid;

        public int Empid
        {
            get { return _Empid; }
            set { _Empid = value; }
        }

        private string _Ename;

        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

        private double _Salary;

        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }


        public Employee(int studid, string studname, int age, int empid, string ename, double salary) : base(studid, studname, age)
        {
            Empid = empid;
            Ename = ename;
            Salary = salary;
        }

        public double CalculateSalary()
        {
            double hra, da, specialAllowance;
            if (Salary > 10000 && Salary < 20000)
            {
                hra = 0.10 * Salary;
                da = 0.05 * Salary;
                specialAllowance = 0.10 * Salary;
            }
            else if (Salary > 20000 && Salary < 30000)
            {

                hra = 0.12 * Salary;
                da = 0.07 * Salary;
                specialAllowance = 0.12 * Salary;


            }

            else
            {
                hra = 0;
                da = 0;
                specialAllowance = 0;
            }

            double totalSalary = Salary + hra + da + specialAllowance;
            return totalSalary;
        }



    }
}
