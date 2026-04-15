namespace Lesson_2_Activity
{
    partial class Lesson_7_example_6
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
            this.label3 = new System.Windows.Forms.Label();
            this.NumTimesDisplayTxtbox = new System.Windows.Forms.TextBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.displayListbox = new System.Windows.Forms.ListBox();
            this.CountryCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Enter a number:";
            // 
            // NumTimesDisplayTxtbox
            // 
            this.NumTimesDisplayTxtbox.Location = new System.Drawing.Point(168, 62);
            this.NumTimesDisplayTxtbox.Name = "NumTimesDisplayTxtbox";
            this.NumTimesDisplayTxtbox.Size = new System.Drawing.Size(131, 20);
            this.NumTimesDisplayTxtbox.TabIndex = 44;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(305, 60);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 45;
            this.ShowBtn.Text = "SHOW";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // displayListbox
            // 
            this.displayListbox.FormattingEnabled = true;
            this.displayListbox.Location = new System.Drawing.Point(54, 131);
            this.displayListbox.Name = "displayListbox";
            this.displayListbox.Size = new System.Drawing.Size(327, 199);
            this.displayListbox.TabIndex = 46;
            // 
            // CountryCombobox
            // 
            this.CountryCombobox.FormattingEnabled = true;
            this.CountryCombobox.Location = new System.Drawing.Point(54, 104);
            this.CountryCombobox.Name = "CountryCombobox";
            this.CountryCombobox.Size = new System.Drawing.Size(326, 21);
            this.CountryCombobox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "SELECT A COUNTRY TO DISPLAY AT THE LISTBOX";
            // 
            // Lesson_7_example_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryCombobox);
            this.Controls.Add(this.displayListbox);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.NumTimesDisplayTxtbox);
            this.Controls.Add(this.label3);
            this.Name = "Lesson_7_example_6";
            this.Text = "Lesson_7_example_6";
            this.Load += new System.EventHandler(this.Lesson_7_example_6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumTimesDisplayTxtbox;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.ListBox displayListbox;
        private System.Windows.Forms.ComboBox CountryCombobox;
        private System.Windows.Forms.Label label1;
    }
}