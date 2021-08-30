
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtKetqua1 = new System.Windows.Forms.TextBox();
            this.txtKetqua2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "btnNhap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKetqua1
            // 
            this.txtKetqua1.Location = new System.Drawing.Point(206, 158);
            this.txtKetqua1.Name = "txtKetqua1";
            this.txtKetqua1.Size = new System.Drawing.Size(100, 23);
            this.txtKetqua1.TabIndex = 1;
            // 
            // txtKetqua2
            // 
            this.txtKetqua2.Location = new System.Drawing.Point(401, 158);
            this.txtKetqua2.Name = "txtKetqua2";
            this.txtKetqua2.Size = new System.Drawing.Size(100, 23);
            this.txtKetqua2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetqua2);
            this.Controls.Add(this.txtKetqua1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKetqua1;
        private System.Windows.Forms.TextBox txtKetqua2;
    }
}

