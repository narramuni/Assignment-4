using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentone
{
    public class Student
    {
        private int _Studid;

        public int Studid
        {
            get { return _Studid; }
            set { _Studid = value; }
        }

        private string _Studname;

        public string Studname
        {
            get { return _Studname; }
            set { _Studname = value; }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }


        private double _Maths;

        public double Maths
        {
            get { return _Maths; }
            set { _Maths = value; }
        }

        private double _Science;

        public double Science
        {
            get { return _Science; }
            set { _Science = value; }
        }

        private double _English;

        public double English
        {
            get { return _English; }
            set { _English = value; }
        }


        public Student(int studid, string studname)
        {
            Studid = studid;
            Studname = studname;
            Age = 0;
            Maths = 0;
            Science = 0;
            English = 0;
        }

        public Student(int studid, string studname, int age)
        {
            Studid = studid;
            Studname = studname;
            Age = 0;
            Maths = 0;
            Science = 0;
            English = 0;

        }

        public double Calculate()
        {
            return Maths + Science + English;
        }




    }
}
