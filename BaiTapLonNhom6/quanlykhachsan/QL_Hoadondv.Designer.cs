namespace quanlykhachsan
{
    partial class QL_Hoadondv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Hoadondv));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTKHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvhddv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.quanlykhachsandemo2304DataSet1 = new quanlykhachsan.quanlykhachsandemo2304DataSet1();
            this.quanlykhachsandemo2304DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhddv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.txtTKHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1311, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.Black;
            this.btnTK.Location = new System.Drawing.Point(873, 72);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(167, 48);
            this.btnTK.TabIndex = 2;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTKHD
            // 
            this.txtTKHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKHD.ForeColor = System.Drawing.Color.Black;
            this.txtTKHD.Location = new System.Drawing.Point(585, 79);
            this.txtTKHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTKHD.Name = "txtTKHD";
            this.txtTKHD.Size = new System.Drawing.Size(255, 34);
            this.txtTKHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "-- Nhập mã HĐ dịch vụ --";
            // 
            // dgvhddv
            // 
            this.dgvhddv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhddv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhddv.Location = new System.Drawing.Point(13, 205);
            this.dgvhddv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhddv.Name = "dgvhddv";
            this.dgvhddv.RowHeadersWidth = 51;
            this.dgvhddv.Size = new System.Drawing.Size(1311, 254);
            this.dgvhddv.TabIndex = 1;
            this.dgvhddv.Click += new System.EventHandler(this.dgvhddv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnChitiet);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNgay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMahd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(13, 467);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1311, 323);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // btnChitiet
            // 
            this.btnChitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiet.ForeColor = System.Drawing.Color.Black;
            this.btnChitiet.Location = new System.Drawing.Point(396, 237);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(167, 48);
            this.btnChitiet.TabIndex = 9;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = false;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(654, 237);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(167, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.ForeColor = System.Drawing.Color.Black;
            this.txtTongtien.Location = new System.Drawing.Point(887, 152);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(232, 34);
            this.txtTongtien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(740, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.ForeColor = System.Drawing.Color.Black;
            this.txtNgay.Location = new System.Drawing.Point(887, 66);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(232, 34);
            this.txtNgay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(740, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày lập";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(379, 152);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(201, 34);
            this.txtMaKH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(191, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã KH";
            // 
            // txtMahd
            // 
            this.txtMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahd.ForeColor = System.Drawing.Color.Black;
            this.txtMahd.Location = new System.Drawing.Point(379, 66);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.ReadOnly = true;
            this.txtMahd.Size = new System.Drawing.Size(201, 34);
            this.txtMahd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(191, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ dịch vụ";
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlykhachsandemo2304DataSet1
            // 
            this.quanlykhachsandemo2304DataSet1.DataSetName = "quanlykhachsandemo2304DataSet1";
            this.quanlykhachsandemo2304DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlykhachsandemo2304DataSetBindingSource
            // 
            this.quanlykhachsandemo2304DataSetBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            this.quanlykhachsandemo2304DataSetBindingSource.Position = 0;
            // 
            // qlhoadondv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 803);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvhddv);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "qlhoadondv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.qlhoadondv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhddv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvhddv;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTKHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label2;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource quanlykhachsandemo2304DataSetBindingSource;
        private quanlykhachsandemo2304DataSet1 quanlykhachsandemo2304DataSet1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChitiet;
    }
}