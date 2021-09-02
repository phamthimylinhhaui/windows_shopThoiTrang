
namespace QLCHQuanAo
{
    partial class fQLSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmSoLuongsp = new System.Windows.Forms.NumericUpDown();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongsp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(4, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(156, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 48);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(300, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 48);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Location = new System.Drawing.Point(578, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 54);
            this.panel2.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(14, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(224, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 38);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSanPham);
            this.panel3.Location = new System.Drawing.Point(4, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 383);
            this.panel3.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.tenSP,
            this.DanhMuc,
            this.DonGia,
            this.SoLuong});
            this.dgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(545, 377);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // maSP
            // 
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.Name = "maSP";
            this.maSP.Width = 70;
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên Sản Phẩm";
            this.tenSP.Name = "tenSP";
            this.tenSP.Width = 130;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "maDM";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "gia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmSoLuongsp);
            this.panel4.Controls.Add(this.cbbDanhMuc);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtDonGia);
            this.panel4.Controls.Add(this.txtTenSP);
            this.panel4.Controls.Add(this.txtMaSP);
            this.panel4.Location = new System.Drawing.Point(578, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 383);
            this.panel4.TabIndex = 0;
            // 
            // nmSoLuongsp
            // 
            this.nmSoLuongsp.Location = new System.Drawing.Point(99, 137);
            this.nmSoLuongsp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmSoLuongsp.Name = "nmSoLuongsp";
            this.nmSoLuongsp.Size = new System.Drawing.Size(224, 20);
            this.nmSoLuongsp.TabIndex = 3;
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(99, 78);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(224, 21);
            this.cbbDanhMuc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn giá: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(99, 105);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(224, 20);
            this.txtDonGia.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(99, 52);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(224, 20);
            this.txtTenSP.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(99, 26);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(224, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(444, 0);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(82, 49);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // fQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 480);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fQLSanPham";
            this.Text = "fSanPham";
            this.Load += new System.EventHandler(this.fQLSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.NumericUpDown nmSoLuongsp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnXem;
    }
}