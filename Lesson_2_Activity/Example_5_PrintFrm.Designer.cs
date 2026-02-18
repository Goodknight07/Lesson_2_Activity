namespace Lesson_2_Activity
{
    partial class Example_5_PrintFrm
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
            this.PrintDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PrintDisplayListbox
            // 
            this.PrintDisplayListbox.FormattingEnabled = true;
            this.PrintDisplayListbox.Location = new System.Drawing.Point(12, 12);
            this.PrintDisplayListbox.Name = "PrintDisplayListbox";
            this.PrintDisplayListbox.Size = new System.Drawing.Size(424, 628);
            this.PrintDisplayListbox.TabIndex = 0;
            // 
            // Example_5_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 649);
            this.Controls.Add(this.PrintDisplayListbox);
            this.Name = "Example_5_PrintFrm";
            this.Text = "Example_5_PrintFrm";
            this.Load += new System.EventHandler(this.Example_5_PrintFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox PrintDisplayListbox;
    }
}