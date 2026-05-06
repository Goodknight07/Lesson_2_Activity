using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2_Activity
{
    public partial class Lesson3_Example2_Class : Form
    {
        public Lesson3_Example2_Class()
        {
            InitializeComponent();
        }

        Price_Item_Value price_Item_Value = new Price_Item_Value();
        Variable variables = new Variable();
        private double qty = 0,
            price = 0;

        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
        }

        private void GetPriceItemValue()
        {
            itemnametxtbox.Text = (price_Item_Value.GetItemName());
            pricetextbox.Text = (price_Item_Value.GetPrice());
        }

        private void quantityTxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(qtytxtbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        private void Lesson3_Example2_Class_Load(object sender, EventArgs e)
        {
        
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                variables.quantity = Convert.ToInt32(qtytxtbox.Text);
                variables.discount_amt = Convert.ToDouble(discounttxtbox.Text);
                variables.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                variables.cash_given = Convert.ToDouble(cash_renderedtxtbox.Text);

                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;
                variables.change = variables.cash_given - variables.discounted_amt;

                qty_totaltxtbox.Text = variables.qty_total.ToString();
                discount_totaltxtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = variables.discounted_total.ToString("n");
                changetxtbox.Text = variables.change.ToString("n");
                cash_renderedtxtbox.Text = variables.cash_given.ToString("n");
            }
            catch 
            {
                MessageBox.Show("Invalid Data Input!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Combo Mea A", "89.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name1LBL.Text", "101.50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name2LBL.Text", "100.50");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name3LBL.Text", "111.50");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name4LBL.Text", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name5LBL.Text", "90.50");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name6LBL.Text", "101.50");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name7LBL.Text", "123.50");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name8LBL.Text", "188.50");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name9LBL.Text", "680.50");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name10LBL.Text", "199.50");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name11LBL.Text", "99.50");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name12LBL.Text", "190.50");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name13LBL.Text", "121.50");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name14LBL.Text", "599.50");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name15LBL.Text", "576.00");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name16LBL.Text", "91.50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name17LBL.Text", "81.50");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name18LBL.Text", "71.50");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("name19LBL.Text", "211.50");
            GetPriceItemValue();
        }

        private void withdiscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.10;
            computation_Formula_and_DisplayData();
            seniorcitizenRBTN.Checked = false;
            employeediscRBTN.Checked = false;
            nodiscountRBTN.Checked = false;
        }

        private void employeediscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.15;
            computation_Formula_and_DisplayData();
            seniorcitizenRBTN.Checked = false;
            withdiscRBTN.Checked = false;
            nodiscountRBTN.Checked= false;
        }

        private void nodiscountRBTN_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0;
            computation_Formula_and_DisplayData();
            seniorcitizenRBTN.Checked = false;
            withdiscRBTN.Checked = false;
            employeediscRBTN.Checked = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
                computation_Formula_and_DisplayData();
                nodiscountRBTN.Checked = false;
                employeediscRBTN.Checked = false;
                withdiscRBTN.Checked = false;     
            }
            catch 
            {
                MessageBox.Show("Invalid Input Data!");
            }
        }
    }
}
