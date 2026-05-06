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
    public partial class Lesson4_Example3_Class : Form
    {
        Variable variables = new Variable();
        Price_Item_Value price_discountamount_value = new Price_Item_Value();

        private double total_amount = 0;
        private int total_qty = 0;

        public Lesson4_Example3_Class()
        {
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void foodradiobtn()
        {
            FoodBundleA_RB.Checked = false;
            FoodBundleB_RB.Checked = false;
        }

        public void item_priceValue(string discount_amount, string price)
        {
            DiscountTxtbox.Text = discount_amount;
            PriceTxtbox.Text = price;
        }
        private void GetPriceDiscountAmount()
        {
            PriceTxtbox.Text = (price_discountamount_value.GetPriceItem());
            DiscountTxtbox.Text = (price_discountamount_value.GetDiscountAmount());
            variables.price = Convert.ToDouble(PriceTxtbox.Text);
        }
        private void Lesson4_Example3_Class_Load(object sender, EventArgs e)
        {
            PriceTxtbox.Enabled = false;
            DiscountedTxtbox.Enabled = false;
            ChangeTxtbox.Enabled = false;
            TotalBillsTxtbox.Enabled = false;
            DiscountTxtbox.Enabled = false;
            TotalQtyTxtbox.Enabled = false;

            A_BucketfriesBox.Enabled = false;
            A_ChickenBox.Enabled = false;
            A_DeluxeburgerBox.Enabled = false;
            A_Icedteabox.Enabled = false;
            A_SidedishBox.Enabled = false;
            B_chickenBox.Enabled = false;
            B_HalohaloBox.Enabled = false;
            B_LargefriesBox.Enabled = false;
            B_SDeluxeburgerbox.Enabled = false;
            B_SpaghettiBox.Enabled = false;
        }

        private void Burger1CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "500.00");
            quantityTxtbox();
            DisplayListbox.Items.Add(Burger1CB.Text + " " + PriceTxtbox.Text);
        }

        private void Burger2CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "550.00");
            quantityTxtbox();
        }

        private void Burger3CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "600.99");
            quantityTxtbox();
        }

        private void Burger4CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "700.50");
            quantityTxtbox();
        }

        private void Burger5CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "500.00");
            quantityTxtbox();
        }

        private void Burger6CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "750.00");
            quantityTxtbox();
        }

        private void Burger7CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "700.00");
            quantityTxtbox();
        }

        private void Burger8CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "850.00");
            quantityTxtbox();
        }

        private void Burger9CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "450.00");
            quantityTxtbox();
        }

        private void Burger10CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "650.00");
            quantityTxtbox();
        }

        private void Burger11CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger12CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger13CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger14CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger15CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger16CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger17CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger18CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger19CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void Burger20CB_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            try
            {
                cash_given = Convert.ToDouble(CashGivenTxtbox.Text);
                total_amountPaid = Convert.ToDouble(TotalBillsTxtbox.Text);
                change = cash_given - total_amountPaid;
                ChangeTxtbox.Text = change.ToString("n");
                DisplayListbox.Items.Add("Total Bills: " + " " + TotalBillsTxtbox.Text);
                DisplayListbox.Items.Add("Cash Given: " + " " + CashGivenTxtbox.Text);
                DisplayListbox.Items.Add("Total No. of Items: " + " " + TotalQtyTxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                CashGivenTxtbox.Clear();
                CashGivenTxtbox.Focus();
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            //code to uncheck all given checkboxes
            FoodBundleA_RB.Checked = false;
            FoodBundleB_RB.Checked = false;

            //code for inserting default image inside the picturebox
            // DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\My Computer\\source\\repos\\Lesson_2_Activity\\Image Folder\\Default.jpg");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //code for clearing the textboxes
            QtyTxtbox.Clear();
            PriceTxtbox.Clear();
            Burger1CB.Checked = false;
            Burger2CB.Checked = false;
            Burger3CB.Checked = false;
            Burger4CB.Checked = false;
            Burger5CB.Checked = false;
            Burger6CB.Checked = false;
            Burger7CB.Checked = false;
            Burger8CB.Checked = false;
            Burger9CB.Checked = false;
            Burger10CB.Checked = false;
            Burger11CB.Checked = false;
            Burger12CB.Checked = false;
            Burger13CB.Checked = false;
            Burger14CB.Checked = false;
            Burger15CB.Checked = false;
            Burger16CB.Checked = false;
            Burger17CB.Checked = false;
            Burger18CB.Checked = false;
            Burger19CB.Checked = false;
            Burger20CB.Checked = false;

            //remove all data inside the listbox
            DisplayListbox.Items.Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //code to remove selected data inside the listbox
            DisplayListbox.Items.RemoveAt(DisplayListbox.SelectedIndex);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Example_3_prntfrm print = new Example_3_prntfrm(DisplayListbox.Items);
            print.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodBundleA_RB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            // changing the form background
            this.BackColor = Color.LightCyan;

            // code for food bundle B not be selected
            FoodBundleB_RB.Checked = false;

            // inserting image to picturebox
            //DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\My Computer\\source\\repos\\Lesson_2_Activity\\Latest\\Image Folder\\Food Bundle A.jpg");

            // codes to check the checkboxes when food bundle A is selected
            A_BucketfriesBox.Checked = true;
            A_ChickenBox.Checked = true;
            A_DeluxeburgerBox.Checked = true;
            A_Icedteabox.Checked = true;
            A_SidedishBox.Checked = true;

            //codes to uncheck the checkboxes when food bundle A is selected
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //codes for displaying data inside the textboxes
            PriceTxtbox.Text = "1,000.00";
            DiscountTxtbox.Text = "200.00";
            price = Convert.ToDouble(PriceTxtbox.Text);

            //codes for inserting data inside the listbox
            DisplayListbox.Items.Add(FoodBundleA_RB.Text + " " + PriceTxtbox.Text);
            DisplayListbox.Items.Add("Discount amount: " + " " + DiscountTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void FoodBundleB_RB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            FoodBundleA_RB.Checked = false;
            //DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\My Computer\\source\\repos\\Lesson_2_Activity\\Latest\\Image Folder\\Food Bundle B.jpg");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = true;
            B_HalohaloBox.Checked = true;
            B_LargefriesBox.Checked = true;
            B_SDeluxeburgerbox.Checked = true;
            B_SpaghettiBox.Checked = true;
            PriceTxtbox.Text = "1,299.00";
            DiscountTxtbox.Text = "194.85";
            DisplayListbox.Items.Add(FoodBundleB_RB.Text);
        }
    }
}
