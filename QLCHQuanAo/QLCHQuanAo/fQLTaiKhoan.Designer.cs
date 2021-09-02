
namespace QLCHQuanAo
{
    partial class fQLTaiKhoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmLoai = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(98, 58);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(248, 20);
            this.txtTenNV.TabIndex = 0;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(98, 21);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(248, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHienThi,
            this.tenNV,
            this.loaiTK});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(569, 345);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThiNV";
            this.tenHienThi.HeaderText = "Tên tài khoản";
            this.tenHienThi.Name = "tenHienThi";
            this.tenHienThi.Width = 200;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 200;
            // 
            // loaiTK
            // 
            this.loaiTK.DataPropertyName = "loaiTK";
            this.loaiTK.HeaderText = "Loại tài khoản";
            this.loaiTK.Name = "loaiTK";
            this.loaiTK.Width = 120;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 44);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(307, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 351);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 47);
            this.panel1.TabIndex = 7;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(448, 0);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(82, 44);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.nmLoai);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTenNV);
            this.panel4.Controls.Add(this.txtTenTK);
            this.panel4.Location = new System.Drawing.Point(581, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 330);
            this.panel4.TabIndex = 8;
            // 
            // nmLoai
            // 
            this.nmLoai.Location = new System.Drawing.Point(98, 99);
            this.nmLoai.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmLoai.Name = "nmLoai";
            this.nmLoai.Size = new System.Drawing.Size(248, 20);
            this.nmLoai.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 64);
            this.button4.TabIndex = 0;
            this.button4.Text = "Đặt lại mật khẩu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Note: _loại TK (người quản trị :0 _ nhân viên : 1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "_Mật khẩu mặc định: 0";
            // 
            // fQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "fQLTaiKhoan";
            this.Text = "fQLTaiKhoan";
            this.Load += new System.EventHandler(this.fQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTK;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.NumericUpDown nmLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}