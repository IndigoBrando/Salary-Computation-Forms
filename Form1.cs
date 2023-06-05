using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Computation_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplayinfo_Click(object sender, EventArgs e)
        {
            
                PersonalInformation objPersonal = new PersonalInformation();
                objPersonal.Name = textBoxName.Text;
                objPersonal.Address = textBoxAdd.Text;
                objPersonal.City = textBoxCity.Text;
                objPersonal.ZipCode = textBoxZip.Text;
                objPersonal.PhoneNumber = textBoxPhoneNumber.Text;

                listBoxInfo.Items.Add("Hi " + objPersonal.Name);
                listBoxInfo.Items.Add("Your Address is " + objPersonal.Address);
                listBoxInfo.Items.Add("You live in the city of " + objPersonal.City);
                listBoxInfo.Items.Add("Your zip code is " + objPersonal.ZipCode);
                listBoxInfo.Items.Add("Your phone number " + objPersonal.PhoneNumber);
            
          
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            try
            {
                ComputeSalary objSalary = new ComputeSalary();
                objSalary.EmpId = Convert.ToInt32(textBoxId.Text);
                objSalary.Rate = Convert.ToDouble(textBoxRate.Text);
                objSalary.Hours = Convert.ToInt32(textBoxHours.Text);

                Deductions objDeduct = new Deductions();
                objDeduct.SSS = Convert.ToDouble(textBoxSSS.Text);
                objDeduct.Pagibig = Convert.ToDouble(textBoxPagibig.Text);
                objDeduct.Philhealth = Convert.ToDouble(textBoxPhilhealth.Text);
                objDeduct.Absences = Convert.ToInt32(textBoxAbsences.Text);

                objSalary.Salary = (objSalary.Hours * objSalary.Rate) - (objDeduct.SSS + objDeduct.Philhealth + objDeduct.Pagibig) - (objDeduct.Absences * objSalary.Rate);
                listBoxSalaryInfo.Items.Add("Employee ID " + objSalary.EmpId.ToString());
                listBoxSalaryInfo.Items.Add("The salary of Employee is \n" + objSalary.Salary.ToString("C"));
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxAbsences.Clear();
            textBoxHours.Clear();
            textBoxPagibig.Clear();
            textBoxId.Clear();
            textBoxPhilhealth.Clear();
            textBoxRate.Clear();
            textBoxSSS.Clear();
           
            listBoxSalaryInfo.Items.Clear();
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            textBoxAdd.Clear();
            textBoxCity.Clear();
            textBoxName.Clear();
            textBoxZip.Clear();
            textBoxPhoneNumber.Clear();
            listBoxInfo.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
