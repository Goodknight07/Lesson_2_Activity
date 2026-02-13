using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson_2_Activity
{
    public partial class Lesson_3_Activity : Form
    {
        public Lesson_3_Activity()
        {
            InitializeComponent();
        }

        double Complabfee = 0;
        double SAPfee = 2000;
        double CISCOlabfee = 4500;
        double Exambookletfee = 450;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateEnrolledPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProgramBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentNumberTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //i.
            double total_lecunits = Convert.ToInt32(Lecunitstxtbox1.Text) + Convert.ToInt32(Lecunitstxtbox2.Text) + Convert.ToInt32(Lecunitstxtbox3.Text) + Convert.ToInt32(Lecunitstxtbox4.Text) + Convert.ToInt32(Lecunitstxtbox5.Text) + Convert.ToInt32(Lecunitstxtbox6.Text) + Convert.ToInt32(Lecunitstxtbox7.Text);
            double totalTuition = Convert.ToInt32(totalunitstxtbox.Text) * 1500;
            textBox22.Text = totalTuition.ToString();

            //j.
            double total_labunits = Convert.ToInt32(Labunitstxtbox1.Text) + Convert.ToInt32(Labunitstxtbox2.Text) + Convert.ToInt32(Labunitstxtbox3.Text) + Convert.ToInt32(Labunitstxtbox4.Text) + Convert.ToInt32(Labunitstxtbox5.Text) + Convert.ToInt32(Labunitstxtbox6.Text) + Convert.ToInt32(Labunitstxtbox7.Text);
            Complabfee = total_labunits * 2500;
            double totalMisc = Complabfee + SAPfee + CISCOlabfee + Exambookletfee;
            ComlabF.Text = Complabfee.ToString();
            textBox6.Text = totalMisc.ToString();
            textBox28.Text = totalMisc.ToString();
           

            //k
            Complabfee = (Convert.ToDouble(Labunitstxtbox1.Text) + Convert.ToDouble(Labunitstxtbox2.Text) + Convert.ToDouble(Labunitstxtbox3.Text) + Convert.ToDouble(Labunitstxtbox4.Text) + Convert.ToDouble(Labunitstxtbox5.Text) + Convert.ToDouble(Labunitstxtbox6.Text) + Convert.ToDouble(Labunitstxtbox7.Text)) * 2500;

            double total_tuition_and_fees = totalTuition + totalMisc;
            textBox24.Text = total_tuition_and_fees.ToString();


            double installment_fee = (total_tuition_and_fees - 8000) / 3;
            textBox165.Text = installment_fee.ToString("C");
            textBox164.Text = installment_fee.ToString("C");
            textBox163.Text = installment_fee.ToString("C");



        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox167_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {
           
        }

        private void Credunitstxtbox1_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Labunitstxtbox1_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox1.Text != "" && Labunitstxtbox1.Text != "")
            {
                Creditunitstxtbox1.Text = (Convert.ToInt32(Lecunitstxtbox1.Text) + Convert.ToInt32(Labunitstxtbox1.Text)).ToString();
            }
        }

        private void Lesson_3_Activity_Load(object sender, EventArgs e)
        {
            YearLvl.Items.Add("1st Year");
            YearLvl.Items.Add("2nd Year");
            YearLvl.Items.Add("3rd Year");
            YearLvl.Items.Add("4th Year");

            Scholar.Items.Add("No");
            Scholar.Items.Add("Mayor Scholarship");
            Scholar.Items.Add("Academic Scholarship");

            // 2 a. question
            ProgramBox.Items.Add("BS Information Technology");
            ProgramBox.Items.Add("BS Computer Engineering");
            ProgramBox.Items.Add("BS Computer Science");
            ProgramBox.Items.Add("BS Electrical Engineering");
            ProgramBox.Items.Add("BS Mechanical Engineering");
            ProgramBox.Items.Add("BS Industrial Engineering");


            // m.
            Modeofpaymenttxtbox.Text = "Installment";
            Downpaymenttxtbox.Text = "8000";

            //fees
            ComlabF.Text = Complabfee.ToString();
            SapF.Text = SAPfee.ToString();
            CiscolabF.Text = CISCOlabfee.ToString();
            ExambookletF.Text = Exambookletfee.ToString();

            ModecomboBox.Items.Add("Installment");
        }

        private void Credunitstxtbox2_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        private void Credunitstxtbox3_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        private void Credunitstxtbox4_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        private void Creditunitstxtbox5_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        // 2b.
        private void Lecunitstxtbox1_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox1.Text != "" && Labunitstxtbox1.Text != "")
            {
                Creditunitstxtbox1.Text = (Convert.ToInt32(Lecunitstxtbox1.Text) + Convert.ToInt32(Labunitstxtbox1.Text)).ToString();
            }
        }

        private void Lecunitstxtbox2_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox2.Text != "" && Labunitstxtbox2.Text != "")
            {
                Creditunitstxtbox2.Text = (Convert.ToInt32(Lecunitstxtbox2.Text) + Convert.ToInt32(Labunitstxtbox2.Text)).ToString();
            }
        }

        private void Labunitstxtbox2_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox2.Text != "" && Labunitstxtbox2.Text != "")
            {
                Creditunitstxtbox2.Text = (Convert.ToInt32(Lecunitstxtbox2.Text) + Convert.ToInt32(Labunitstxtbox2.Text)).ToString();
            }
        }

        private void Lecunitstxtbox3_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox3.Text != "" && Labunitstxtbox3.Text != "")
            {
                Creditunitstxtbox3.Text = (Convert.ToInt32(Lecunitstxtbox3.Text) + Convert.ToInt32(Labunitstxtbox3.Text)).ToString();
            }
        }

        private void Labunitstxtbox3_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox3.Text != "" && Labunitstxtbox3.Text != "")
            {
                Creditunitstxtbox3.Text = (Convert.ToInt32(Lecunitstxtbox3.Text) + Convert.ToInt32(Labunitstxtbox3.Text)).ToString();
            }
        }

        private void Lecunitstxtbox4_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox4.Text != "" && Labunitstxtbox4.Text != "")
            {
                Creditunitstxtbox4.Text = (Convert.ToInt32(Lecunitstxtbox4.Text) + Convert.ToInt32(Labunitstxtbox4.Text)).ToString();
            }
        }

        private void Labunitstxtbox4_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox4.Text != "" && Labunitstxtbox4.Text != "")
            {
                Creditunitstxtbox4.Text = (Convert.ToInt32(Lecunitstxtbox4.Text) + Convert.ToInt32(Labunitstxtbox4.Text)).ToString();
            }
        }

        private void Lecunitstxtbox5_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox5.Text != "" && Labunitstxtbox5.Text != "")
            {
                Creditunitstxtbox5.Text = (Convert.ToInt32(Lecunitstxtbox5.Text) + Convert.ToInt32(Labunitstxtbox5.Text)).ToString();
            }
        }

        private void Labunitstxtbox5_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox5.Text != "" && Labunitstxtbox5.Text != "")
            {
                Creditunitstxtbox5.Text = (Convert.ToInt32(Lecunitstxtbox5.Text) + Convert.ToInt32(Labunitstxtbox5.Text)).ToString();
            }
        }

        private void Lecunitstxtbox6_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox6.Text != "" && Labunitstxtbox6.Text != "")
            {
                Creditunitstxtbox6.Text = (Convert.ToInt32(Lecunitstxtbox6.Text) + Convert.ToInt32(Labunitstxtbox6.Text)).ToString();
            }
        }

        private void Labunitstxtbox6_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox6.Text != "" && Labunitstxtbox6.Text != "")
            {
                Creditunitstxtbox6.Text = (Convert.ToInt32(Lecunitstxtbox6.Text) + Convert.ToInt32(Labunitstxtbox6.Text)).ToString();
            }
        }

        private void Lecunitstxtbox7_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox7.Text != "" && Labunitstxtbox7.Text != "")
            {
                Creditunitstxtbox7.Text = (Convert.ToInt32(Lecunitstxtbox7.Text) + Convert.ToInt32(Labunitstxtbox7.Text)).ToString();
            }
        }

        private void Labunitstxtbox7_TextChanged(object sender, EventArgs e)
        {
            if (Lecunitstxtbox7.Text != "" && Labunitstxtbox7.Text != "")
            {
                Creditunitstxtbox7.Text = (Convert.ToInt32(Lecunitstxtbox7.Text) + Convert.ToInt32(Labunitstxtbox7.Text)).ToString();
            }
        }

        private void Creditunitstxtbox6_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        private void Creditunitstxtbox7_TextChanged(object sender, EventArgs e)
        {
            if (Creditunitstxtbox1.Text != "" && Creditunitstxtbox2.Text != "" && Creditunitstxtbox3.Text != "" && Creditunitstxtbox4.Text != "" && Creditunitstxtbox5.Text != "" && Creditunitstxtbox6.Text != "" && Creditunitstxtbox7.Text != "")
            {
                totalunitstxtbox.Text = (Convert.ToInt32(Creditunitstxtbox1.Text) + Convert.ToInt32(Creditunitstxtbox2.Text) + Convert.ToInt32(Creditunitstxtbox3.Text) + Convert.ToInt32(Creditunitstxtbox4.Text) + Convert.ToInt32(Creditunitstxtbox5.Text) + Convert.ToInt32(Creditunitstxtbox6.Text) + Convert.ToInt32(Creditunitstxtbox7.Text)).ToString();
            }
        }

        private void Scholar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 2C.
            StudentNameTxtbox.Clear();
            StudentNumberTxtbox.Clear();
        }

        private void clrsched_Click(object sender, EventArgs e)
        {
            //2d.
            Coursecodetxtbox1.Clear();
            Coursecodetxtbox2.Clear();
            Coursecodetxtbox3.Clear();
            Coursecodetxtbox4.Clear();
            Coursecodetxtbox5.Clear();
            Coursecodetxtbox6.Clear();
            Coursecodetxtbox7.Clear();

            Sectiontxtbox1.Clear();
            Sectiontxtbox2.Clear();
            Sectiontxtbox3.Clear();
            Sectiontxtbox4.Clear();
            Sectiontxtbox5.Clear();
            Sectiontxtbox6.Clear();
            Sectiontxtbox7.Clear();

            DescriptionTxtbox1.Clear();
            DescriptionTxtbox2.Clear();
            DescriptionTxtbox3.Clear();
            DescriptionTxtbox4.Clear();
            DescriptionTxtbox5.Clear();
            DescriptionTxtbox6.Clear();
            DescriptionTxtbox7.Clear();

            Lecunitstxtbox1.Clear();
            Lecunitstxtbox2.Clear();
            Lecunitstxtbox3.Clear();
            Lecunitstxtbox4.Clear();
            Lecunitstxtbox5.Clear();
            Lecunitstxtbox6.Clear();
            Lecunitstxtbox7.Clear();

            Labunitstxtbox1.Clear();
            Labunitstxtbox2.Clear();
            Labunitstxtbox3.Clear();
            Labunitstxtbox4.Clear();
            Labunitstxtbox5.Clear();
            Labunitstxtbox6.Clear();
            Labunitstxtbox7.Clear();

            Creditunitstxtbox1.Clear();
            Creditunitstxtbox2.Clear();
            Creditunitstxtbox3.Clear();
            Creditunitstxtbox4.Clear();
            Creditunitstxtbox5.Clear();
            Creditunitstxtbox6.Clear();
            Creditunitstxtbox7.Clear();

            timetxtbox1.Clear();
            timetxtbox2.Clear();
            timetxtbox3.Clear();
            timetxtbox4.Clear();
            timetxtbox5.Clear();
            timetxtbox6.Clear();
            timetxtbox7.Clear();

            Daytxtbox1.Clear();
            Daytxtbox2.Clear();
            Daytxtbox3.Clear();
            Daytxtbox4.Clear();
            Daytxtbox5.Clear();
            Daytxtbox6.Clear();
            Daytxtbox7.Clear();

            Roomtxtbox1.Clear();
            Roomtxtbox2.Clear();
            Roomtxtbox3.Clear();
            Roomtxtbox4.Clear();
            Roomtxtbox5.Clear();
            Roomtxtbox6.Clear();
            Roomtxtbox7.Clear();

            totalunitstxtbox.Clear();


        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComlabF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
