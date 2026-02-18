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
    public partial class Example_3_prntfrm : Form
    {
        public Example_3_prntfrm(ListBox.ObjectCollection items)
        {
            InitializeComponent();
            printDisplayListbox.Items.Clear();
            printDisplayListbox.Items.AddRange(items);
        }

        private void Example_3_prntfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
