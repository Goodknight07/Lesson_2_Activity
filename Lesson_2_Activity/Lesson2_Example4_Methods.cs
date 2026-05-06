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
    public partial class Lesson2_Example4_Methods : Form
    {
        private double amount_paid, price, cash_given, change;
        private int quantity;
        public Lesson2_Example4_Methods()
        {
            InitializeComponent();
        }

      
        private void displayTxtbox(string itemname, string price)
        {
            ItemnameTxtbox.Text = itemname;
            PriceTxtbox.Text = price;
        }

        private void quantityTxbox()
        {
            QtyTxtbox.Clear();
            QtyTxtbox.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lesson2_Example4_Methods_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //accessing the function, name as quantityTxbox
            displayTxtbox("Meal A", "90.50");
            //pricetxtbox.text = "90.50";
            //itemnametxtbox.text = "Meal A";
            quantityTxbox();
            //qtytxtbox.clear();
            //qtytxtbox.focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal B", "120.50");
            quantityTxbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal C", "88.50");
            quantityTxbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal D", "100.50");
            quantityTxbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 1", "95.00");
            quantityTxbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 2", "120.50");
            quantityTxbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 3", "120.50");
            quantityTxbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 4", "120.50");
            quantityTxbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo A", "120.50");
            quantityTxbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Budget A", "110");
            quantityTxbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Solo A", "190.50");
            quantityTxbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Double A", "220.50");
            quantityTxbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Couple A", "100.99");
            quantityTxbox();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            QtyTxtbox.Clear();
            AmountPaidTxtbox.Clear();
            CashgivenTxtbox.Clear();
            ChangeTxtbox.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CashgivenTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Friend A", "129.70");
            quantityTxbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo D", "220.50");
            quantityTxbox();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(PriceTxtbox.Text);
            quantity = Convert.ToInt32(QtyTxtbox.Text);
            amount_paid = price * quantity;
            AmountPaidTxtbox.Text = amount_paid.ToString("n");
            CashgivenTxtbox.Focus();
            change = Convert.ToDouble(CashgivenTxtbox.Text) - amount_paid;
            ChangeTxtbox.Text = change.ToString("n");
        }
    }
}
