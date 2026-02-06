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
    public partial class Activity_2_form : Form
    {
        public Activity_2_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void Activity_2_form_Load(object sender, EventArgs e)
        {
            ProgramBox.Items.Add("Computer Engineering");
            ProgramBox.Items.Add("Civil Engineering");
            ProgramBox.Items.Add("Electrical Engineering");
            ProgramBox.Items.Add("Industrial Engineering");
            ProgramBox.Items.Add("Electrical Engineering");
            ProgramBox.Items.Add("Electronics Communication Engineering");
            ProgramBox.Items.Add("Aeronautical Engineering");
            ProgramBox.Items.Add("Mechanical Engineering");
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StudentNameTxtbox.Clear();
            StudentNumberTxtbox.Clear();
            YearlvlTxtbox.Clear(); 
            ScholarTxtbox.Clear();
     
        }

        private void CourseNumListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CourseDescListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UnitLecListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UnitLabListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CreditUnitListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TimeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DayListbox.Items.Add(DayTxtbox);
            TimeListbox.Items.Add(TimeTxtbox);
            CreditUnitListbox.Items.Add(CreditUnitTxtBox);
            UnitLabListbox.Items.Add(UnitLabTxtbox);
            UnitLecListbox.Items.Add(UnitLecTxtbox);
            CourseDescListbox.Items.Add(CourseDescTxtbox);
            CourseCodeListbox.Items.Add(CourseCodeTxtbox);
            CourseCodeListbox.Items.Add(CourseCodeTxtbox);

        }

        private void CourseCodeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
