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
    public partial class Hoadontraphong : Form
    {
        public Hoadontraphong()
        {
            InitializeComponent();
        }  
        private void button3_Click(object sender, EventArgs e)
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
                dgvPhieuthue.DataSource = table1;
                string sql = "select*from tbl_hoadon";
                SqlCommand commandsql = new SqlCommand(sql, kn1);
                SqlDataAdapter com1 = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com1.Fill(table);
                dgvHoadonphong.DataSource = table;
                DateTime tn = DateTime.Now;
                txtNgayTT.Text = tn.ToShortDateString();
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

        private void hoadonphong_Load(object sender, EventArgs e)
        {         
            ketnoi1();
        }     
        int i = 0;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int index;
        private void dgvPhieuthue_Click(object sender, EventArgs e)
        {
            index = dgvPhieuthue.CurrentRow.Index;
            txtMaphieu.Text = dgvPhieuthue.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dgvPhieuthue.Rows[index].Cells[2].Value.ToString();
            txtMaphong.Text = dgvPhieuthue.Rows[index].Cells[5].Value.ToString();        
            txtMaNV.Text = dgvPhieuthue.Rows[index].Cells[1].Value.ToString();
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string tt = @"SELECT GIAPHONG,DATEDIFF(day,tbl_phieuthuephong.NGAYDEN, tbl_phieuthuephong.NGAYDI),DATEDIFF(day,tbl_phieuthuephong.NGAYDEN, tbl_phieuthuephong.NGAYDI)*tbl_phong.GIAPHONG
FROM tbl_phieuthuephong Inner Join tbl_phong
ON tbl_phieuthuephong.MAPHONG=tbl_phong.MAPHONG 
WHERE (tbl_phieuthuephong.MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                thuchien = new SqlCommand(tt, kn);
                docdulieu = thuchien.ExecuteReader();
              
                while (docdulieu.Read())
                {
                    txtGiaphong.Text= docdulieu[0].ToString();
                    txtSongay.Text = docdulieu[1].ToString();
                    txtTongtien.Text = docdulieu[2].ToString();
                    i++;
                }
                if (txtSongay.Text == "0")
                {
                    //MessageBox.Show("Khách chưa ở hết 24h. Tổng tiền bằng giá phòng/ngày");
                    txtSongay.Text = "1";
                    txtTongtien.Text = txtGiaphong.Text;
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
        private void dgvHoadonphong_Click(object sender, EventArgs e)
        {
            index = dgvHoadonphong.CurrentRow.Index;
            txtMaHD.Text = dgvHoadonphong.Rows[index].Cells[0].Value.ToString();
            txtMaphieu.Text = dgvHoadonphong.Rows[index].Cells[1].Value.ToString();
            txtMaKH.Text = dgvHoadonphong.Rows[index].Cells[3].Value.ToString();
            txtMaphong.Text = dgvHoadonphong.Rows[index].Cells[4].Value.ToString();
            txtMaNV.Text = dgvHoadonphong.Rows[index].Cells[2].Value.ToString();
        }
        string tao;
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgvHoadonphong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvHoadonphong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                txtMaHD.Text = "HD0" + (chuoi2 + 1).ToString();
            else
                txtMaHD.Text = "HD" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                tao = @"INSERT INTO tbl_hoadon(MAHOADON,MAPHIEUTHUE,MANHANVIEN,MAKHACHHANG,MAPHONG,NGAYTHANHTOAN,TIENPHONG)
VALUES (N'" + txtMaHD.Text + @"',N'" + txtMaphieu.Text + @"',N'" + txtMaNV.Text + @"',N'" + txtMaKH.Text + @"',N'" + txtMaphong.Text + @"',N'" + txtNgayTT.Text + @"',N'" + txtTongtien.Text + @"')";
                SqlCommand commandtao = new SqlCommand(tao, kn);
                commandtao.ExecuteNonQuery();
                ketnoi1();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sua = @"UPDATE tbl_hoadon SET
                TINHTRANG=N'Đã thanh toán '
                WHERE (MAHOADON=N'" + txtMaHD.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();               
                ketnoi1();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
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
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sua = @"UPDATE tbl_hoadon SET
 MAHOADON=N'" + txtMaHD.Text + @"',MAPHIEUTHUE=N'" + txtMaphieu.Text + @"',MANHANVIEN=N'" + txtMaNV.Text + @"',MAKHACHHANG=N'" + txtMaKH.Text + @"',MAPHONG=N'" + txtMaphong.Text + @"',NGAYTHANHTOAN=N'" + txtNgayTT.Text + @"',TIENPHONG=N'" + txtTongtien.Text + @"'
                WHERE(MAHOADON=N'" + txtMaHD.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi1();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string tk = @"select *  from tbl_phieuthuephong where MAPHIEUTHUE like '%" + txtTKMaphieu.Text.Trim() + "%'";
                SqlCommand commandsql1 = new SqlCommand(tk, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql1);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                dgvPhieuthue.DataSource = table2;
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

