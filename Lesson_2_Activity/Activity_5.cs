using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2_Activity
{
    public partial class Activity_5 : Form
    {
        private double basic_numhrs = 0.00,
             basic_rate = 0.00,
             basic_netincome = 0.00,
             hono_netincome = 0.00,
             hono_numhrs = 0.00,
             hono_rate = 0.00,
             other_netincome = 0.00,
             other_numhrs = 0.00,
             other_rate = 0.00;
        private double netincome = 0.00,
            grossincome = 0.00;
        private void Hono_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(Hono_CutoffTxtbox.Text);
            hono_rate = Convert.ToDouble(Hono_RateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            
        }

        private void TotalDeductionTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basic_RateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            EmployeeNoTxtbox.Clear();
            DepartmentTxtbox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            CivilstatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            Basic_IncomepercutoffTxtbox.Clear();
            Basic_RateTxtbox.Clear();
            Basic_CutoffTxtbox.Clear();
            Hono_CutoffTxtbox.Clear();
            Hono_RateTxtbox.Clear();
            Hono_totalpayTxtbox.Clear();
            Other_totalpayTxtbox.Clear();
            Other_RateTxtbox.Clear();
            Other_CutoffTxtbox.Clear();
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Clear();
            SSS_ContribTxtbox.Clear();
            Pagibig_ContribTxtbox.Clear();
            PhilHealth_ContribTxtbox.Clear();
            TaxtTxtbox.Clear();
            SSS_loanTxtbox.Clear();
            Pagibig_LoanTxtbox.Clear();
            QDSTxtbox.Clear();
            PaydateTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            FirstnameTxtbox.Clear();

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            grossincome = basic_netincome + hono_netincome + other_netincome;
            GrossIncomeTxtbox.Text = grossincome.ToString("n");
            Basic_IncomepercutoffTxtbox.Text = basic_netincome.ToString("n");
            Hono_totalpayTxtbox.Text = hono_netincome.ToString("n");
            Other_totalpayTxtbox.Text = other_netincome.ToString("n");
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void PhilHealth_ContribTxtbox_TextChanged(object sender, EventArgs e)
        {
            //philhealth contribution based from the current table
            if (grossincome <= 10000)
            {
                PhilHealth_ContribTxtbox.Text = "137.50";
            }
            else if (grossincome > 10000 && grossincome <= 11000)
            {
                PhilHealth_ContribTxtbox.Text = "151.25";
            }

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void Other_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(Other_CutoffTxtbox.Text);
            other_rate = Convert.ToDouble(Other_RateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
           
        }

        private void Basic_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = double.Parse(Basic_CutoffTxtbox.Text);
            basic_rate = Convert.ToDouble(Basic_RateTxtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            
        }

        public Activity_5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeNoTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Activity_5_Load(object sender, EventArgs e)
        {

        }
    }
}
