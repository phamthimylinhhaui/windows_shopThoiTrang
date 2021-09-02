
namespace QLCHQuanAo
{
    partial class fQLNhapKho
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "QUẢN LÝ NHẬP KHO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn giá nhập:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(261, 72);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(247, 20);
            this.txtMaSP.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(261, 98);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(247, 20);
            this.txtSoLuong.TabIndex = 10;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(261, 128);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(247, 20);
            this.txtDonGiaNhap.TabIndex = 11;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(547, 41);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(96, 59);
            this.btnNhap.TabIndex = 12;
            this.btnNhap.Text = "Nhập kho";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(261, 159);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(247, 20);
            this.dtpNgayNhap.TabIndex = 13;
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maSP,
            this.soLuong,
            this.donGia,
            this.ngayNhap});
            this.dgvNhapKho.Location = new System.Drawing.Point(100, 206);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.Size = new System.Drawing.Size(587, 239);
            this.dgvNhapKho.TabIndex = 14;
            this.dgvNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapKho_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(261, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(247, 20);
            this.txtID.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(547, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 54);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // maSP
            // 
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.Name = "maSP";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "SoLuongNhap";
            this.soLuong.HeaderText = "Số lượng nhập";
            this.soLuong.Name = "soLuong";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "DonGiaNhap";
            this.donGia.HeaderText = "Đơn giá nhập";
            this.donGia.Name = "donGia";
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "NgayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.Width = 150;
            // 
            // fQLNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 457);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvNhapKho);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "fQLNhapKho";
            this.Text = "Quản lý nhập kho";
            this.Load += new System.EventHandler(this.fQLNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
    }
}