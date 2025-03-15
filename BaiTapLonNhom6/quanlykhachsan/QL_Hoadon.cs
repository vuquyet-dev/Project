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

namespace quanlykhachsan
{
    public partial class QL_Hoadon : Form
    {
        public QL_Hoadon()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sql = "select * from tbl_hoadon";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHoadon.DataSource = table;
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }
        private void QL_HOADON_Load(object sender, EventArgs e)
        {
            this.tbl_hoadonTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_hoadon);
            ketnoi();
        }
        int index;
        private void dgvHoadon_Click(object sender, EventArgs e)
        {
            index = dgvHoadon.CurrentRow.Index;
            txtMaHD.Text = dgvHoadon.Rows[index].Cells[0].Value.ToString();
            txtMaphieu.Text = dgvHoadon.Rows[index].Cells[1].Value.ToString();
            txtMaNV.Text = dgvHoadon.Rows[index].Cells[2].Value.ToString();
            txtMaKH.Text = dgvHoadon.Rows[index].Cells[3].Value.ToString();
            txtMaphong.Text = dgvHoadon.Rows[index].Cells[4].Value.ToString();
            txtNgayTT.Text = dgvHoadon.Rows[index].Cells[5].Value.ToString();
            txtTongtien.Text = dgvHoadon.Rows[index].Cells[6].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sua = @"UPDATE tbl_hoadon SET
 MAHOADON=N'" + txtMaHD.Text + @"',MAPHIEUTHUE=N'" + txtMaphieu.Text + @"',MANHANVIEN=N'" + txtMaNV.Text + @"',MAKHACHHANG=N'" + txtMaKH.Text + @"',MAPHONG=N'" + txtMaphong.Text + @"',NGAYTHANHTOAN=N'" + txtNgayTT.Text + @"',TIENPHONG=N'" + txtTongtien.Text + @"'
                WHERE(MAHOADON=N'" + txtMaHD.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string tk = @"select *  from tbl_hoadon where MAHOADON like '%" + txtTKMaHD.Text.Trim() + "%'";
                SqlCommand commandsql1 = new SqlCommand(tk, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql1);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                dgvHoadon.DataSource = table2;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }
    }
}
