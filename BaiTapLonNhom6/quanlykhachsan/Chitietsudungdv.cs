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
    public partial class Chitietsudungdv : Form
    {
        public Chitietsudungdv()
        {
            InitializeComponent();
            

        }
        public static string MAHOADONDICHVU;
        private void ketnoi1()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string sql1 = "select*from tbl_dichvu";
                SqlCommand commandsql1 = new SqlCommand(sql1, kn1);
                SqlDataAdapter com1 = new SqlDataAdapter(commandsql1);
                DataTable table1 = new DataTable();
                com1.Fill(table1);
                dataGridView1.DataSource = table1;
                //đổ bảng dịch vụ
                string sql2 = "(select*from tbl_chitietdichvu where MAHOADONDICHVU='" + MAHOADONDICHVU + "')";
                SqlCommand commandsql2 = new SqlCommand(sql2, kn1);
                SqlDataAdapter com2 = new SqlDataAdapter(commandsql2);
                DataTable table2 = new DataTable();
                com2.Fill(table2);
                dataGridView2.DataSource = table2;
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
        private void dataGridView2_Click(object sender, EventArgs e)
        { 
            //Đổ dữ liệu từ dgv lên textbox
            int index = dataGridView2.CurrentRow.Index;
            txtChitiet.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            txtmahd.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
            txtSL.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
            txtmadv.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
            txtGia.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
            txtsotien.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Đổ dữ liệu từ dgv lên textbox
            int i = 1, M = 0;
            int index = dataGridView1.CurrentRow.Index;
            txtmadv.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtGia.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtSL.Text = i.ToString();
            txtsotien.Text = M.ToString();
        }
        private void update()
        {
            sotien();
            SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
            kn.Open();
            string sua = @"UPDATE tbl_chitietdichvu SET
                TIENDICHVU=N'" + txtsotien.Text + @"'
                WHERE (MACHITIETDV=N'" + txtChitiet.Text + @"')";
            SqlCommand commandsua = new SqlCommand(sua, kn);
            commandsua.ExecuteNonQuery();
            ketnoi1();           
        }
        private void thanhtien()
        {
            int sc = dataGridView2.Rows.Count;
            float tien = 0;
            for (int m = 0; m < sc - 1; m++)
            {
                tien += float.Parse(dataGridView2.Rows[m].Cells["TIENDICHVU"].Value.ToString());
            }
            txttongtien.Text = tien.ToString();
        }
        private void sotien()
        {
            int i = 0;
            SqlCommand thuchien;
            SqlDataReader docdulieu;            
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string tt = @"SELECT tbl_chitietdichvu.GIADV*tbl_chitietdichvu.soluong
                    FROM tbl_dichvu Inner Join tbl_chitietdichvu
                    ON tbl_chitietdichvu.MADICHVU=tbl_dichvu.MADICHVU 
                    WHERE (tbl_chitietdichvu.MACHITIETDV=N'" + txtChitiet.Text + @"') and (tbl_chitietdichvu.MAHOADONDICHVU=N'" + txtmahd.Text + @"')";
                thuchien = new SqlCommand(tt, kn1);
                docdulieu = thuchien.ExecuteReader();
                while (docdulieu.Read())
                {
                    txtsotien.Text = docdulieu[0].ToString();
                    i++;
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
        private void chon()
        {
            try
            {
                //chọn và thêm dịch vụ vào bảng
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string chon = @"INSERT INTO tbl_chitietdichvu(MAHOADONDICHVU,MADICHVU,GIADV,SOLUONG,TIENDICHVU)
 VALUES (N'" + txtmahd.Text + @"',N'" + txtmadv.Text + @"',N'" + txtGia.Text + @"',N'" + txtSL.Text + @"',N'0')";
                SqlCommand commandchon = new SqlCommand(chon, kn1);
                commandchon.ExecuteNonQuery();                            
                ketnoi1();
                MessageBox.Show("Chọn dịch vụ thành công, hãy tính tiền dịch vụ");
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
        private void button1_Click(object sender, EventArgs e)
        {
            chon();
            ketnoi1();
            update();
            sotien();           
        }    
        private void bochon()
        {
            try
            {              
                SqlConnection kn1 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn1.Open();
                string bo = @"DELETE FROM tbl_chitietdichvu WHERE (MACHITIETDV=N'" + txtChitiet.Text + @"')";
                SqlCommand commandbo = new SqlCommand(bo, kn1);
                commandbo.ExecuteNonQuery();                         
                ketnoi1();
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
        private void button2_Click(object sender, EventArgs e)//bỏ chọn dv
        {
            bochon();
            ketnoi1();
            sotien();
            update();
            thanhtien();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            update();
            thanhtien();
        }     
        private void testdv_Load(object sender, EventArgs e)
        {           
            ketnoi1();         
            thanhtien();
            txtmahd.Text = MAHOADONDICHVU;
            dataGridView1.Columns[0].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns[1].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns[2].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[3].HeaderText = "Giá";
        }
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sua = @"UPDATE tbl_hoadondichvu SET
                TONGTIENDICHVU=N'" + txttongtien.Text + @"'
                WHERE (MAHOADONDICHVU=N'" + txtmahd.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi1();
                MessageBox.Show("Lưu hóa đơn thành công!");
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hoadondichvu f = new Hoadondichvu();
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}



