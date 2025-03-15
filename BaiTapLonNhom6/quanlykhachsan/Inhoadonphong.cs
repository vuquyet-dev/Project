using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan
{
    public partial class Inhoadonphong : Form
    {
        public Inhoadonphong()
        {
            InitializeComponent();
        }

        private void frmInHDphong_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=VU_QUYET;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True";

            // Truy vấn SQL để lấy dữ liệu từ bảng tbl_hoadon
            string query = "SELECT MAHOADON, MAPHIEUTHUE, MANHANVIEN, MAKHACHHANG, MAPHONG, NGAYTHANHTOAN, TIENPHONG, TINHTRANG FROM tbl_hoadon";

            // Khởi tạo DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Kết nối đến cơ sở dữ liệu và thực thi truy vấn
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);  // Điền dữ liệu vào DataTable
            }

            // Cấu hình và hiển thị báo cáo trên ReportViewer
            // Đường dẫn đến file báo cáo RDLC

            // Xóa các DataSources cũ
            reportViewer1.LocalReport.DataSources.Clear();

            // Thêm DataTable vào báo cáo
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // Làm mới báo cáo
            reportViewer1.RefreshReport();
        }
    }
}
