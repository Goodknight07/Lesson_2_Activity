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
    public partial class Menustrip : Form
    {
        public Menustrip()
        {
            InitializeComponent();
        }

        private void pRELIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code for calling the form to be displayed when the menu item is clicked

        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aCTIVITY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_2_form f = new Activity_2_form();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson_3_Activity f = new Lesson_3_Activity();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity_5 f = new Activity_5();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example_3 f = new Example_3();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson_7_example_4 f = new Lesson_7_example_4();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example_5 f = new Example_5();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson_7_example_6 f = new Lesson_7_example_6();
            f.MdiParent = this;
            f.Show();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tILEVERTICALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile the child forms vertically
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tILEHORIZONTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tile the child forms horizontally
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cASCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cascade the child forms
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
