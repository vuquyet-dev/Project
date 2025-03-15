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
    public partial class Timkiemkhachhang : Form
    {
        public Timkiemkhachhang()
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTK.Text == "Số CMND")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_khachhang where SOCMND like '%" + txtKey.Text.Trim() + "%'");
            }
            if (cbTK.Text == "Tên")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_khachhang where TENKHACHHANG like '%" + txtKey.Text.Trim() + "%'");
            }

        }
        private void timkiemkhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_khachhang' table. You can move, or remove it, as needed.
            this.tbl_khachhangTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_khachhang);
            cbTK.Text = "Số CMND";
        }
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (cbTK.Text == "Số CMND")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_khachhang where SOCMND like '%" + txtKey.Text.Trim() + "%'");
            }
            if (cbTK.Text == "Tên")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_khachhang where TENKHACHHANG like '%" + txtKey.Text.Trim() + "%'");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}      
        

    

