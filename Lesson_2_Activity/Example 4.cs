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
    public partial class Example_4 : Form
    {
        //declaration of variables
        private double amount_paid, pricel, label, cash_given, change;
        private int quantity;

        public Example_4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 2";
            Pricetxtbox.Text = "180.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 3";
            Pricetxtbox.Text = "200.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 4";
            Pricetxtbox.Text = "300.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 5";
            Pricetxtbox.Text = "300.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 6";
            Pricetxtbox.Text = "320.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 7";
            Pricetxtbox.Text = "350.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 8";
            Pricetxtbox.Text = "399.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 9";
            Pricetxtbox.Text = "420.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 10";
            Pricetxtbox.Text = "450.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 11";
            Pricetxtbox.Text = "450.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 12";
            Pricetxtbox.Text = "250.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 13";
            Pricetxtbox.Text = "180.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 14";
            Pricetxtbox.Text = "230.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            ItemnameTxtbox.Text = "Burger 15";
            Pricetxtbox.Text = "240.00";
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            pricel = Convert.ToDouble(Pricetxtbox.Text);
            quantity = Convert.ToInt32(QtyTxtbox.Text);
            amount_paid = pricel * quantity;
            AmountPaidTxtbox.Text = amount_paid.ToString("n");
            CashgivenTxtbox.Focus();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Clear();
            AmountPaidTxtbox.Clear();
            CashgivenTxtbox.Clear();
            ChangeTxtbox.Clear();
        }

        private void Pricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Focus();
            QtyTxtbox.Clear();
            ItemnameTxtbox.Text = "Burger 1";
            Pricetxtbox.Text = "150.00";
        }

        private void Example_4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image1.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image2.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image3.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image4.jpg");
            pictureBox5.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image5.jpg");
            pictureBox6.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image6.jpg");
            pictureBox7.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image7.jpg");
            pictureBox8.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image8.jpg");
            pictureBox9.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image9.jpg");
            pictureBox10.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image10.jpg");
            pictureBox11.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image11.jpg");
            pictureBox12.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image12.jpg");
            pictureBox13.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image13.jpg");
            pictureBox14.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image14.jpg");
            pictureBox15.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image15.jpg");

            ChangeTxtbox.Enabled = false;
     

        }
    }
}
