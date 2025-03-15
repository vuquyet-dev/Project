using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace quanlykhachsan
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPass.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }

}

