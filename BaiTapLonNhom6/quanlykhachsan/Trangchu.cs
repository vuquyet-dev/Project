using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace quanlykhachsan
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private void mnuQL_QLkhachhang_Click(object sender, EventArgs e)
        {
            QL_Khachhang f = new QL_Khachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuQL_QLphong_Click(object sender, EventArgs e)
        {
            QL_Phong f = new QL_Phong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuQL_QLdichvu_Click(object sender, EventArgs e)
        {
            QL_Dichvu f = new QL_Dichvu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuChucNang_Thuephong_Click(object sender, EventArgs e)
        {
            Thuephong f = new Thuephong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuChucNang_Traphong_Click(object sender, EventArgs e)
        {
            Traphong f = new Traphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuTK_Khachhang_Click(object sender, EventArgs e)
        {
            Timkiemkhachhang f = new Timkiemkhachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuTK_Phong_Click(object sender, EventArgs e)
        {
            Timkiemphong f = new Timkiemphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadondichvu f = new Hoadondichvu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuHT_QLtaikhoan_Click(object sender, EventArgs e)
        {
            Thongtin f = new Thongtin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuQL_QLhoadon_Click(object sender, EventArgs e)
        {
            QL_Hoadon f = new QL_Hoadon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void quảnLýHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Hoadondv f = new QL_Hoadondv();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDOANHTHUPHONG f = new TKDOANHTHUPHONG();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDOANHTHUDV f = new TKDOANHTHUDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void inHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inhoadonphong f = new Inhoadonphong();
            f.ShowDialog();
        }

        private void inHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inhoadondv f = new Inhoadondv();
            f.ShowDialog();
        }
    }
}
