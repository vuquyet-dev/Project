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
    public partial class QL_Hoadondv : Form
    {
        public QL_Hoadondv()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sql = "select * from tbl_hoadondichvu";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvhddv.DataSource = table;
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
        private void qlhoadondv_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        private void dgvhddv_Click(object sender, EventArgs e)
        {
            int index = dgvhddv.CurrentRow.Index;
            txtMahd.Text = dgvhddv.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dgvhddv.Rows[index].Cells[1].Value.ToString();
            txtNgay.Text = dgvhddv.Rows[index].Cells[2].Value.ToString();
            txtTongtien.Text = dgvhddv.Rows[index].Cells[3].Value.ToString();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string tk = @"select *  from tbl_hoadondichvu where MAHOADONDICHVU like '%" + txtTKHD.Text.Trim() + "%'";
                SqlCommand commandsql1 = new SqlCommand(tk, kn1);
                SqlDataAdapter com1 = new SqlDataAdapter(commandsql1);
                DataTable table2 = new DataTable();
                com1.Fill(table2);
                dgvhddv.DataSource = table2;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
        private void btnChitiet_Click(object sender, EventArgs e)
        {
            Chitiethoadondv.MAHD = txtMahd.Text.Trim();
            Chitiethoadondv m = new Chitiethoadondv();
            m.ShowDialog();
            this.Close();
        }
    }
}
