
namespace QLCHQuanAo
{
    partial class fQLHoaDon
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.txtnl = new System.Windows.Forms.TextBox();
            this.txthd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xem hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lọc hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 402);
            this.panel1.TabIndex = 9;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.ngay,
            this.sdt,
            this.tenkh});
            this.dgvHoaDon.Location = new System.Drawing.Point(4, 62);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(637, 337);
            this.dgvHoaDon.TabIndex = 10;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 53);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lọc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(328, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã hóa đơn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày lập: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên KH: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtkh);
            this.groupBox1.Controls.Add(this.txtnl);
            this.groupBox1.Controls.Add(this.txthd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(654, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.SystemColors.Window;
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(94, 132);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 10;
            // 
            // txtkh
            // 
            this.txtkh.BackColor = System.Drawing.SystemColors.Window;
            this.txtkh.Enabled = false;
            this.txtkh.Location = new System.Drawing.Point(94, 97);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(100, 20);
            this.txtkh.TabIndex = 10;
            // 
            // txtnl
            // 
            this.txtnl.BackColor = System.Drawing.SystemColors.Window;
            this.txtnl.Enabled = false;
            this.txtnl.Location = new System.Drawing.Point(94, 62);
            this.txtnl.Name = "txtnl";
            this.txtnl.Size = new System.Drawing.Size(100, 20);
            this.txtnl.TabIndex = 10;
            // 
            // txthd
            // 
            this.txthd.BackColor = System.Drawing.SystemColors.Window;
            this.txthd.Enabled = false;
            this.txthd.Location = new System.Drawing.Point(94, 27);
            this.txthd.Name = "txthd";
            this.txthd.Size = new System.Drawing.Size(100, 20);
            this.txthd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SĐT KH: ";
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "maHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.Name = "ngay";
            this.ngay.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdtKH";
            this.sdt.HeaderText = "SĐT KH";
            this.sdt.Name = "sdt";
            this.sdt.Width = 120;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenKH";
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 150;
            // 
            // fQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "fQLHoaDon";
            this.Text = "fQLHoaDon";
            this.Load += new System.EventHandler(this.fQLHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.TextBox txtnl;
        private System.Windows.Forms.TextBox txthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
    }
}