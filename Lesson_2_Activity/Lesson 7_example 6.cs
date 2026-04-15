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
    public partial class Lesson_7_example_6 : Form
    {
        public Lesson_7_example_6()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(NumTimesDisplayTxtbox.Text);
            do
            {
                displayListbox.Items.Add(CountryCombobox.Text);
                InitialValue ++;
            } while (InitialValue <= numTimesDisplay);
        }

        private void Lesson_7_example_6_Load(object sender, EventArgs e)
        {
            CountryCombobox.Items.Add("South Korea");
            CountryCombobox.Items.Add("Thailand");
            CountryCombobox.Items.Add("Hawaii");
            CountryCombobox.Items.Add("Hongkong");
            CountryCombobox.Items.Add("Canada");
            CountryCombobox.Items.Add("Japan");
        }
    }
}
