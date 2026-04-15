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
    public partial class ACTIVITY : Form
    {
        public ACTIVITY()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ACTIVITY_Load(object sender, EventArgs e)
        {
            ItemnameTxtbox.Enabled = false;
            PriceTxtbox.Enabled = false;
            DiscountedTxtbox.Enabled = false;
            Qty_totalTxtbox.Enabled = false;
            Discounted_totalTxtbox.Enabled = false;
            Discount_totalTxtbox.Enabled = false;
            ChangeTxtbox.Enabled = false;

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
            pictureBox16.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image16.jpg");
            pictureBox17.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image17.jpg");
            pictureBox18.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image18.jpg");
            pictureBox19.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image19.jpg");
            pictureBox20.Image = Image.FromFile(@"C:\Users\C203-21.C203-21\source\repos\ERNEST_CPE201\Images\Image20.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 1";
            PriceTxtbox.Text = "150.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 2";
            PriceTxtbox.Text = "180.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 3";
            PriceTxtbox.Text = "200.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 4";
            PriceTxtbox.Text = "250.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 5";
            PriceTxtbox.Text = "300.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 6";
            PriceTxtbox.Text = "320.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 7";
            PriceTxtbox.Text = "350.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 8";
            PriceTxtbox.Text = "399.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 9";
            PriceTxtbox.Text = "420.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 10";
            PriceTxtbox.Text = "450.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 11";
            PriceTxtbox.Text = "450.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 12";
            PriceTxtbox.Text = "250.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 13";
            PriceTxtbox.Text = "180.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 14";
            PriceTxtbox.Text = "230.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 15";
            PriceTxtbox.Text = "240.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 16";
            PriceTxtbox.Text = "310.59";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 17";
            PriceTxtbox.Text = "320.69";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 18";
            PriceTxtbox.Text = "145.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 19";
            PriceTxtbox.Text = "360.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            ItemnameTxtbox.Text = "Burger 20";
            PriceTxtbox.Text = "365.00";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
