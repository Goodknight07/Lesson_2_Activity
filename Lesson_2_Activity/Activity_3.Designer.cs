using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_2_Activity
{
    partial class Activity_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nodiscountRBTN = new System.Windows.Forms.RadioButton();
            this.employeediscRBTN = new System.Windows.Forms.RadioButton();
            this.withdiscRBTN = new System.Windows.Forms.RadioButton();
            this.seniorcitizenRBTN = new System.Windows.Forms.RadioButton();
            this.exitBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.newBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.discountedtxtbox = new System.Windows.Forms.TextBox();
            this.discounttxtbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.qtytxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemnametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.discounted_totaltxtbox = new System.Windows.Forms.TextBox();
            this.discount_totaltxtbox = new System.Windows.Forms.TextBox();
            this.qty_totaltxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changetxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cash_renderedtxtbox = new System.Windows.Forms.TextBox();
            this.enterBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.name1LBL = new System.Windows.Forms.Label();
            this.name2LBL = new System.Windows.Forms.Label();
            this.name3LBL = new System.Windows.Forms.Label();
            this.name4LBL = new System.Windows.Forms.Label();
            this.name5LBL = new System.Windows.Forms.Label();
            this.name6LBL = new System.Windows.Forms.Label();
            this.name7LBL = new System.Windows.Forms.Label();
            this.name8LBL = new System.Windows.Forms.Label();
            this.name9LBL = new System.Windows.Forms.Label();
            this.name10LBL = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(170, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BURSNT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nodiscountRBTN);
            this.groupBox1.Controls.Add(this.employeediscRBTN);
            this.groupBox1.Controls.Add(this.withdiscRBTN);
            this.groupBox1.Controls.Add(this.seniorcitizenRBTN);
            this.groupBox1.Controls.Add(this.exitBTN);
            this.groupBox1.Controls.Add(this.cancelBTN);
            this.groupBox1.Controls.Add(this.newBTN);
            this.groupBox1.Controls.Add(this.calculateBTN);
            this.groupBox1.Controls.Add(this.discountedtxtbox);
            this.groupBox1.Controls.Add(this.discounttxtbox);
            this.groupBox1.Controls.Add(this.pricetextbox);
            this.groupBox1.Controls.Add(this.qtytxtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemnametxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(427, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // nodiscountRBTN
            // 
            this.nodiscountRBTN.AutoSize = true;
            this.nodiscountRBTN.Location = new System.Drawing.Point(231, 100);
            this.nodiscountRBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodiscountRBTN.Name = "nodiscountRBTN";
            this.nodiscountRBTN.Size = new System.Drawing.Size(84, 17);
            this.nodiscountRBTN.TabIndex = 17;
            this.nodiscountRBTN.TabStop = true;
            this.nodiscountRBTN.Text = "No Discount";
            this.nodiscountRBTN.UseVisualStyleBackColor = true;
            // 
            // employeediscRBTN
            // 
            this.employeediscRBTN.AutoSize = true;
            this.employeediscRBTN.Location = new System.Drawing.Point(231, 80);
            this.employeediscRBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeediscRBTN.Name = "employeediscRBTN";
            this.employeediscRBTN.Size = new System.Drawing.Size(95, 17);
            this.employeediscRBTN.TabIndex = 16;
            this.employeediscRBTN.TabStop = true;
            this.employeediscRBTN.Text = "Employee Disc";
            this.employeediscRBTN.UseVisualStyleBackColor = true;
            // 
            // withdiscRBTN
            // 
            this.withdiscRBTN.AutoSize = true;
            this.withdiscRBTN.Location = new System.Drawing.Point(231, 58);
            this.withdiscRBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdiscRBTN.Name = "withdiscRBTN";
            this.withdiscRBTN.Size = new System.Drawing.Size(99, 17);
            this.withdiscRBTN.TabIndex = 15;
            this.withdiscRBTN.TabStop = true;
            this.withdiscRBTN.Text = "With Disc. Card";
            this.withdiscRBTN.UseVisualStyleBackColor = true;
            // 
            // seniorcitizenRBTN
            // 
            this.seniorcitizenRBTN.AutoSize = true;
            this.seniorcitizenRBTN.Location = new System.Drawing.Point(231, 38);
            this.seniorcitizenRBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorcitizenRBTN.Name = "seniorcitizenRBTN";
            this.seniorcitizenRBTN.Size = new System.Drawing.Size(89, 17);
            this.seniorcitizenRBTN.TabIndex = 14;
            this.seniorcitizenRBTN.TabStop = true;
            this.seniorcitizenRBTN.Text = "Senior Citizen";
            this.seniorcitizenRBTN.UseVisualStyleBackColor = true;
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.Crimson;
            this.exitBTN.Location = new System.Drawing.Point(337, 97);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(81, 19);
            this.exitBTN.TabIndex = 13;
            this.exitBTN.Text = "EXIT";
            this.exitBTN.UseVisualStyleBackColor = false;
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.Crimson;
            this.cancelBTN.Location = new System.Drawing.Point(337, 76);
            this.cancelBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(81, 19);
            this.cancelBTN.TabIndex = 12;
            this.cancelBTN.Text = "CANCEL";
            this.cancelBTN.UseVisualStyleBackColor = false;
            // 
            // newBTN
            // 
            this.newBTN.BackColor = System.Drawing.Color.Crimson;
            this.newBTN.Location = new System.Drawing.Point(337, 55);
            this.newBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(81, 19);
            this.newBTN.TabIndex = 11;
            this.newBTN.Text = "NEW";
            this.newBTN.UseVisualStyleBackColor = false;
            // 
            // calculateBTN
            // 
            this.calculateBTN.BackColor = System.Drawing.Color.Crimson;
            this.calculateBTN.Location = new System.Drawing.Point(337, 33);
            this.calculateBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(81, 19);
            this.calculateBTN.TabIndex = 10;
            this.calculateBTN.Text = "CALCULATE";
            this.calculateBTN.UseVisualStyleBackColor = false;
            // 
            // discountedtxtbox
            // 
            this.discountedtxtbox.Location = new System.Drawing.Point(128, 99);
            this.discountedtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discountedtxtbox.Name = "discountedtxtbox";
            this.discountedtxtbox.Size = new System.Drawing.Size(99, 20);
            this.discountedtxtbox.TabIndex = 9;
            // 
            // discounttxtbox
            // 
            this.discounttxtbox.Location = new System.Drawing.Point(128, 77);
            this.discounttxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discounttxtbox.Name = "discounttxtbox";
            this.discounttxtbox.Size = new System.Drawing.Size(99, 20);
            this.discounttxtbox.TabIndex = 8;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(128, 55);
            this.pricetextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(99, 20);
            this.pricetextbox.TabIndex = 7;
            // 
            // qtytxtbox
            // 
            this.qtytxtbox.Location = new System.Drawing.Point(128, 35);
            this.qtytxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtytxtbox.Name = "qtytxtbox";
            this.qtytxtbox.Size = new System.Drawing.Size(99, 20);
            this.qtytxtbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discounted Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // itemnametxtbox
            // 
            this.itemnametxtbox.Location = new System.Drawing.Point(128, 13);
            this.itemnametxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemnametxtbox.Name = "itemnametxtbox";
            this.itemnametxtbox.Size = new System.Drawing.Size(291, 20);
            this.itemnametxtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of an item:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.discounted_totaltxtbox);
            this.groupBox2.Controls.Add(this.discount_totaltxtbox);
            this.groupBox2.Controls.Add(this.qty_totaltxtbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(9, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(427, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Discounted Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Discount Given:";
            // 
            // discounted_totaltxtbox
            // 
            this.discounted_totaltxtbox.Location = new System.Drawing.Point(153, 68);
            this.discounted_totaltxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discounted_totaltxtbox.Name = "discounted_totaltxtbox";
            this.discounted_totaltxtbox.Size = new System.Drawing.Size(266, 20);
            this.discounted_totaltxtbox.TabIndex = 20;
            // 
            // discount_totaltxtbox
            // 
            this.discount_totaltxtbox.Location = new System.Drawing.Point(128, 46);
            this.discount_totaltxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discount_totaltxtbox.Name = "discount_totaltxtbox";
            this.discount_totaltxtbox.Size = new System.Drawing.Size(291, 20);
            this.discount_totaltxtbox.TabIndex = 19;
            // 
            // qty_totaltxtbox
            // 
            this.qty_totaltxtbox.Location = new System.Drawing.Point(128, 24);
            this.qty_totaltxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qty_totaltxtbox.Name = "qty_totaltxtbox";
            this.qty_totaltxtbox.Size = new System.Drawing.Size(291, 20);
            this.qty_totaltxtbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Quantity:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.changetxtbox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cash_renderedtxtbox);
            this.groupBox3.Location = new System.Drawing.Point(9, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(427, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(261, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Change:";
            // 
            // changetxtbox
            // 
            this.changetxtbox.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetxtbox.Location = new System.Drawing.Point(223, 41);
            this.changetxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changetxtbox.Multiline = true;
            this.changetxtbox.Name = "changetxtbox";
            this.changetxtbox.Size = new System.Drawing.Size(160, 44);
            this.changetxtbox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cash Rendered:";
            // 
            // cash_renderedtxtbox
            // 
            this.cash_renderedtxtbox.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_renderedtxtbox.Location = new System.Drawing.Point(45, 41);
            this.cash_renderedtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cash_renderedtxtbox.Multiline = true;
            this.cash_renderedtxtbox.Name = "cash_renderedtxtbox";
            this.cash_renderedtxtbox.Size = new System.Drawing.Size(160, 44);
            this.cash_renderedtxtbox.TabIndex = 23;
            // 
            // enterBTN
            // 
            this.enterBTN.BackColor = System.Drawing.Color.Crimson;
            this.enterBTN.Location = new System.Drawing.Point(9, 366);
            this.enterBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterBTN.Name = "enterBTN";
            this.enterBTN.Size = new System.Drawing.Size(133, 121);
            this.enterBTN.TabIndex = 4;
            this.enterBTN.Text = "ENTER";
            this.enterBTN.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(149, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(222, 366);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(295, 366);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(368, 366);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(149, 397);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(222, 397);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(295, 397);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 28);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Crimson;
            this.button9.Location = new System.Drawing.Point(368, 397);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 28);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Crimson;
            this.button10.Location = new System.Drawing.Point(149, 428);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 28);
            this.button10.TabIndex = 13;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Crimson;
            this.button11.Location = new System.Drawing.Point(222, 428);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 28);
            this.button11.TabIndex = 14;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Crimson;
            this.button12.Location = new System.Drawing.Point(295, 428);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 28);
            this.button12.TabIndex = 15;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Crimson;
            this.button13.Location = new System.Drawing.Point(368, 428);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 28);
            this.button13.TabIndex = 17;
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(149, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Crimson;
            this.button14.Location = new System.Drawing.Point(295, 459);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 28);
            this.button14.TabIndex = 19;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Crimson;
            this.button15.Location = new System.Drawing.Point(368, 459);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 28);
            this.button15.TabIndex = 20;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "By: John Ernest Solis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(356, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Terminal #21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(118, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(239, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(355, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(469, 23);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(102, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(4, 133);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(102, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(118, 133);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 71);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(239, 133);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(102, 71);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(355, 133);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(102, 71);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(469, 133);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(102, 71);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(4, 248);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(102, 71);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(118, 248);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(102, 71);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(239, 248);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(102, 71);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(355, 248);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(102, 71);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(469, 248);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(102, 71);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(4, 367);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(102, 71);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(118, 367);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(102, 71);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(239, 367);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(102, 71);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(355, 367);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(102, 71);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 18;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(469, 367);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(102, 71);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 19;
            this.pictureBox20.TabStop = false;
            // 
            // name1LBL
            // 
            this.name1LBL.AutoSize = true;
            this.name1LBL.Location = new System.Drawing.Point(4, 102);
            this.name1LBL.Name = "name1LBL";
            this.name1LBL.Size = new System.Drawing.Size(35, 13);
            this.name1LBL.TabIndex = 20;
            this.name1LBL.Text = "Name";
            // 
            // name2LBL
            // 
            this.name2LBL.AutoSize = true;
            this.name2LBL.Location = new System.Drawing.Point(118, 102);
            this.name2LBL.Name = "name2LBL";
            this.name2LBL.Size = new System.Drawing.Size(35, 13);
            this.name2LBL.TabIndex = 21;
            this.name2LBL.Text = "Name";
            // 
            // name3LBL
            // 
            this.name3LBL.AutoSize = true;
            this.name3LBL.Location = new System.Drawing.Point(239, 102);
            this.name3LBL.Name = "name3LBL";
            this.name3LBL.Size = new System.Drawing.Size(35, 13);
            this.name3LBL.TabIndex = 22;
            this.name3LBL.Text = "Name";
            // 
            // name4LBL
            // 
            this.name4LBL.AutoSize = true;
            this.name4LBL.Location = new System.Drawing.Point(355, 102);
            this.name4LBL.Name = "name4LBL";
            this.name4LBL.Size = new System.Drawing.Size(35, 13);
            this.name4LBL.TabIndex = 23;
            this.name4LBL.Text = "Name";
            // 
            // name5LBL
            // 
            this.name5LBL.AutoSize = true;
            this.name5LBL.Location = new System.Drawing.Point(469, 102);
            this.name5LBL.Name = "name5LBL";
            this.name5LBL.Size = new System.Drawing.Size(35, 13);
            this.name5LBL.TabIndex = 24;
            this.name5LBL.Text = "Name";
            // 
            // name6LBL
            // 
            this.name6LBL.AutoSize = true;
            this.name6LBL.Location = new System.Drawing.Point(4, 216);
            this.name6LBL.Name = "name6LBL";
            this.name6LBL.Size = new System.Drawing.Size(35, 13);
            this.name6LBL.TabIndex = 25;
            this.name6LBL.Text = "Name";
            // 
            // name7LBL
            // 
            this.name7LBL.AutoSize = true;
            this.name7LBL.Location = new System.Drawing.Point(118, 213);
            this.name7LBL.Name = "name7LBL";
            this.name7LBL.Size = new System.Drawing.Size(35, 13);
            this.name7LBL.TabIndex = 26;
            this.name7LBL.Text = "Name";
            // 
            // name8LBL
            // 
            this.name8LBL.AutoSize = true;
            this.name8LBL.Location = new System.Drawing.Point(239, 216);
            this.name8LBL.Name = "name8LBL";
            this.name8LBL.Size = new System.Drawing.Size(35, 13);
            this.name8LBL.TabIndex = 27;
            this.name8LBL.Text = "Name";
            // 
            // name9LBL
            // 
            this.name9LBL.AutoSize = true;
            this.name9LBL.Location = new System.Drawing.Point(355, 216);
            this.name9LBL.Name = "name9LBL";
            this.name9LBL.Size = new System.Drawing.Size(35, 13);
            this.name9LBL.TabIndex = 28;
            this.name9LBL.Text = "Name";
            // 
            // name10LBL
            // 
            this.name10LBL.AutoSize = true;
            this.name10LBL.Location = new System.Drawing.Point(469, 213);
            this.name10LBL.Name = "name10LBL";
            this.name10LBL.Size = new System.Drawing.Size(35, 13);
            this.name10LBL.TabIndex = 29;
            this.name10LBL.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.name10LBL);
            this.groupBox4.Controls.Add(this.name9LBL);
            this.groupBox4.Controls.Add(this.name8LBL);
            this.groupBox4.Controls.Add(this.name7LBL);
            this.groupBox4.Controls.Add(this.name6LBL);
            this.groupBox4.Controls.Add(this.name5LBL);
            this.groupBox4.Controls.Add(this.name4LBL);
            this.groupBox4.Controls.Add(this.name3LBL);
            this.groupBox4.Controls.Add(this.name2LBL);
            this.groupBox4.Controls.Add(this.name1LBL);
            this.groupBox4.Controls.Add(this.pictureBox20);
            this.groupBox4.Controls.Add(this.pictureBox19);
            this.groupBox4.Controls.Add(this.pictureBox18);
            this.groupBox4.Controls.Add(this.pictureBox17);
            this.groupBox4.Controls.Add(this.pictureBox16);
            this.groupBox4.Controls.Add(this.pictureBox15);
            this.groupBox4.Controls.Add(this.pictureBox14);
            this.groupBox4.Controls.Add(this.pictureBox13);
            this.groupBox4.Controls.Add(this.pictureBox12);
            this.groupBox4.Controls.Add(this.pictureBox11);
            this.groupBox4.Controls.Add(this.pictureBox10);
            this.groupBox4.Controls.Add(this.pictureBox9);
            this.groupBox4.Controls.Add(this.pictureBox8);
            this.groupBox4.Controls.Add(this.pictureBox7);
            this.groupBox4.Controls.Add(this.pictureBox6);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(449, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(575, 480);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Items Display";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 324);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(469, 440);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(355, 443);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 443);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(118, 440);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 443);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Name";
            // 
            // Activity_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1034, 498);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enterBTN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Activity_3";
            this.Text = "Activity2New";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox itemnametxtbox;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox qtytxtbox;
        private TextBox discountedtxtbox;
        private TextBox discounttxtbox;
        private TextBox pricetextbox;
        private Button exitBTN;
        private Button cancelBTN;
        private Button newBTN;
        private Button calculateBTN;
        private RadioButton nodiscountRBTN;
        private RadioButton employeediscRBTN;
        private RadioButton withdiscRBTN;
        private RadioButton seniorcitizenRBTN;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private TextBox discounted_totaltxtbox;
        private TextBox discount_totaltxtbox;
        private TextBox qty_totaltxtbox;
        private Label label7;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox changetxtbox;
        private Label label10;
        private TextBox cash_renderedtxtbox;
        private Button enterBTN;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button1;
        private Button button14;
        private Button button15;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private Label name1LBL;
        private Label name2LBL;
        private Label name3LBL;
        private Label name4LBL;
        private Label name5LBL;
        private Label name6LBL;
        private Label name7LBL;
        private Label name8LBL;
        private Label name9LBL;
        private Label name10LBL;
        private GroupBox groupBox4;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}