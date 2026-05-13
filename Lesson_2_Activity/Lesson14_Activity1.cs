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
        //done
        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\C203-01.C203-01.000\\Pictures\\DIFF.png");

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
            try
            {
                open_file_image();
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox2.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
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
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch 
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, " +
                    "name3, name4, name5, name6, name7, name8, name9, name10, name11, " +
                    "name12, name13, name14, name15, name16, name17, name18, name19, " +
                    "name20) VALUES ('" + pos_id_comboBox.Text + "','" + NameTxtbox1.Text +
                    "','" + NameTxtbox2.Text + "','" + NameTxtbox3.Text + "','" +
                    NameTxtbox4.Text + "','" + NameTxtbox5.Text + "','" +
                    NameTxtbox6.Text + "','" + NameTxtbox7.Text + "','" +
                    NameTxtbox8.Text + "','" + NameTxtbox9.Text + "','" +
                    NameTxtbox10.Text + "','" + NameTxtbox11.Text + "','" +
                    NameTxtbox13.Text + "','" + NameTxtbox13.Text + "','" +
                    NameTxtbox14.Text + "','" + NameTxtbox15.Text + "','" +
                    NameTxtbox16.Text + "','" + NameTxtbox17.Text + "','" +
                    NameTxtbox18.Text + "','" + NameTxtbox19.Text + "','" +
                    NameTxtbox20.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, " +
                    "price3, price4, price5, price6, price7, price8, price9, price10, " +
                    "price11, price12, price13, price14, price15, price16, price17, " +
                    "price18, price19, price20, pos_id) VALUES ('" + PriceTxtbox1.Text +
                    "','" + PriceTxtbox2.Text + "','" + PriceTxtbox3.Text + "','" +
                    PriceTxtbox4.Text + "','" + PriceTxtbox5.Text + "','" +
                    PriceTxtbox6.Text + "','" + PriceTxtbox7.Text + "','" +
                    PriceTxtbox8.Text + "','" + PriceTxtbox9.Text + "','" +
                    PriceTxtbox10.Text + "','" + PriceTxtbox11.Text + "','" +
                    PriceTxtbox12.Text + "','" + PriceTxtbox13.Text + "','" +
                    PriceTxtbox14.Text + "','" + PriceTxtbox15.Text + "','" +
                    PriceTxtbox16.Text + "','" + PriceTxtbox17.Text + "','" +
                    PriceTxtbox18.Text + "','" + PriceTxtbox19.Text + "','" +
                    PriceTxtbox20.Text + "','" + pos_id_comboBox.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, " +
                    "pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, " +
                    "pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" +
                    picpathTxtbox1.Text + "','" + picpathTxtbox2.Text + "','" +
                    picpathTxtbox3.Text + "','" + picpathTxtbox4.Text + "','" +
                    picpathTxtbox5.Text + "','" + picpathTxtbox6.Text + "','" +
                    picpathTxtbox7.Text + "','" + picpathTxtbox8.Text + "','" +
                    picpathTxtbox9.Text + "','" + picpathTxtbox10.Text + "','" +
                    picpathTxtbox11.Text + "','" + picpathTxtbox12.Text + "','" +
                    picpathTxtbox13.Text + "','" + picpathTxtbox14.Text + "','" +
                    picpathTxtbox15.Text + "','" + picpathTxtbox16.Text + "','" +
                    picpathTxtbox17.Text + "','" + picpathTxtbox18.Text + "','" +
                    picpathTxtbox19.Text + "','" + picpathTxtbox20.Text + "','" +
                    pos_id_comboBox.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }


        }

        private void PriceTxtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl " +
                    "ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON " +
                    "pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = " +
                    "'" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqladapterSelect();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                NameTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                NameTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                NameTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                NameTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                NameTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                NameTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                NameTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                NameTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                NameTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                NameTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                NameTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                NameTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                NameTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                NameTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                NameTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                NameTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                NameTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                NameTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                NameTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                NameTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
                picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
                picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
                picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
                picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
                picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
                picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
                picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
                picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
                picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
                picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
                picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
                picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
                picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
                picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
                picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
                picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
                picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
                picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);

                PriceTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][45].ToString();
                PriceTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                PriceTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                PriceTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                PriceTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                PriceTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                PriceTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                PriceTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                PriceTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                PriceTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                PriceTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                PriceTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                PriceTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                PriceTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                PriceTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                PriceTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                PriceTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                PriceTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                PriceTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                PriceTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + NameTxtbox1.Text +
                    "', name2 = '" + NameTxtbox2.Text + "', name3 = '" + NameTxtbox3.Text +
                    "', name4 = '" + NameTxtbox4.Text + "', name5 = '" + NameTxtbox5.Text +
                    "', name6 = '" + NameTxtbox6.Text + "', name7 = '" + NameTxtbox7.Text +
                    "', name8 = '" + NameTxtbox8.Text + "', name9 = '" + NameTxtbox9.Text +
                    "', name10 = '" + NameTxtbox10.Text + "', name11 = '" + NameTxtbox11.Text +
                    "', name12 = '" + NameTxtbox12.Text + "', name13 = '" + NameTxtbox13.Text +
                    "', name14 = '" + NameTxtbox14.Text + "', name15 = '" + NameTxtbox15.Text +
                    "', name16 = '" + NameTxtbox16.Text + "', name17 = '" + NameTxtbox17.Text +
                    "', name18 = '" + NameTxtbox18.Text + "', name19 = '" + NameTxtbox19.Text +
                    "', name20 = '" + NameTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpathTxtbox1.Text +
                    "', pic2 = '" + picpathTxtbox2.Text + "', pic3 = '" + picpathTxtbox3.Text +
                    "', pic4 = '" + picpathTxtbox4.Text + "', pic5 = '" + picpathTxtbox5.Text +
                    "', pic6 = '" + picpathTxtbox6.Text + "', pic7 = '" + picpathTxtbox7.Text +
                    "', pic8 = '" + picpathTxtbox8.Text + "', pic9 = '" + picpathTxtbox9.Text +
                    "', pic10 = '" + picpathTxtbox10.Text + "', pic11 = '" + picpathTxtbox11.Text +
                    "', pic12 = '" + picpathTxtbox12.Text + "', pic13 = '" + picpathTxtbox13.Text +
                    "', pic14 = '" + picpathTxtbox14.Text + "', pic15 = '" + picpathTxtbox15.Text +
                    "', pic16 = '" + picpathTxtbox16.Text + "', pic17 = '" + picpathTxtbox17.Text +
                    "', pic18 = '" + picpathTxtbox18.Text + "', pic19 = '" + picpathTxtbox19.Text +
                    "', pic20 = '" + picpathTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + PriceTxtbox1.Text +
                    "', price2 = '" + PriceTxtbox2.Text + "', price3 = '" + PriceTxtbox3.Text +
                    "', price4 = '" + PriceTxtbox4.Text + "', price5 = '" + PriceTxtbox5.Text +
                    "', price6 = '" + PriceTxtbox6.Text + "', price7 = '" + PriceTxtbox7.Text +
                    "', price8 = '" + PriceTxtbox8.Text + "', price9 = '" + PriceTxtbox9.Text +
                    "', price10 = '" + PriceTxtbox10.Text + "', price11 = '" + PriceTxtbox11.Text +
                    "', price12 = '" + PriceTxtbox12.Text + "', price13 = '" + PriceTxtbox13.Text +
                    "', price14 = '" + PriceTxtbox14.Text + "', price15 = '" + PriceTxtbox15.Text +
                    "', price16 = '" + PriceTxtbox16.Text + "', price17 = '" + PriceTxtbox17.Text +
                    "', price18 = '" + PriceTxtbox18.Text + "', price19 = '" + PriceTxtbox19.Text +
                    "', price20 = '" + PriceTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + NameTxtbox1.Text +
                    "', name2 = '" + NameTxtbox2.Text + "', name3 = '" + NameTxtbox3.Text +
                    "', name4 = '" + NameTxtbox4.Text + "', name5 = '" + NameTxtbox5.Text +
                    "', name6 = '" + NameTxtbox6.Text + "', name7 = '" + NameTxtbox7.Text +
                    "', name8 = '" + NameTxtbox8.Text + "', name9 = '" + NameTxtbox9.Text +
                    "', name10 = '" + NameTxtbox10.Text + "', name11 = '" + NameTxtbox11.Text +
                    "', name12 = '" + NameTxtbox12.Text + "', name13 = '" + NameTxtbox13.Text +
                    "', name14 = '" + NameTxtbox14.Text + "', name15 = '" + NameTxtbox15.Text +
                    "', name16 = '" + NameTxtbox16.Text + "', name17 = '" + NameTxtbox17.Text +
                    "', name18 = '" + NameTxtbox18.Text + "', name19 = '" + NameTxtbox19.Text +
                    "', name20 = '" + NameTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpathTxtbox1.Text +
                    "', pic2 = '" + picpathTxtbox2.Text + "', pic3 = '" + picpathTxtbox3.Text +
                    "', pic4 = '" + picpathTxtbox4.Text + "', pic5 = '" + picpathTxtbox5.Text +
                    "', pic6 = '" + picpathTxtbox6.Text + "', pic7 = '" + picpathTxtbox7.Text +
                    "', pic8 = '" + picpathTxtbox8.Text + "', pic9 = '" + picpathTxtbox9.Text +
                    "', pic10 = '" + picpathTxtbox10.Text + "', pic11 = '" + picpathTxtbox11.Text +
                    "', pic12 = '" + picpathTxtbox12.Text + "', pic13 = '" + picpathTxtbox13.Text +
                    "', pic14 = '" + picpathTxtbox14.Text + "', pic15 = '" + picpathTxtbox15.Text +
                    "', pic16 = '" + picpathTxtbox16.Text + "', pic17 = '" + picpathTxtbox17.Text +
                    "', pic18 = '" + picpathTxtbox18.Text + "', pic19 = '" + picpathTxtbox19.Text +
                    "', pic20 = '" + picpathTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + PriceTxtbox1.Text +
                    "', price2 = '" + PriceTxtbox2.Text + "', price3 = '" + PriceTxtbox3.Text +
                    "', price4 = '" + PriceTxtbox4.Text + "', price5 = '" + PriceTxtbox5.Text +
                    "', price6 = '" + PriceTxtbox6.Text + "', price7 = '" + PriceTxtbox7.Text +
                    "', price8 = '" + PriceTxtbox8.Text + "', price9 = '" + PriceTxtbox9.Text +
                    "', price10 = '" + PriceTxtbox10.Text + "', price11 = '" + PriceTxtbox11.Text +
                    "', price12 = '" + PriceTxtbox12.Text + "', price13 = '" + PriceTxtbox13.Text +
                    "', price14 = '" + PriceTxtbox14.Text + "', price15 = '" + PriceTxtbox15.Text +
                    "', price16 = '" + PriceTxtbox16.Text + "', price17 = '" + PriceTxtbox17.Text +
                    "', price18 = '" + PriceTxtbox18.Text + "', price19 = '" + PriceTxtbox19.Text +
                    "', price20 = '" + PriceTxtbox20.Text + "' WHERE pos_id = '" +
                    pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
                //filtering of image display using specific file extension
                openFileDialog1.ShowDialog(); //displaying the file dialogbox where the possible image located
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); //inserting of selected image to the picturebox shown in the GUI interface
                picpath = openFileDialog1.FileName; //storing the file location of the selected image inserted in picturebox to a variable
                picpathTxtbox1.Text = picpath; //displaying the file location of the image stored in a variable to the textbox
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox4.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox3.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox5.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox5.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox10.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox10.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox9.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox9.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox8.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox8.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox7.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox7.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox6.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox6.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox15.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox15.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox14.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox14.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox13.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox13.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox12.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox12.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox11.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox11.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox20.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox20.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox19.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox19.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox18.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox18.Text = picpath;
            }
            catch (Exception)
           {
               MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox17.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox17.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox16.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox16.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picpathTxtbox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void picpathTxtbox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
