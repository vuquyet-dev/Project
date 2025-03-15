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
    public partial class QL_Khachhang : Form
    {
        public QL_Khachhang()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sql = "select * from tbl_khachhang";
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

        private void QL_Khachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_khachhang' table. You can move, or remove it, as needed.
            //this.tbl_khachhangTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_khachhang);
            ketnoi();
        }
        int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtMaKH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSoCMND.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            cbGioitinh.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtSodienthoai.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        string them;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dataGridView1.Rows.Count;
        string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView1.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            txtMaKH.Text = "KH0" + (chuoi2 + 1).ToString();
            else 
            txtMaKH.Text = "KH" + (chuoi2 + 1).ToString();
            try
            {
            SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
            kn.Open();
            them = @"INSERT INTO tbl_khachhang(MAKHACHHANG,TENKHACHHANG,SODIENTHOAI,SOCMND,DIACHI,GIOITINH)
            VALUES (N'" + txtMaKH.Text + @"',N'" + txtHoten.Text + @"',N'" + txtSodienthoai.Text + @"',N'" + txtSoCMND.Text + @"',N'" + txtDiachi.Text + @"',N'" + cbGioitinh.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
           }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }
        string xoa;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                xoa = @"DELETE FROM tbl_khachhang WHERE (MAKHACHHANG=N'" + txtMaKH.Text + @"')";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi! Phải xóa phiếu thuê phòng trước");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }
        string sua;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                sua = @"UPDATE tbl_khachhang set
                MAKHACHHANG=N'" + txtMaKH.Text + @"',TENKHACHHANG=N'" + txtHoten.Text + @"',SODIENTHOAI=N'" + txtSodienthoai.Text + @"',SOCMND=N'" + txtSoCMND.Text + @"',DIACHI=N'" + txtDiachi.Text + @"',GIOITINH=N'" + cbGioitinh.Text + @"'
                WHERE(MAKHACHHANG=N'" + txtMaKH.Text + @"')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
