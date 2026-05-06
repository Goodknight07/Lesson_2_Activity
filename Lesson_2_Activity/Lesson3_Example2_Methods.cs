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
    public partial class Lesson3_Example2_Methods : Form
    {
        int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;
        double qty = 0, 
            price = 0, 
            discount_amt = 0, 
            discounted_amt = 0, 
            cash_rendered = 0, 
            change = 0;
        public Lesson3_Example2_Methods()
        {
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
           qty = Convert.ToInt32(qtytxtbox.Text);
           price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        public void price_item_TextValue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }
        private void Lesson3_Example2_Methods_Load(object sender, EventArgs e)
        {
            //sitemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            name1LBL.Text = "Burger Steak w/Drink";
            name2LBL.Text = "CJ, BS, Spag w/Drink";
            name3LBL.Text = "1pc ChickenJoy";
            name4LBL.Text = "1pc CJ w/CokeFloat";
            name5LBL.Text = "1pc Cj w/Drink";
            name6LBL.Text = "Chicken Spag";
            name7LBL.Text = "Chicken Spag w/Drink";
            name8LBL.Text = "Chicken Palabok";
            name9LBL.Text = "Bacon Cheeseburger";
            name10LBL.Text = "Double CB, Fries w/Drink";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                withdiscRBTN.Checked = false;
                employeediscRBTN.Checked = false;
                nodiscountRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
               quantityTxtbox();
            }
        }

        private void withdiscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();

                seniorcitizenRBTN.Checked = false;
                employeediscRBTN.Checked = false;
                nodiscountRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void employeediscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                computation_Formula_and_DisplayData();

                seniorcitizenRBTN.Checked = false;
                withdiscRBTN.Checked = false;
                nodiscountRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void nodiscountRBTN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                discount_amt = (qty * price) * 0;
                computation_Formula_and_DisplayData();   
                seniorcitizenRBTN.Checked = false;
                withdiscRBTN.Checked = false;
                employeediscRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;

            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(cash_renderedtxtbox.Text);

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cash_renderedtxtbox.Text = cash_rendered.ToString("n");
            }

            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cash_renderedtxtbox.Clear();
                cash_renderedtxtbox.Focus();
            }
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            qtytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 4;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 5;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += ".";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "89.50");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name2LBL.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name3LBL.Text, "100.50");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           price_item_TextValue(name4LBL.Text, "111.50");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name5LBL.Text, "120.50");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6LBL.Text, "90.50");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7LBL.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8LBL.Text, "123.50");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9LBL.Text, "188.00");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10LBL.Text, "680.50");
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11LBL.Text, "199.50");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12LBL.Text, "99.50");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13LBL.Text, "190.50");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14LBL.Text, "121.50");
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15LBL.Text, "599.50");
            quantityTxtbox();
        }

        private void cash_renderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16LBL.Text, "91.50");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name17LBL.Text, "81.50");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18LBL.Text, "71.50");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19LBL.Text, "211.50");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11LBL.Text, "576.00");
            quantityTxtbox();
        }
    }
}
