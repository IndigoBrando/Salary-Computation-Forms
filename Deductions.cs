using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation_Forms
{
    class Deductions
    {
        private double sss;
        private double philhealth;
        private double pagibig;
        private int absences;

        public double SSS
        {
            get { return sss; }
            set { sss = value; }
        }

        public double Philhealth
        {
            get { return philhealth; }
            set { philhealth = value; }
        }

        public double Pagibig
        {
            get { return pagibig; }
            set {pagibig = value; }
        }

        public int Absences
        {
            get { return absences; }
            set { absences = value; }
        }




    }
}
