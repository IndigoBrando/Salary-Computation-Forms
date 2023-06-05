using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation_Forms
{
    class PersonalInformation
    {
        private string name;
        private string address;
        private string city;
        private string zipCode;
        private string phoneNo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
    }
}
