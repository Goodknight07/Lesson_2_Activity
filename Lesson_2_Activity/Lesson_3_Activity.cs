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
    public partial class Lesson_3_Activity : Form
    {
        public Lesson_3_Activity()
        {
            InitializeComponent();
        }

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
            int lec_units, Cred_units;
            int lab_units;

            lec_units = Convert.ToInt32(Lecunitstxtbox1.Text);
            lab_units = Convert.ToInt32(Labunitstxtbox1.Text);
            Cred_units = (lec_units + lab_units);
            Creditunitstxtbox1.Text = Cred_units.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Labunitstxtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lesson_3_Activity_Load(object sender, EventArgs e)
        {
          
        }

        private void Credunitstxtbox2_TextChanged(object sender, EventArgs e)
        {
            int lec_units, Cred_units;
            int lab_units;

            lec_units = Convert.ToInt32(Lecunitstxtbox2.Text);
            lab_units = Convert.ToInt32(Labunitstxtbox2.Text);
            Cred_units = (lec_units + lab_units);
            Creditunitstxtbox2.Text = Cred_units.ToString();
        }

        private void Credunitstxtbox3_TextChanged(object sender, EventArgs e)
        {
            int lec_units, Cred_units;
            int lab_units;

            lec_units = Convert.ToInt32(Lecunitstxtbox3.Text);
            lab_units = Convert.ToInt32(Labunitstxtbox3.Text);
            Cred_units = (lec_units + lab_units);
            Creditunitstxtbox3.Text = Cred_units.ToString();
        }

        private void Credunitstxtbox4_TextChanged(object sender, EventArgs e)
        {
            int lec_units, Cred_units;
            int lab_units;

            lec_units = Convert.ToInt32(Lecunitstxtbox4.Text);
            lab_units = Convert.ToInt32(Labunitstxtbox4.Text);
            Cred_units = (lec_units + lab_units);
            Creditunitstxtbox4.Text = Cred_units.ToString();
        }

        private void Creditunitstxtbox5_TextChanged(object sender, EventArgs e)
        {
            int lec_units, Cred_units;
            int lab_units;

            lec_units = Convert.ToInt32(Lecunitstxtbox5.Text);
            lab_units = Convert.ToInt32(Labunitstxtbox5.Text);
            Cred_units = (lec_units + lab_units);
            Creditunitstxtbox5.Text = Cred_units.ToString();
        }
    }
}
