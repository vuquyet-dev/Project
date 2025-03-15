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
    public partial class Traphong : Form
    {
        public Traphong()
        {
            InitializeComponent();
        }
        private void ketnoi1()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string sql1 = "select*from tbl_phieuthuephong";
                SqlCommand commandsql1 = new SqlCommand(sql1, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql1);
                DataTable table1 = new DataTable();
                com.Fill(table1);
                dgvthuephong.DataSource = table1;
                DateTime tn = DateTime.Now;
                txtNgaydi.Text = tn.ToShortDateString();
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
        int index;
        private void dgvthuephong_Click(object sender, EventArgs e)
        {
            index = dgvthuephong.CurrentRow.Index;
            txtMaphieu.Text = dgvthuephong.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dgvthuephong.Rows[index].Cells[2].Value.ToString();
            txtMaphong.Text = dgvthuephong.Rows[index].Cells[5].Value.ToString();
            txtNgayden.Text = dgvthuephong.Rows[index].Cells[3].Value.ToString();
            txtMaNV.Text = dgvthuephong.Rows[index].Cells[1].Value.ToString();
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                tt = @"SELECT GIAPHONG
FROM tbl_phieuthuephong Inner Join tbl_phong
ON tbl_phieuthuephong.MAPHONG=tbl_phong.MAPHONG 
WHERE (tbl_phieuthuephong.MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                thuchien = new SqlCommand(tt, kn);
                docdulieu = thuchien.ExecuteReader();
                //ketnoi1();               
                while (docdulieu.Read())
                {
                    txtGia.Text = docdulieu[0].ToString();
                }
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
        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvthuephong.DataSource = xemdl(@"select *  from tbl_phieuthuephong where MAPHIEUTHUE like '%" + txtTKmaphieu.Text.Trim() + "%'");
        }
        string sua;
        string them;
        private void btnTraphong_Click(object sender, EventArgs e)
        {        
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                them = @"UPDATE tbl_phieuthuephong set
                MAPHIEUTHUE=N'" + txtMaphieu.Text + @"',MANHANVIEN=N'" + txtMaNV.Text + @"',MAKHACHHANG=N'" + txtMaKH.Text + @"',NGAYDEN=N'" + txtNgayden.Text + @"',NGAYDI=N'" + txtNgaydi.Text + @"',MAPHONG=N'" + txtMaphong.Text + @"'
                WHERE(MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                if (txtNgayden.Text == txtNgaydi.Text)
                {
                    MessageBox.Show("Ngày đi phải lớn hơn ngày đến ít nhất 1 ngày. Nhập lại ngày đi!");
                }
                else
                {
                    sua = @"UPDATE tbl_phong SET
                TINHTRANG=N'Trống '
                WHERE (MAPHONG=N'" + txtMaphong.Text + @"')";
                    SqlCommand commandsua = new SqlCommand(sua, kn);
                    commandsua.ExecuteNonQuery();
                    SqlCommand commandthem = new SqlCommand(them, kn);
                    commandthem.ExecuteNonQuery();
                    ketnoi1();
                    MessageBox.Show("Trả phòng thành công! Tính tiền và tạo HĐ");                  
                }              
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
        private void traphong2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phong' table. You can move, or remove it, as needed.
            this.tbl_phongTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_phong);
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phieuthuephong' table. You can move, or remove it, as needed.
            this.tbl_phieuthuephongTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_phieuthuephong);
            ketnoi1();
            ketnoi();
        }
        string tt;
        int i = 0;
        SqlCommand thuchien;
        SqlDataReader docdulieu;    
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                tt = @"SELECT DATEDIFF(day,tbl_phieuthuephong.NGAYDEN, tbl_phieuthuephong.NGAYDI),DATEDIFF(day,tbl_phieuthuephong.NGAYDEN, tbl_phieuthuephong.NGAYDI)*tbl_phong.GIAPHONG
FROM tbl_phieuthuephong Inner Join tbl_phong
ON tbl_phieuthuephong.MAPHONG=tbl_phong.MAPHONG 
WHERE (tbl_phieuthuephong.MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                thuchien = new SqlCommand(tt, kn);
                docdulieu = thuchien.ExecuteReader();
                ketnoi1();
                while (docdulieu.Read())
                {
                   // txtGia.Text = docdulieu[0].ToString();
                    lbSongay.Text = docdulieu[0].ToString();
                    lbTongtien.Text = docdulieu[1].ToString();
                    i++;
                }
                if (lbSongay.Text == "0")
                {
                  MessageBox.Show("Khách chưa ở hết 24h. Tổng tiền bằng giá phòng/ngày");
                    lbSongay.Text = "1";
                    lbTongtien.Text = txtGia.Text;
                }
                //btnTinhtien.Enabled = false;
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTTHoadon_Click(object sender, EventArgs e)
        {
            Hoadontraphong f = new Hoadontraphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
