namespace quanlykhachsan
{
    partial class Hoadondichvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadondichvu));
            this.dgvhoadondv = new System.Windows.Forms.DataGridView();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.mAKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblkhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTKKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_khachhangTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_khachhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadondv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvhoadondv
            // 
            this.dgvhoadondv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadondv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadondv.Location = new System.Drawing.Point(16, 367);
            this.dgvhoadondv.Margin = new System.Windows.Forms.Padding(4);
            this.dgvhoadondv.Name = "dgvhoadondv";
            this.dgvhoadondv.RowHeadersWidth = 51;
            this.dgvhoadondv.Size = new System.Drawing.Size(1303, 347);
            this.dgvhoadondv.TabIndex = 0;
            this.dgvhoadondv.Click += new System.EventHandler(this.dgvhoadondv_Click);
            // 
            // txtMahd
            // 
            this.txtMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahd.Location = new System.Drawing.Point(301, 244);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.ReadOnly = true;
            this.txtMahd.Size = new System.Drawing.Size(132, 34);
            this.txtMahd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã HĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(612, 244);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(132, 34);
            this.txtMaKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày tạo";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(938, 244);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(220, 34);
            this.txtNgay.TabIndex = 5;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.Black;
            this.btnTao.Location = new System.Drawing.Point(455, 289);
            this.btnTao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(167, 48);
            this.btnTao.TabIndex = 7;
            this.btnTao.Text = "Tạo HĐ";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiet.ForeColor = System.Drawing.Color.Black;
            this.btnChitiet.Location = new System.Drawing.Point(713, 289);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(167, 48);
            this.btnChitiet.TabIndex = 8;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = false;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AutoGenerateColumns = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHACHHANGDataGridViewTextBoxColumn,
            this.tENKHACHHANGDataGridViewTextBoxColumn,
            this.sODIENTHOAIDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn});
            this.dgvKH.DataSource = this.tblkhachhangBindingSource;
            this.dgvKH.Location = new System.Drawing.Point(16, 15);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.Size = new System.Drawing.Size(933, 205);
            this.dgvKH.TabIndex = 9;
            this.dgvKH.Click += new System.EventHandler(this.dgvKH_Click);
            // 
            // mAKHACHHANGDataGridViewTextBoxColumn
            // 
            this.mAKHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "MAKHACHHANG";
            this.mAKHACHHANGDataGridViewTextBoxColumn.HeaderText = "MÃ KHÁCH HÀNG";
            this.mAKHACHHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHACHHANGDataGridViewTextBoxColumn.Name = "mAKHACHHANGDataGridViewTextBoxColumn";
            // 
            // tENKHACHHANGDataGridViewTextBoxColumn
            // 
            this.tENKHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "TENKHACHHANG";
            this.tENKHACHHANGDataGridViewTextBoxColumn.HeaderText = "HỌ TÊN";
            this.tENKHACHHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENKHACHHANGDataGridViewTextBoxColumn.Name = "tENKHACHHANGDataGridViewTextBoxColumn";
            // 
            // sODIENTHOAIDataGridViewTextBoxColumn
            // 
            this.sODIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "SODIENTHOAI";
            this.sODIENTHOAIDataGridViewTextBoxColumn.HeaderText = "SỐ ĐIỆN THOẠI";
            this.sODIENTHOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sODIENTHOAIDataGridViewTextBoxColumn.Name = "sODIENTHOAIDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "ĐỊA CHỈ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // tblkhachhangBindingSource
            // 
            this.tblkhachhangBindingSource.DataMember = "tbl_khachhang";
            this.tblkhachhangBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "-- Nhập tên KH --";
            // 
            // txtTKKH
            // 
            this.txtTKKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtTKKH.Location = new System.Drawing.Point(119, 105);
            this.txtTKKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKKH.Name = "txtTKKH";
            this.txtTKKH.Size = new System.Drawing.Size(164, 34);
            this.txtTKKH.TabIndex = 10;
            this.txtTKKH.TextChanged += new System.EventHandler(this.txtTKKH_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTKKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(957, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(362, 207);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // tbl_khachhangTableAdapter
            // 
            this.tbl_khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // hoadondichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btnChitiet);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.dgvhoadondv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hoadondichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.hoadondichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadondv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhoadondv;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnChitiet;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTKKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tblkhachhangBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_khachhangTableAdapter tbl_khachhangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
    }
}