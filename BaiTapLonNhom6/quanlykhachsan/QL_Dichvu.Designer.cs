namespace quanlykhachsan
{
    partial class QL_Dichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Dichvu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiadv = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtTendv = new System.Windows.Forms.TextBox();
            this.txtMadv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDichvu = new System.Windows.Forms.DataGridView();
            this.mADICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbldichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.tbl_dichvuTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_dichvuTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý dịch vụ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtGiadv);
            this.panel1.Controls.Add(this.txtDonvitinh);
            this.panel1.Controls.Add(this.txtTendv);
            this.panel1.Controls.Add(this.txtMadv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 325);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1038, 223);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(167, 48);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(727, 223);
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
            this.btnSua.Location = new System.Drawing.Point(416, 223);
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
            this.btnThem.Location = new System.Drawing.Point(105, 223);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 48);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGiadv
            // 
            this.txtGiadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiadv.Location = new System.Drawing.Point(963, 123);
            this.txtGiadv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiadv.Name = "txtGiadv";
            this.txtGiadv.Size = new System.Drawing.Size(199, 34);
            this.txtGiadv.TabIndex = 8;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonvitinh.Location = new System.Drawing.Point(963, 72);
            this.txtDonvitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(199, 34);
            this.txtDonvitinh.TabIndex = 7;
            // 
            // txtTendv
            // 
            this.txtTendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendv.Location = new System.Drawing.Point(370, 123);
            this.txtTendv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Size = new System.Drawing.Size(199, 34);
            this.txtTendv.TabIndex = 6;
            // 
            // txtMadv
            // 
            this.txtMadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadv.Location = new System.Drawing.Point(370, 72);
            this.txtMadv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Size = new System.Drawing.Size(199, 34);
            this.txtMadv.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(755, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin dịch vụ";
            // 
            // dgvDichvu
            // 
            this.dgvDichvu.AutoGenerateColumns = false;
            this.dgvDichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichvu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mADICHVUDataGridViewTextBoxColumn,
            this.tENDICHVUDataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn});
            this.dgvDichvu.DataSource = this.tbldichvuBindingSource;
            this.dgvDichvu.Location = new System.Drawing.Point(13, 443);
            this.dgvDichvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDichvu.Name = "dgvDichvu";
            this.dgvDichvu.RowHeadersWidth = 51;
            this.dgvDichvu.Size = new System.Drawing.Size(1311, 347);
            this.dgvDichvu.TabIndex = 2;
            this.dgvDichvu.Click += new System.EventHandler(this.dgvDichvu_Click);
            // 
            // mADICHVUDataGridViewTextBoxColumn
            // 
            this.mADICHVUDataGridViewTextBoxColumn.DataPropertyName = "MADICHVU";
            this.mADICHVUDataGridViewTextBoxColumn.HeaderText = "MÃ DỊCH VỤ";
            this.mADICHVUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mADICHVUDataGridViewTextBoxColumn.Name = "mADICHVUDataGridViewTextBoxColumn";
            // 
            // tENDICHVUDataGridViewTextBoxColumn
            // 
            this.tENDICHVUDataGridViewTextBoxColumn.DataPropertyName = "TENDICHVU";
            this.tENDICHVUDataGridViewTextBoxColumn.HeaderText = "TÊN DỊCH VỤ";
            this.tENDICHVUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDICHVUDataGridViewTextBoxColumn.Name = "tENDICHVUDataGridViewTextBoxColumn";
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "ĐƠN VỊ TÍNH";
            this.dONVITINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "GIÁ DỊCH VỤ";
            this.gIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            // 
            // tbldichvuBindingSource
            // 
            this.tbldichvuBindingSource.DataMember = "tbl_dichvu";
            this.tbldichvuBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_dichvuTableAdapter
            // 
            this.tbl_dichvuTableAdapter.ClearBeforeFill = true;
            // 
            // QL_Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 803);
            this.Controls.Add(this.dgvDichvu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QL_Dichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.QL_Dichvu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiadv;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtTendv;
        private System.Windows.Forms.TextBox txtMadv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDichvu;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tbldichvuBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_dichvuTableAdapter tbl_dichvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
    }
}