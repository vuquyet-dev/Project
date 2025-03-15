namespace quanlykhachsan
{
    partial class QL_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Phong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTinhtrang = new System.Windows.Forms.ComboBox();
            this.cbLoaiphong = new System.Windows.Forms.ComboBox();
            this.txtGiaphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINHTRANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.tbl_phongTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cbTinhtrang);
            this.panel1.Controls.Add(this.cbLoaiphong);
            this.panel1.Controls.Add(this.txtGiaphong);
            this.panel1.Controls.Add(this.txtMaphong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 294);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(966, 202);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(167, 48);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(689, 202);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 48);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(412, 202);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 48);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(135, 202);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 48);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTinhtrang
            // 
            this.cbTinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhtrang.FormattingEnabled = true;
            this.cbTinhtrang.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cbTinhtrang.Location = new System.Drawing.Point(946, 117);
            this.cbTinhtrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTinhtrang.Name = "cbTinhtrang";
            this.cbTinhtrang.Size = new System.Drawing.Size(175, 37);
            this.cbTinhtrang.TabIndex = 8;
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiphong.FormattingEnabled = true;
            this.cbLoaiphong.Items.AddRange(new object[] {
            "Thường đơn",
            "Thường đôi",
            "VIP đơn",
            "VIP đôi"});
            this.cbLoaiphong.Location = new System.Drawing.Point(382, 117);
            this.cbLoaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(175, 37);
            this.cbLoaiphong.TabIndex = 7;
            // 
            // txtGiaphong
            // 
            this.txtGiaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaphong.Location = new System.Drawing.Point(946, 54);
            this.txtGiaphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.Size = new System.Drawing.Size(180, 34);
            this.txtGiaphong.TabIndex = 6;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.Location = new System.Drawing.Point(382, 54);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(272, 34);
            this.txtMaphong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoGenerateColumns = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHONGDataGridViewTextBoxColumn,
            this.lOAIPHONGDataGridViewTextBoxColumn,
            this.gIAPHONGDataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn,
            this.tINHTRANGDataGridViewTextBoxColumn});
            this.dgvPhong.DataSource = this.tblphongBindingSource;
            this.dgvPhong.Location = new System.Drawing.Point(13, 443);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(1311, 347);
            this.dgvPhong.TabIndex = 2;
            this.dgvPhong.Click += new System.EventHandler(this.dgvPhong_Click);
            // 
            // mAPHONGDataGridViewTextBoxColumn
            // 
            this.mAPHONGDataGridViewTextBoxColumn.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.HeaderText = "MÃ PHÒNG";
            this.mAPHONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPHONGDataGridViewTextBoxColumn.Name = "mAPHONGDataGridViewTextBoxColumn";
            // 
            // lOAIPHONGDataGridViewTextBoxColumn
            // 
            this.lOAIPHONGDataGridViewTextBoxColumn.DataPropertyName = "LOAIPHONG";
            this.lOAIPHONGDataGridViewTextBoxColumn.HeaderText = "LOẠI PHÒNG";
            this.lOAIPHONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOAIPHONGDataGridViewTextBoxColumn.Name = "lOAIPHONGDataGridViewTextBoxColumn";
            // 
            // gIAPHONGDataGridViewTextBoxColumn
            // 
            this.gIAPHONGDataGridViewTextBoxColumn.DataPropertyName = "GIAPHONG";
            this.gIAPHONGDataGridViewTextBoxColumn.HeaderText = "GIÁ PHÒNG";
            this.gIAPHONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIAPHONGDataGridViewTextBoxColumn.Name = "gIAPHONGDataGridViewTextBoxColumn";
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "ĐƠN VỊ TÍNH";
            this.dONVITINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            // 
            // tINHTRANGDataGridViewTextBoxColumn
            // 
            this.tINHTRANGDataGridViewTextBoxColumn.DataPropertyName = "TINHTRANG";
            this.tINHTRANGDataGridViewTextBoxColumn.HeaderText = "TÌNH TRẠNG";
            this.tINHTRANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tINHTRANGDataGridViewTextBoxColumn.Name = "tINHTRANGDataGridViewTextBoxColumn";
            // 
            // tblphongBindingSource
            // 
            this.tblphongBindingSource.DataMember = "tbl_phong";
            this.tblphongBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_phongTableAdapter
            // 
            this.tbl_phongTableAdapter.ClearBeforeFill = true;
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 803);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.QLPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTinhtrang;
        private System.Windows.Forms.ComboBox cbLoaiphong;
        private System.Windows.Forms.TextBox txtGiaphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tblphongBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter tbl_phongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINHTRANGDataGridViewTextBoxColumn;
    }
}