namespace Tính_tiền_bán_hàng
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_so_luong = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_tien = new System.Windows.Forms.Button();
            this.lb_thanh_tien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_thanh_tien);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_so_luong);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(175, 163);
            this.txt_gia.Multiline = true;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(377, 41);
            this.txt_gia.TabIndex = 6;
            this.txt_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gia_KeyPress);
            // 
            // txt_so_luong
            // 
            this.txt_so_luong.Location = new System.Drawing.Point(175, 96);
            this.txt_so_luong.Multiline = true;
            this.txt_so_luong.Name = "txt_so_luong";
            this.txt_so_luong.Size = new System.Drawing.Size(377, 41);
            this.txt_so_luong.TabIndex = 5;
            this.txt_so_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_so_luong.TextChanged += new System.EventHandler(this.txt_so_luong_TextChanged);
            this.txt_so_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so_luong_KeyPress);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(175, 33);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(377, 41);
            this.txt_ten.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_tien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(469, 21);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(177, 70);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Kết thúc";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_reset.Location = new System.Drawing.Point(246, 22);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(177, 70);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Tiếp";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_tien
            // 
            this.btn_tien.Location = new System.Drawing.Point(17, 21);
            this.btn_tien.Name = "btn_tien";
            this.btn_tien.Size = new System.Drawing.Size(177, 70);
            this.btn_tien.TabIndex = 0;
            this.btn_tien.Text = "Thanh toán";
            this.btn_tien.UseVisualStyleBackColor = true;
            this.btn_tien.Click += new System.EventHandler(this.btn_tien_Click);
            // 
            // lb_thanh_tien
            // 
            this.lb_thanh_tien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_thanh_tien.Location = new System.Drawing.Point(170, 234);
            this.lb_thanh_tien.Name = "lb_thanh_tien";
            this.lb_thanh_tien.Size = new System.Drawing.Size(382, 46);
            this.lb_thanh_tien.TabIndex = 7;
            this.lb_thanh_tien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_tien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_reset;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tính tiền bán hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_so_luong;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_tien;
        private System.Windows.Forms.Label lb_thanh_tien;
    }
}

