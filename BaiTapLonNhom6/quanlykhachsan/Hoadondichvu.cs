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
    public partial class Hoadondichvu : Form
    {
        public Hoadondichvu()
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
                dgvhoadondv.DataSource = table;
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
        private void btnTao_Click(object sender, EventArgs e)
        {
            
            int count = 0;
            count = dgvhoadondv.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvhoadondv.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 4)));
            if (chuoi2 + 1 < 10)
                txtMahd.Text = "HDV0" + (chuoi2 + 1).ToString();
            else
                txtMahd.Text = "HDV" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string tao = @"INSERT INTO tbl_hoadondichvu(MAHOADONDICHVU,MAKHACHHANG,THOIGIANLAP)
            VALUES (N'" + txtMahd.Text + @"',N'" + txtMaKH.Text + @"',N'" + txtNgay.Text + @"')";
                SqlCommand commandthem = new SqlCommand(tao, kn);
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
        private void btnChitiet_Click(object sender, EventArgs e)
        {
            Chitietsudungdv.MAHOADONDICHVU = txtMahd.Text.Trim();       
            Chitietsudungdv m = new Chitietsudungdv();
            m.ShowDialog();
            this.Close();           
        }
        private void dgvhoadondv_Click(object sender, EventArgs e)
        {
            int index = dgvhoadondv.CurrentRow.Index;
            txtMahd.Text = dgvhoadondv.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dgvhoadondv.Rows[index].Cells[1].Value.ToString();
            txtNgay.Text = dgvhoadondv.Rows[index].Cells[2].Value.ToString();          
        }
        public SqlConnection cn = new SqlConnection();
        public void ketnoi1()
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
            ketnoi1();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            ngatketnoi();
        }
        public SqlCommand thucthidl(string sql)
        {
            ketnoi1();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            return cm;
            ngatketnoi();
        }        
        private void hoadondichvu_Load(object sender, EventArgs e)
        {
            this.tbl_khachhangTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_khachhang);
            ketnoi();
            DateTime tn = DateTime.Now;
            txtNgay.Text = tn.ToShortDateString();           
            ketnoi1();
        }
        private void txtTKKH_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = xemdl(@"select*from tbl_khachhang where TENKHACHHANG like '%" + txtTKKH.Text.Trim() + "%'");
        }
        private void dgvKH_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            txtMaKH.Text = dgvKH.Rows[index].Cells[0].Value.ToString();
        }
    }
}
