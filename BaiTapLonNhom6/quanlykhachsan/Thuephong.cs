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
    public partial class Thuephong : Form
    {
        public Thuephong()
        {
            InitializeComponent();
        }  
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    QL_Khachhang f = new QL_Khachhang();
        //    this.Hide();
        //    f.ShowDialog();
        //    this.Show();
        //}
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


        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    dgvPhong.DataSource = xemdl(@"select*from tbl_phong where LOAIPHONG like '%" + textBox2.Text.Trim() + "%'");
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                dgvThuephong.DataSource = table1;
                DateTime tn = DateTime.Now;
                txtNgayden.Text = tn.ToShortDateString();
                // txtNgaydi.Text = tn.ToString("yyyy/MM/dd");
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
        string them;
        string sua;
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgvThuephong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvThuephong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
                txtMaphieu.Text = "PTP0" + (chuoi2 + 1).ToString();
            else
                txtMaphieu.Text = "PTP" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                them = @"INSERT INTO tbl_phieuthuephong(MAPHIEUTHUE,MANHANVIEN,MAKHACHHANG,NGAYDEN,MAPHONG)
VALUES (N'" + txtMaphieu.Text + "',N'" + txtManv.Text + "',N'" + txtMaKhachhang.Text + "',N'" + txtNgayden.Text + "',N'" + txtMap.Text + "')";
              
                {
                    sua = @"UPDATE tbl_phong SET
                TINHTRANG=N' Có khách '
                WHERE (MAPHONG=N'" + txtMap.Text + @"')";
                    SqlCommand commandsua = new SqlCommand(sua, kn1);
                    commandsua.ExecuteNonQuery();
                    SqlCommand commandthem = new SqlCommand(them, kn1);
                    commandthem.ExecuteNonQuery();
                    ketnoi1();

                    MessageBox.Show("Thuê phòng thành công!");
                }          
            }
            catch
            {              
                MessageBox.Show("Lỗi!");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Close();
            }
        }
        int index;


        //private void dgvPhong_Click(object sender, EventArgs e)
        //{
        //    index = dgvPhong.CurrentRow.Index;
        //    txtMaphong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
        //    txtGiaphong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
        //}
        private void LoadCbMaPhong()
        {
            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu, chỉ lấy những phòng có tình trạng 'Trống'
                DataTable dt = xemdl("SELECT * FROM tbl_phong WHERE TINHTRANG = N'Trống'");

                // Kiểm tra nếu có dữ liệu trả về
                if (dt.Rows.Count > 0)
                {
                    txtMap.DataSource = dt; // Gán dữ liệu cho ComboBox
                    txtMap.DisplayMember = "MAPHONG"; // Hiển thị Mã phòng
                    txtMap.ValueMember = "MAPHONG";   // Giá trị Mã phòng
                }
                else
                {
                    MessageBox.Show("Không có phòng trống để hiển thị!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng: " + ex.Message);
            }
        }
        private void LoadCbMaKhachhang()
        {
            DataTable dt = xemdl(@"select*from tbl_khachhang");

            txtMaKhachhang.DataSource = dt;
            txtMaKhachhang.DisplayMember = "MAKHACHHANG"; // Hiển thị Mã phòng trong ComboBox
            txtMaKhachhang.ValueMember = "MAKHACHHANG";
        }
        private void Thuephong_Load(object sender, EventArgs e)
        {
            LoadCbMaKhachhang();
            LoadCbMaPhong();
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_nhanvien' table. You can move, or remove it, as needed.
            this.tbl_nhanvienTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_nhanvien);
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phieuthuephong' table. You can move, or remove it, as needed.
            this.tbl_phieuthuephongTableAdapter1.Fill(this.quanlykhachsandemo2304DataSet.tbl_phieuthuephong);
            //dgvPhong.DataSource = xemdl("select *  from tbl_phong where TINHTRANG = N'Trống'");
            //dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang");
            ketnoi1();
        }
        int index1;
        private void dgvThuephong_Click(object sender, EventArgs e)
        {
            //index = dgvThuephong.CurrentRow.Index;
            //txtMaphieu.Text = dgvPhong.Rows[index1].Cells[0].Value.ToString();
        }
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                xoa = @"DELETE FROM tbl_phieuthuephong WHERE (MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                SqlCommand commandxoa = new SqlCommand(xoa, kn1);
                commandxoa.ExecuteNonQuery();
                ketnoi1();
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
        //private void btnCapnhat_Click(object sender, EventArgs e)
        //{
        //    dgvPhong.DataSource = xemdl("select *  from tbl_phong where TINHTRANG = N'Trống'");
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang");
        //}

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaphong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaphong = txtMap.SelectedValue.ToString();

            // Truy vấn để lấy giá phòng tương ứng từ CSDL
            DataTable dt = xemdl("SELECT GIAPHONG FROM tbl_phong WHERE MAPHONG = '" + selectedMaphong + "'");

            // Kiểm tra nếu dữ liệu tồn tại và gán giá phòng vào textbox txtGiaphong
            if (dt.Rows.Count > 0)
            {
                txtGiaphong.Text = dt.Rows[0]["GIAPHONG"].ToString();
            }
        }

        private void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        private void dgvThuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thuephong_Load_1(object sender, EventArgs e)
        {
            LoadCbMaKhachhang();
            LoadCbMaPhong();
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_nhanvien' table. You can move, or remove it, as needed.
            this.tbl_nhanvienTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_nhanvien);
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phieuthuephong' table. You can move, or remove it, as needed.
            this.tbl_phieuthuephongTableAdapter1.Fill(this.quanlykhachsandemo2304DataSet.tbl_phieuthuephong);
            //dgvPhong.DataSource = xemdl("select *  from tbl_phong where TINHTRANG = N'Trống'");
            //dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang");
            ketnoi1();
        }
    }  
}
