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
    public partial class Chitiethoadondv : Form
    {
        public Chitiethoadondv()
        {
            InitializeComponent();
        }
        public static string MAHD;
        private void ketnoi()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string sql2 = "(select*from tbl_chitietdichvu where MAHOADONDICHVU='" + MAHD + "')";
                SqlCommand commandsql2 = new SqlCommand(sql2, kn1);
                SqlDataAdapter com2 = new SqlDataAdapter(commandsql2);
                DataTable table2 = new DataTable();
                com2.Fill(table2);
                dgvchitiet.DataSource = table2;
                //đổ bảng chi tiết sử dụng dịch vụ               
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

        private void chitiethoadondv_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgvchitiet_Click(object sender, EventArgs e)
        {
            int index = dgvchitiet.CurrentRow.Index;
            txtMachitiet.Text = dgvchitiet.Rows[index].Cells[0].Value.ToString();
            txtMadv.Text = dgvchitiet.Rows[index].Cells[1].Value.ToString();
            txtMadv.Text = dgvchitiet.Rows[index].Cells[2].Value.ToString();
            txtGia.Text = dgvchitiet.Rows[index].Cells[3].Value.ToString();
            txtSL.Text = dgvchitiet.Rows[index].Cells[4].Value.ToString();
            txtSotien.Text = dgvchitiet.Rows[index].Cells[5].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            QL_Hoadondv f = new QL_Hoadondv();
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
