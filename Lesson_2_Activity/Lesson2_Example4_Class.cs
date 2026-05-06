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
    public partial class Lesson2_Example4_Class : Form
    {
        public Lesson2_Example4_Class()
        {
            InitializeComponent();
        }

        Price_Item_Value price_item_value = new Price_Item_Value();
        Variable variables = new Variable();

        private void GetPriceItemValue()
        {
            ItemnameTxtbox.Text = (price_item_value.GetItemName());
            PriceTxtbox.Text = (price_item_value.GetPrice());
        }

        private void quantityTxtbox()
        {
            QtyTxtbox.Clear();
            QtyTxtbox.Focus();
        }

        private void Lesson2_Example4_Class_Load(object sender, EventArgs e)
        {
            
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                variables.amount_paid = Convert.ToDouble(AmountPaidTxtbox.Text);
                variables.cash_given = Convert.ToDouble(CashgivenTxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                ChangeTxtbox.Text = variables.change.ToString("C");
                AmountPaidTxtbox.Text = variables.amount_paid.ToString("C");
                CashgivenTxtbox.Text = variables.cash_given.ToString("c");
            }
            catch 
            {
                MessageBox.Show("Invalid Input Data!");
            }



        }

        private void AmountPaidTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                variables.price = Convert.ToDouble(PriceTxtbox.Text);
                variables.quantity = Convert.ToInt32(QtyTxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;
                AmountPaidTxtbox.Text = variables.amount_paid.ToString("n");
                CashgivenTxtbox.Focus();
            }
            catch 
            {
                MessageBox.Show("Invalid Input Data!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal A", "90.50");
            GetPriceItemValue();
            quantityTxtbox();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal B", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal C", "88.50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal D", "100.50");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal 1", "95.00");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal 2", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal 3", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal 4", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Combo A", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Budget A", "110");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Solo A", "190.50");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Double A", "220.50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Couple A", "100.99");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Friend A", "129.70");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal Combo D", "220.50");
            GetPriceItemValue();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
