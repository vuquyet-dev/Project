namespace quanlykhachsan
{
    partial class Timkiemphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemphong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINHTRANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblphongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.dataSet1 = new quanlykhachsan.DataSet1();
            this.tblphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_phongTableAdapter = new quanlykhachsan.DataSet1TableAdapters.tbl_phongTableAdapter();
            this.tbl_phongTableAdapter1 = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTK);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1311, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập từ khóa tìm kiếm";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(376, 157);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(287, 34);
            this.txtKey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cbTK
            // 
            this.cbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Items.AddRange(new object[] {
            "Tình trạng phòng",
            "Loại phòng"});
            this.cbTK.Location = new System.Drawing.Point(376, 89);
            this.cbTK.Margin = new System.Windows.Forms.Padding(4);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(287, 37);
            this.cbTK.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(888, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(888, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm thông tin phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1311, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHONGDataGridViewTextBoxColumn,
            this.lOAIPHONGDataGridViewTextBoxColumn,
            this.gIAPHONGDataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn,
            this.tINHTRANGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblphongBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 414);
            this.dataGridView1.TabIndex = 0;
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
            // tblphongBindingSource1
            // 
            this.tblphongBindingSource1.DataMember = "tbl_phong";
            this.tblphongBindingSource1.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblphongBindingSource
            // 
            this.tblphongBindingSource.DataMember = "tbl_phong";
            this.tblphongBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_phongTableAdapter
            // 
            this.tbl_phongTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_phongTableAdapter1
            // 
            this.tbl_phongTableAdapter1.ClearBeforeFill = true;
            // 
            // Timkiemphong
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timkiemphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.timkiemphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTK;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblphongBindingSource;
        private DataSet1TableAdapters.tbl_phongTableAdapter tbl_phongTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tblphongBindingSource1;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter tbl_phongTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINHTRANGDataGridViewTextBoxColumn;
    }
}