using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            try
            {
                other_numhrs = Convert.ToDouble(Other_CutoffTxtbox.Text);
                other_rate = Convert.ToDouble(Other_RateTxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                Other_totalpayTxtbox.Text = other_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                GrossIncomeTxtbox.Text = grossincome.ToString("n");
                Pagibig_ContribTxtbox.Text = "100.00";

                if (grossincome > 10000)
                {
                    PhilHealth_ContribTxtbox.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    PhilHealth_ContribTxtbox.Text = "151.25";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    PhilHealth_ContribTxtbox.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    PhilHealth_ContribTxtbox.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    PhilHealth_ContribTxtbox.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    PhilHealth_ContribTxtbox.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    PhilHealth_ContribTxtbox.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    PhilHealth_ContribTxtbox.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    PhilHealth_ContribTxtbox.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    PhilHealth_ContribTxtbox.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    PhilHealth_ContribTxtbox.Text = "275.00";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    PhilHealth_ContribTxtbox.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    PhilHealth_ContribTxtbox.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    PhilHealth_ContribTxtbox.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    PhilHealth_ContribTxtbox.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    PhilHealth_ContribTxtbox.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    PhilHealth_ContribTxtbox.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    PhilHealth_ContribTxtbox.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    PhilHealth_ContribTxtbox.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    PhilHealth_ContribTxtbox.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    PhilHealth_ContribTxtbox.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    PhilHealth_ContribTxtbox.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    PhilHealth_ContribTxtbox.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    PhilHealth_ContribTxtbox.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    PhilHealth_ContribTxtbox.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    PhilHealth_ContribTxtbox.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    PhilHealth_ContribTxtbox.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    PhilHealth_ContribTxtbox.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    PhilHealth_ContribTxtbox.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    PhilHealth_ContribTxtbox.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 3999.99)
                {
                    PhilHealth_ContribTxtbox.Text = "543.13";
                }
                else

                    PhilHealth_ContribTxtbox.Text = "550.00";

                if (grossincome < 1000)
                {
                    SSS_ContribTxtbox.Text = "0.00";
                }
                else if (grossincome > 1000 && grossincome <= 1249.99)
                {
                    SSS_ContribTxtbox.Text = "36.30";
                }
                else if (grossincome > 1250 && grossincome <= 1749.99)
                {
                    SSS_ContribTxtbox.Text = "54.50";
                }
                else if (grossincome > 1750 && grossincome <= 2249.99)
                {
                    SSS_ContribTxtbox.Text = "72.70";
                }
                else if (grossincome > 2250 && grossincome <= 2749.99)
                {
                    SSS_ContribTxtbox.Text = "90.80";
                }
                else if (grossincome > 2750 && grossincome <= 3249.99)
                {
                    SSS_ContribTxtbox.Text = "109.00";
                }
                else if (grossincome > 3250 && grossincome <= 3749.99)
                {
                    SSS_ContribTxtbox.Text = "127.20";
                }
                else if (grossincome > 3750 && grossincome <= 4249.99)
                {
                    SSS_ContribTxtbox.Text = "145.30";
                }
                else if (grossincome > 4250 && grossincome <= 4749.99)
                {
                    SSS_ContribTxtbox.Text = "163.50";
                }
                else if (grossincome > 4750 && grossincome <= 5249.99)
                {
                    SSS_ContribTxtbox.Text = "181.70";
                }
                else if (grossincome > 5250 && grossincome <= 5749.99)
                {
                    SSS_ContribTxtbox.Text = "199.80";
                }
                else if (grossincome > 5750 && grossincome <= 6249.99)
                {
                    SSS_ContribTxtbox.Text = "218.00";
                }
                else if (grossincome > 6250 && grossincome <= 6749.99)
                {
                    SSS_ContribTxtbox.Text = "236.20";
                }
                else if (grossincome > 6750 && grossincome <= 7249.99)
                {
                    SSS_ContribTxtbox.Text = "254.30";
                }
                else if (grossincome > 7250 && grossincome <= 7749.99)
                {
                    SSS_ContribTxtbox.Text = "272.50";
                }
                else if (grossincome > 7750 && grossincome <= 8249.99)
                {
                    SSS_ContribTxtbox.Text = "290.70";
                }
                else if (grossincome > 8250 && grossincome <= 8749.99)
                {
                    SSS_ContribTxtbox.Text = "308.80";
                }
                else if (grossincome > 8750 && grossincome <= 9249.99)
                {
                    SSS_ContribTxtbox.Text = "327.00";
                }
                else if (grossincome > 9250 && grossincome <= 9749.99)
                {
                    SSS_ContribTxtbox.Text = "345.20";
                }
                else if (grossincome > 9750 && grossincome <= 10249.99)
                {
                    SSS_ContribTxtbox.Text = "363.30";
                }
                else if (grossincome > 10250 && grossincome <= 10749.99)
                {
                    SSS_ContribTxtbox.Text = "381.50";
                }
                else if (grossincome > 10750 && grossincome <= 11249.99)
                {
                    SSS_ContribTxtbox.Text = "399.70";
                }
                else if (grossincome > 11250 && grossincome <= 11749.99)
                {
                    SSS_ContribTxtbox.Text = "417.80";
                }
                else if (grossincome > 11750 && grossincome <= 12249.99)
                {
                    SSS_ContribTxtbox.Text = "436.00";
                }
                else if (grossincome > 12250 && grossincome <= 12749.99)
                {
                    SSS_ContribTxtbox.Text = "454.20";
                }
                else if (grossincome > 12750 && grossincome <= 13249.99)
                {
                    SSS_ContribTxtbox.Text = "472.30";
                }
                else if (grossincome > 13250 && grossincome <= 13749.99)
                {
                    SSS_ContribTxtbox.Text = "490.50";
                }
                else if (grossincome > 13750 && grossincome <= 14249.99)
                {
                    SSS_ContribTxtbox.Text = "508.70";
                }
                else if (grossincome > 14250 && grossincome <= 14749.99)
                {
                    SSS_ContribTxtbox.Text = "526.80";
                }
                else if (grossincome > 14750 && grossincome <= 15249.99)
                {
                    SSS_ContribTxtbox.Text = "545.00";
                }
                else if (grossincome > 15250 && grossincome <= 15749.99)
                {
                    SSS_ContribTxtbox.Text = "563.20";
                }
                else
                    SSS_ContribTxtbox.Text = "581.30";

                if (grossincome < (250000 / 24))
                {
                    TaxtTxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax_contrib = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    TaxtTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax_contrib = (((((grossincome * 24) - 400000) * 0.25) + 30000) / 24);
                    TaxtTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax_contrib = (((((grossincome * 24) - 800000) * 0.30) + 130000) / 24);
                    TaxtTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    tax_contrib = (((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24);
                    TaxtTxtbox.Text = tax_contrib.ToString("n");
                }
                else
                {
                    tax_contrib = (((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    TaxtTxtbox.Text = tax_contrib.ToString("n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data entry");
                Other_CutoffTxtbox.Clear();
                Other_CutoffTxtbox.Focus();
            }
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

        private void Basic_IncomepercutoffTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void others_loanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(others_loanCombo.Text == "Other 1")
            {
                others_loanComboTxtbox.Text = "500.00";
            }
            else if(others_loanCombo.Text == "Other 2")
            {
                others_loanComboTxtbox.Text = "550.00";
            }
            else if (others_loanCombo.Text == "Other 3")
            {
                others_loanComboTxtbox.Text = "1550.00";
            }
            else if (others_loanCombo.Text == "Other 4")
            {
                others_loanComboTxtbox.Text = "1250.00";
            }
        }

        private void TaxtTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalDeductionTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pagibig_ContribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void others_loanComboTxtbox_TextChanged(object sender, EventArgs e)
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
