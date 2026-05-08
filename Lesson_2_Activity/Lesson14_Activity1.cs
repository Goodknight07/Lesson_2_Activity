using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lesson_2_Activity
{
    public partial class Lesson14_Activity1 : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;
        public Lesson14_Activity1()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {

                NameTxtbox1.Clear(); NameTxtbox2.Clear(); NameTxtbox3.Clear();
                NameTxtbox4.Clear(); NameTxtbox5.Clear(); NameTxtbox6.Clear();
                NameTxtbox7.Clear(); NameTxtbox8.Clear(); NameTxtbox9.Clear();
                NameTxtbox10.Clear(); NameTxtbox11.Clear(); NameTxtbox12.Clear();
                NameTxtbox13.Clear(); NameTxtbox14.Clear(); NameTxtbox15.Clear();
                NameTxtbox16.Clear(); NameTxtbox17.Clear(); NameTxtbox18.Clear();
                NameTxtbox19.Clear(); NameTxtbox20.Clear();
                picpathTxtbox1.Clear(); picpathTxtbox2.Clear(); picpathTxtbox3.Clear();
                picpathTxtbox4.Clear(); picpathTxtbox5.Clear(); picpathTxtbox6.Clear();
                picpathTxtbox7.Clear(); picpathTxtbox8.Clear(); picpathTxtbox9.Clear();
                picpathTxtbox10.Clear(); picpathTxtbox11.Clear(); picpathTxtbox12.Clear();
                picpathTxtbox13.Clear(); picpathTxtbox14.Clear(); picpathTxtbox15.Clear();
                picpathTxtbox16.Clear(); picpathTxtbox17.Clear(); picpathTxtbox18.Clear();
                picpathTxtbox19.Clear(); picpathTxtbox20.Clear();
                PriceTxtbox1.Clear(); PriceTxtbox2.Clear(); PriceTxtbox3.Clear();
                PriceTxtbox4.Clear(); PriceTxtbox5.Clear(); PriceTxtbox6.Clear();
                PriceTxtbox7.Clear(); PriceTxtbox8.Clear(); PriceTxtbox9.Clear();
                PriceTxtbox10.Clear(); PriceTxtbox11.Clear(); PriceTxtbox12.Clear();
                PriceTxtbox13.Clear(); PriceTxtbox14.Clear(); PriceTxtbox15.Clear();
                PriceTxtbox16.Clear(); PriceTxtbox17.Clear(); PriceTxtbox18.Clear();
                PriceTxtbox19.Clear(); PriceTxtbox20.Clear();
                pictureBox1.Image = pic; pictureBox2.Image = pic; pictureBox3.Image = pic;
                pictureBox4.Image = pic; pictureBox5.Image = pic; pictureBox6.Image = pic;
                pictureBox7.Image = pic; pictureBox8.Image = pic; pictureBox9.Image = pic;
                pictureBox10.Image = pic; pictureBox11.Image = pic; pictureBox12.Image = pic;
                pictureBox13.Image = pic; pictureBox14.Image = pic; pictureBox15.Image = pic;
                pictureBox16.Image = pic; pictureBox17.Image = pic; pictureBox18.Image = pic;
                pictureBox19.Image = pic; pictureBox20.Image = pic;
            }
            catch 
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Lesson14_Activity1_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide();
                picpathTxtbox3.Hide(); picpathTxtbox4.Hide();
                picpathTxtbox5.Hide(); picpathTxtbox6.Hide();
                picpathTxtbox7.Hide(); picpathTxtbox8.Hide();
                picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
                picpathTxtbox11.Hide(); picpathTxtbox12.Hide();
                picpathTxtbox13.Hide(); picpathTxtbox14.Hide();
                picpathTxtbox15.Hide(); picpathTxtbox16.Hide();
                picpathTxtbox17.Hide(); picpathTxtbox18.Hide();
                picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

                posdb_connect.pos_select();
                //posdb_connect.pos_cmd;
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch 
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ///note
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl ( pos_ id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10,name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" + pos_id_comboBox.Text + "','" + NameTxtbox1.Text + "','" + NameTxtbox2.Text + "','" + NameTxtbox3.Text + "', '" + NameTxtbox4.Text + "', '" + NameTxtbox5.Text + "', '" + NameTxtbox6.Text + "','" + NameTxtbox7.Text + "', '" + NameTxtbox8.Text + "', '" + NameTxtbox9.Text + "', '" + NameTxtbox10.Text + "', )";



            }
        }
    }
}
