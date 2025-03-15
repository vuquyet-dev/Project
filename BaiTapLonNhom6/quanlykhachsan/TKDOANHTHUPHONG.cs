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
    public partial class TKDOANHTHUPHONG : Form
    {
        public TKDOANHTHUPHONG()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sql = @"SELECT MAPHONG as 'Mã phòng',MAKHACHHANG as 'Mã khách hàng',NGAYTHANHTOAN as 'Ngày thanh toán',TIENPHONG as 'Tiền phòng' FROM tbl_hoadon
WHERE NGAYTHANHTOAN BETWEEN N'" + txtTungay.Text + @"'AND'" + txtdenngay.Text + @"'
group by MAKHACHHANG,MAPHONG,NGAYTHANHTOAN,TIENPHONG";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridView1.DataSource = table;
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
        private void thanhtien()
        {
            int sc = dataGridView1.Rows.Count;
            float tien = 0;
            for (int m = 0; m < sc - 1; m++)
            {
                tien += float.Parse(dataGridView1.Rows[m].Cells["Tiền phòng"].Value.ToString());
            }
            txtTongDT.Text = tien.ToString();
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            ketnoi();
            thanhtien();
           
        }

        private void TKDOANHTHUPHONG_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            txtTungay.Text = tn.ToString("MM/dd/yyyy");
            txtdenngay.Text = tn.ToString("MM/dd/yyyy");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Inhoadonphong f = new Inhoadonphong();
            f.ShowDialog();
        }
    }
}
