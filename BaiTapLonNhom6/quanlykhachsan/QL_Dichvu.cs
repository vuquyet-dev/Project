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
    public partial class QL_Dichvu : Form
    {
        public QL_Dichvu()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Open();
                string sql = "select * from tbl_dichvu";
                SqlCommand commandsql = new SqlCommand(sql, kn2);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvDichvu.DataSource = table;
               
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Open();
            }
        }
        private void QL_Dichvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_dichvu' table. You can move, or remove it, as needed.
            this.tbl_dichvuTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_dichvu);
            ketnoi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
        int index;
        private void dgvDichvu_Click(object sender, EventArgs e)
        {
            index = dgvDichvu.CurrentRow.Index;
            txtMadv.Text = dgvDichvu.Rows[index].Cells[0].Value.ToString();
            txtTendv.Text = dgvDichvu.Rows[index].Cells[1].Value.ToString();
            txtDonvitinh.Text = dgvDichvu.Rows[index].Cells[2].Value.ToString();
           txtGiadv.Text = dgvDichvu.Rows[index].Cells[3].Value.ToString();
        }
        string them;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgvDichvu.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDichvu.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                txtMadv.Text = "DV0" + (chuoi2 + 1).ToString();
            else
                txtMadv.Text = "DV" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Open();
                them = @"INSERT INTO tbl_dichvu(MADICHVU,TENDICHVU,DONVITINH,GIA)
VALUES (N'" + txtMadv.Text + @"',N'" + txtTendv.Text + @"',N'" + txtDonvitinh.Text + @"',N'" + txtGiadv.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn2);
                commandthem.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Close();
            }
        }
        string sua;

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Open();
                sua = @"UPDATE tbl_dichvu set
MADICHVU=N'" + txtMadv.Text + @"',TENDICHVU=N'" + txtTendv.Text + @"',DONVITINH=N'" + txtDonvitinh.Text + @"',GIA=N'" + txtGiadv.Text + @"'
WHERE (MADICHVU=N'" + txtMadv.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn2);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Close();
            }
        }
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Open();
                xoa = @"DELETE FROM tbl_dichvu WHERE (MADICHVU=N'" + txtMadv.Text + @"')";
                SqlCommand commandxoa = new SqlCommand(xoa, kn2);
                commandxoa.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn2 = new SqlConnection(@"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn2.Close();
            }
        }
    }
}

