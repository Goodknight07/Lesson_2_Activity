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
    public partial class Example_5 : Form
    {
        //declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            phihealth_contrib = 0.00,
            tax_contrib = 0.00;

        private void NewBtn_Click(object sender, EventArgs e)
        {
            EmployeeNoTxtbox.Clear();
            FirstnameTxtBox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            CivilstatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            NumbersofDependentTxtbox.Clear();
            EmployeestatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
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

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; *.png; *.bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Basic_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = double.Parse(Basic_CutoffTxtbox.Text);
            basic_rate = Convert.ToDouble(Basic_RateTxtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            Basic_IncomepercutoffTxtbox.Text = basic_netincome.ToString("n");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            EmployeeNoTxtbox.Clear();
            FirstnameTxtBox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            CivilstatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            NumbersofDependentTxtbox.Clear();
            EmployeestatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
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
        }

        private void Other_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(Other_CutoffTxtbox.Text);
            other_rate = Convert.ToDouble(Other_RateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            Other_totalpayTxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            GrossIncomeTxtbox.Text = grossincome.ToString("n");
            Pagibig_ContribTxtbox.Text = "200.00";
        }

        private void SSS_ContribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basic_RateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Other_totalpayTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrossIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Example_5_PrintFrm print1 = new Example_5_PrintFrm();
            print1.PrintDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            print1.Show();

        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            //payslip_viewlistbox.items.add("");
            payslip_viewListBox.Items.Add("Employee Number: " + " " + EmployeeNoTxtbox.Text);
            payslip_viewListBox.Items.Add("Firstname: " + " " + FirstnameTxtBox.Text);
            payslip_viewListBox.Items.Add("Middlename: " + " " + MiddlenameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname: " + " " + SurnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Designation: " + " " + DesignationTxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + " " + EmployeestatusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department: " + " " + DepartmentTxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + " " + Paydatepicker.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + "P" + Basic_CutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr: " + "P" + Basic_RateTxtbox.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income: " + "P" + Basic_IncomepercutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + "P" + Hono_CutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr: " + "P" + Hono_RateTxtbox.Text);
            payslip_viewListBox.Items.Add("Honorarium Income: " + "P" + Hono_totalpayTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + "P" + Other_CutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr: " + "P" + Other_RateTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Income: " + "P" + Other_totalpayTxtbox.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + " " + SSS_ContribTxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution: " + " " + PhilHealth_ContribTxtbox.Text);
            payslip_viewListBox.Items.Add("Pagibig Contribution: " + " " + Pagibig_ContribTxtbox.Text);
            payslip_viewListBox.Items.Add("Tax Contribution: " + " " + TaxtTxtbox.Text);
            payslip_viewListBox.Items.Add("SSS Loan: " + " " + SSS_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Pagibig Loan: " + " " + Pagibig_LoanTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + " " + Faculty_savingsdepositTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + " " + Faculty_savingsloanTxtbox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + " " + SalaryloanTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + " " + others_loanComboTxtbox.Text);
            payslip_viewListBox.Items.Add("--------------------------------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + " " + TotalDeductionTxtbox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + " " + GrossIncomeTxtbox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + " " + NetIncomeTxtbox.Text);








        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //codes for converting input data from textbox as string to numeric
            //codes for putting data from textboxes to variables
            //sss_contrib = Convert.ToDouble(SSS_ContribTxtbox.Text);
            //pagibig_contrib = Convert.ToDouble(Pagibig_ContribTxtbox.Text);
            //phihealth_contrib = Convert.ToDouble(PhilHealth_ContribTxtbox.Text);
            //tax_contrib = Convert.ToDouble(TaxtTxtbox.Text);
            //sss_loan = Convert.ToDouble(SSS_loanTxtbox.Text);
            //pagibig_loan = Convert.ToDouble(Pagibig_LoanTxtbox.Text);
            //salary_loan = Convert.ToDouble(SalaryloanTxtbox.Text);
            //faculty_sav_loan = Convert.ToDouble(Faculty_savingsloanTxtbox.Text);
           // salary_savings = Convert.ToDouble(Faculty_savingsdepositTxtbox.Text);
            //other_deduction = Convert.ToDouble(others_loanComboTxtbox.Text);
            //formula to compute the desired data to be computed
            //total_contrib = sss_contrib + pagibig_contrib + phihealth_contrib + tax_contrib;
            //total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
           // total_deduction = total_contrib + total_loan;
            //code for converting numeric data to string and displayed it inside the textboxes
            //TotalDeductionTxtbox.Text = total_deduction.ToString("n");
           // netincome = grossincome - total_deduction;
            //NetIncomeTxtbox.Text = netincome.ToString("n");

            try
            {
                sss_contrib = Convert.ToDouble(SSS_ContribTxtbox.Text);
                pagibig_contrib = Convert.ToDouble(Pagibig_ContribTxtbox.Text);
                phihealth_contrib = Convert.ToDouble(PhilHealth_ContribTxtbox.Text);
                tax_contrib = Convert.ToDouble(TaxtTxtbox.Text);
                sss_loan = Convert.ToDouble(SSS_loanTxtbox.Text);
                pagibig_loan = Convert.ToDouble(Pagibig_LoanTxtbox.Text);
                salary_loan = Convert.ToDouble(SalaryloanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(Faculty_savingsloanTxtbox.Text);
                salary_savings = Convert.ToDouble(Faculty_savingsdepositTxtbox.Text);
                other_deduction = Convert.ToDouble(others_loanComboTxtbox.Text);
             
                total_contrib = sss_contrib + pagibig_contrib + phihealth_contrib + tax_contrib;
                total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
                total_deduction = total_contrib + total_loan;
              
                TotalDeductionTxtbox.Text = total_deduction.ToString("n");
                netincome = grossincome - total_deduction;
                NetIncomeTxtbox.Text = netincome.ToString("n");
            }
            catch(Exception)
            {
                MessageBox.Show("Enter Valid Data!");
                SSS_ContribTxtbox.Focus();
                Pagibig_ContribTxtbox.Focus();
                PhilHealth_ContribTxtbox.Focus();
                TaxtTxtbox.Focus();
                SSS_loanTxtbox.Focus();
                Pagibig_LoanTxtbox.Focus();
                SalaryloanTxtbox.Focus();
                Faculty_savingsloanTxtbox.Focus();
                Faculty_savingsdepositTxtbox.Focus();
                others_loanComboTxtbox.Focus();
            }

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(Hono_CutoffTxtbox.Text);
            hono_rate = Convert.ToDouble(Hono_RateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            Hono_totalpayTxtbox.Text = hono_netincome.ToString("n");
        }

        private double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;






        public Example_5()
        {
            InitializeComponent();
        }

        private void Example_5_Load(object sender, EventArgs e)
        {
            //code for disabling
            Basic_IncomepercutoffTxtbox.Enabled = false;
            Hono_totalpayTxtbox.Enabled = false;
            Other_totalpayTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            GrossIncomeTxtbox.Enabled = false;
            TotalDeductionTxtbox.Enabled = false;
            SSS_ContribTxtbox.Text = "0.00";
            Pagibig_ContribTxtbox.Text = "0.00";
            PhilHealth_ContribTxtbox.Text = "0.00";
            others_loanComboTxtbox.Text = "0.00";
            TaxtTxtbox.Text = "0.00";
            SSS_loanTxtbox.Text = "0.00";
            Pagibig_LoanTxtbox.Text = "0.00";
            Faculty_savingsdepositTxtbox.Text = "0.00";
            Faculty_savingsloanTxtbox.Text = "0.00";
            SalaryloanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();




        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
