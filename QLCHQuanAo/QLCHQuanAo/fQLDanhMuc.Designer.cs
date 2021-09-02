
namespace QLCHQuanAo
{
    partial class fQLDanhMuc
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
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.maDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiemDM = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã danh mục";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(91, 92);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(224, 20);
            this.txtTenDM.TabIndex = 0;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(91, 55);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(224, 20);
            this.txtMaDM.TabIndex = 0;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDM,
            this.tenDM});
            this.dgvDanhMuc.Location = new System.Drawing.Point(3, 6);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(631, 365);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellContentClick);
            // 
            // maDM
            // 
            this.maDM.DataPropertyName = "maDM";
            this.maDM.HeaderText = "Mã danh mục";
            this.maDM.Name = "maDM";
            this.maDM.Width = 200;
            // 
            // tenDM
            // 
            this.tenDM.DataPropertyName = "tenDM";
            this.tenDM.HeaderText = "Tên danh mục";
            this.tenDM.Name = "tenDM";
            this.tenDM.Width = 300;
            // 
            // btnTimKiemDM
            // 
            this.btnTimKiemDM.Location = new System.Drawing.Point(235, 10);
            this.btnTimKiemDM.Name = "btnTimKiemDM";
            this.btnTimKiemDM.Size = new System.Drawing.Size(87, 54);
            this.btnTimKiemDM.TabIndex = 0;
            this.btnTimKiemDM.Text = "Tìm Kiếm";
            this.btnTimKiemDM.UseVisualStyleBackColor = true;
            this.btnTimKiemDM.Click += new System.EventHandler(this.btnTimKiemDM_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(185, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 61);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(363, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 61);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 61);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiemDM);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(646, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 67);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhMuc);
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 371);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 67);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTenDM);
            this.panel4.Controls.Add(this.txtMaDM);
            this.panel4.Location = new System.Drawing.Point(646, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 371);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUẢN LÝ DANH MỤC";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(541, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(82, 61);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(3, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(224, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // fQLDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "fQLDanhMuc";
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.fQLDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Button btnTimKiemDM;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDM;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}