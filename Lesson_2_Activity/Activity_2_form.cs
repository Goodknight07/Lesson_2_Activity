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
            CourseNumListbox.Items.Clear();
            CourseCodeListbox.Items.Clear();
            CourseDescListbox.Items.Clear();
            UnitLecListbox.Items.Clear();
            UnitLabListbox.Items.Clear();
            CreditUnitListbox.Items.Clear();
            TimeListbox.Items.Clear();
            DayListbox.Items.Clear();
            CourseNumTxtbox.Clear();
            CourseCodeTxtbox.Clear();
            CourseDescTxtbox.Clear();
            UnitLecTxtbox.Clear();
            UnitLabTxtbox.Clear();
            TimeTxtbox.Clear();
            DayTxtbox.Clear();
            CreditUnitTxtBox.Clear();
           
            





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
            DayListbox.Items.Add(DayTxtbox.Text);
            TimeListbox.Items.Add(TimeTxtbox.Text);
            CreditUnitListbox.Items.Add(CreditUnitTxtBox.Text);
            UnitLabListbox.Items.Add(UnitLabTxtbox.Text);
            UnitLecListbox.Items.Add(UnitLecTxtbox.Text);
            CourseDescListbox.Items.Add(CourseDescTxtbox.Text);
            CourseCodeListbox.Items.Add(CourseCodeTxtbox.Text);
            CourseNumListbox.Items.Add (CourseNumTxtbox.Text);

        }

        private void CourseCodeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateEnrolledPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
