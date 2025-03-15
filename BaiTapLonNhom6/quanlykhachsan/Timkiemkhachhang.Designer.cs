namespace quanlykhachsan
{
    partial class Timkiemkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemkhachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblkhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.tbl_khachhangTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_khachhangTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm thông tin khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.cbTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1311, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập từ khóa tìm kiếm";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(406, 148);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(271, 34);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // cbTK
            // 
            this.cbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Items.AddRange(new object[] {
            "Số CMND",
            "Tên"});
            this.cbTK.Location = new System.Drawing.Point(406, 81);
            this.cbTK.Margin = new System.Windows.Forms.Padding(4);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(271, 37);
            this.cbTK.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(924, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(924, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1311, 445);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHACHHANGDataGridViewTextBoxColumn,
            this.tENKHACHHANGDataGridViewTextBoxColumn,
            this.sODIENTHOAIDataGridViewTextBoxColumn,
            this.sOCMNDDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblkhachhangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 414);
            this.dataGridView1.TabIndex = 3;
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
            this.tENKHACHHANGDataGridViewTextBoxColumn.HeaderText = "TÊN KHÁCH HÀNG";
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
            // sOCMNDDataGridViewTextBoxColumn
            // 
            this.sOCMNDDataGridViewTextBoxColumn.DataPropertyName = "SOCMND";
            this.sOCMNDDataGridViewTextBoxColumn.HeaderText = "SỐ CMND";
            this.sOCMNDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOCMNDDataGridViewTextBoxColumn.Name = "sOCMNDDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "ĐỊA CHỈ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "GIỚI TÍNH";
            this.gIOITINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
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
            // tbl_khachhangTableAdapter
            // 
            this.tbl_khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // timkiemkhachhang
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1337, 803);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "timkiemkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.timkiemkhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkhachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tblkhachhangBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_khachhangTableAdapter tbl_khachhangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOCMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
    }
}