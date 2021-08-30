using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormNhapDuLieu : Form
    {
        public FormNhapDuLieu()
        {
            InitializeComponent();
        }

        string tenchot_Fnhap;
        string thoigian_Fnhap;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                tenchot_Fnhap = textBox1.Text;
                thoigian_Fnhap = textBox2.Text;

                this.Close();// dong form lai


            }
            else
            {
                MessageBox.Show("Ban chu nhap du lieu");
                
            }

        }
    }
}
