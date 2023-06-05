using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation_Forms
{
    class ComputeSalary
    {
        private int empdID;
        private double rate;
        private int hours;
        private double salary;

        public int EmpId
        {
            get { return empdID; }
            set { empdID = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
