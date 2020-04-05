namespace QuanLyKhachSan
{
    partial class QuanLyKhachSan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.BntXoa = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(107, 19);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(111, 20);
            this.txtmaphong.TabIndex = 1;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(107, 80);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(111, 20);
            this.txtdongia.TabIndex = 3;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Giá";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(392, 20);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(111, 20);
            this.txttenphong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Phòng";
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(23, 250);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(73, 24);
            this.bntThem.TabIndex = 6;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(115, 250);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(73, 24);
            this.bntSua.TabIndex = 7;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // BntXoa
            // 
            this.BntXoa.Location = new System.Drawing.Point(209, 250);
            this.BntXoa.Name = "BntXoa";
            this.BntXoa.Size = new System.Drawing.Size(73, 24);
            this.BntXoa.TabIndex = 8;
            this.BntXoa.Text = "Xóa";
            this.BntXoa.UseVisualStyleBackColor = true;
            this.BntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(489, 250);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(73, 24);
            this.bntThoat.TabIndex = 11;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(395, 250);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(73, 24);
            this.bntHuy.TabIndex = 10;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(303, 250);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(73, 24);
            this.bntLuu.TabIndex = 9;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.DonGia});
            this.dataGridView_Phong.Location = new System.Drawing.Point(110, 115);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.Size = new System.Drawing.Size(368, 121);
            this.dataGridView_Phong.TabIndex = 12;
            this.dataGridView_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Phong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // QuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 294);
            this.Controls.Add(this.dataGridView_Phong);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.BntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyKhachSan";
            this.Text = "Quản Lý Khách Sạn Nhà Nghỉ";
            this.Load += new System.EventHandler(this.QuanLyKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button BntXoa;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.DataGridView dataGridView_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}

