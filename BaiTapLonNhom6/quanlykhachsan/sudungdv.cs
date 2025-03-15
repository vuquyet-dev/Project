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
    public partial class sudungdv : Form
    {
        public sudungdv()
        {
            InitializeComponent();
        }
        public SqlConnection cn = new SqlConnection();
        public void ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }
        public DataTable xemdl(string sql)
        {
            ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            ngatketnoi();
        }
        public SqlCommand thucthidl(string sql)
        {
            ketnoi();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            return cm;
            ngatketnoi();
        }

        private void sudungdv_Load(object sender, EventArgs e)
        {
            dgvKhach.DataSource = xemdl(@"select *  from tbl_khachhang ");
            dgvDichvu.DataSource = xemdl(@"select *  from tbl_dichvu ");
            //dgvPhieuthu.DataSource = xemdl(@"select *  from tbl_hoadondichvu ");
            DateTime tn = DateTime.Now;
            txtThoigian.Text = tn.ToString("MM/dd/yyyy");
            ketnoi1();
        }
        int index;
        private void dgvKhach_Click(object sender, EventArgs e)
        {
            index = dgvKhach.CurrentRow.Index;
            txtMaKH.Text = dgvKhach.Rows[index].Cells[0].Value.ToString();           
        }

        private void dgvDichvu_Click(object sender, EventArgs e)
        {
            index = dgvDichvu.CurrentRow.Index;
            txtMaDV.Text = dgvDichvu.Rows[index].Cells[0].Value.ToString();
            txtTendv.Text = dgvDichvu.Rows[index].Cells[1].Value.ToString();
            txtDonvi.Text = dgvDichvu.Rows[index].Cells[2].Value.ToString();
            txtGia.Text = dgvDichvu.Rows[index].Cells[3].Value.ToString();
        }
        private void ketnoi1()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string sql1 = "select * from tbl_chitietdichvu";
                SqlCommand commandsql = new SqlCommand(sql1, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table1 = new DataTable();
                com.Fill(table1);
                dgvPhieuthu.DataSource = table1;
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string them = @"INSERT INTO tbl_hoadondichvu(MAHOADONDICHVU,MAKHACHHANG,THOIGIANLAP)
 VALUES (N'" + txtMaHD.Text + @"',N'" + txtMaKH.Text + @"',N'" + txtThoigian.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                MessageBox.Show("Tạo HĐ thành công. Chọn các loại dịch vụ");
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
        int i = 0;
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                for (int i = 0; i < 100; i++)
                {
                    string them1 = @"INSERT INTO tbl_chitietdichvu(MACHITIETDV,MAHOADONDICHVU,MADICHVU,GIADV,SOLUONG,TIENDICHVU)
 VALUES (N'" + txtMaphieuDV.Text + @"',N'" + txtMaHD.Text + @"',N'" + txtMaDV.Text + @"',N'" + txtSL.Text + @"',N'" + txtSotien.Text + @"')";
                    SqlCommand commandthem = new SqlCommand(them1, kn);
                    commandthem.ExecuteNonQuery();
                 
                    ketnoi1();
                }
              
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


    }
}
