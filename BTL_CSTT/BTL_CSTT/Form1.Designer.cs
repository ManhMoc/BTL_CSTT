namespace BTL_CSTT
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabP1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtNguonTin = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.pel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNP = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabP2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDE = new System.Windows.Forms.Button();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.pel2 = new System.Windows.Forms.Panel();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab1.SuspendLayout();
            this.tabP1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabP2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabP1);
            this.tab1.Controls.Add(this.tabP2);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(800, 450);
            this.tab1.TabIndex = 0;
            // 
            // tabP1
            // 
            this.tabP1.Controls.Add(this.panel1);
            this.tabP1.Controls.Add(this.pel);
            this.tabP1.Controls.Add(this.label4);
            this.tabP1.Controls.Add(this.btnNP);
            this.tabP1.Controls.Add(this.txtN);
            this.tabP1.Controls.Add(this.label1);
            this.tabP1.Location = new System.Drawing.Point(4, 22);
            this.tabP1.Name = "tabP1";
            this.tabP1.Padding = new System.Windows.Forms.Padding(3);
            this.tabP1.Size = new System.Drawing.Size(792, 424);
            this.tabP1.TabIndex = 0;
            this.tabP1.Text = "Mã hóa";
            this.tabP1.UseVisualStyleBackColor = true;
            this.tabP1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEncode);
            this.panel1.Controls.Add(this.txtNguonTin);
            this.panel1.Controls.Add(this.btnEncode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 162);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập nguồn tin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tin bị mã hóa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEncode
            // 
            this.txtEncode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEncode.Enabled = false;
            this.txtEncode.Location = new System.Drawing.Point(232, 126);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(412, 20);
            this.txtEncode.TabIndex = 8;
            // 
            // txtNguonTin
            // 
            this.txtNguonTin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNguonTin.Location = new System.Drawing.Point(232, 35);
            this.txtNguonTin.Name = "txtNguonTin";
            this.txtNguonTin.Size = new System.Drawing.Size(412, 20);
            this.txtNguonTin.TabIndex = 4;
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEncode.Location = new System.Drawing.Point(348, 73);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(128, 37);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.Text = "Ấn để mã hóa";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // pel
            // 
            this.pel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pel.BackColor = System.Drawing.Color.Silver;
            this.pel.Location = new System.Drawing.Point(3, 74);
            this.pel.Name = "pel";
            this.pel.Size = new System.Drawing.Size(789, 179);
            this.pel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // btnNP
            // 
            this.btnNP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNP.Location = new System.Drawing.Point(449, 22);
            this.btnNP.Name = "btnNP";
            this.btnNP.Size = new System.Drawing.Size(222, 23);
            this.btnNP.TabIndex = 2;
            this.btnNP.Text = "Nhập các lớp tin và xác suất tương ứng";
            this.btnNP.UseVisualStyleBackColor = true;
            this.btnNP.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN
            // 
            this.txtN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtN.Location = new System.Drawing.Point(235, 22);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(179, 20);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số lớp tin của nguồn tin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabP2
            // 
            this.tabP2.Controls.Add(this.panel2);
            this.tabP2.Controls.Add(this.pel2);
            this.tabP2.Controls.Add(this.btnNhap);
            this.tabP2.Controls.Add(this.txtN2);
            this.tabP2.Controls.Add(this.label3);
            this.tabP2.Location = new System.Drawing.Point(4, 22);
            this.tabP2.Name = "tabP2";
            this.tabP2.Padding = new System.Windows.Forms.Padding(3);
            this.tabP2.Size = new System.Drawing.Size(792, 424);
            this.tabP2.TabIndex = 1;
            this.tabP2.Text = "Giải Mã";
            this.tabP2.UseVisualStyleBackColor = true;
            this.tabP2.Click += new System.EventHandler(this.tabP2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDE);
            this.panel2.Controls.Add(this.txtLeng);
            this.panel2.Controls.Add(this.txtKq);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNhap);
            this.panel2.Location = new System.Drawing.Point(3, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 162);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(23, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập tin cần giải mã";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnDE
            // 
            this.btnDE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDE.Location = new System.Drawing.Point(602, 70);
            this.btnDE.Name = "btnDE";
            this.btnDE.Size = new System.Drawing.Size(87, 23);
            this.btnDE.TabIndex = 9;
            this.btnDE.Text = "Ấn để giải mã";
            this.btnDE.UseVisualStyleBackColor = true;
            this.btnDE.Click += new System.EventHandler(this.btnDE_Click);
            // 
            // txtLeng
            // 
            this.txtLeng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeng.Location = new System.Drawing.Point(226, 73);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(257, 20);
            this.txtLeng.TabIndex = 11;
            this.txtLeng.TextChanged += new System.EventHandler(this.txtLeng_TextChanged);
            // 
            // txtKq
            // 
            this.txtKq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKq.Location = new System.Drawing.Point(226, 121);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(257, 20);
            this.txtKq.TabIndex = 8;
            this.txtKq.TextChanged += new System.EventHandler(this.txtKq_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(24, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nhập chiều dài tin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(24, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tin sau khi giải mã ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhap
            // 
            this.txtNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhap.Location = new System.Drawing.Point(226, 30);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(257, 20);
            this.txtNhap.TabIndex = 6;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // pel2
            // 
            this.pel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pel2.BackColor = System.Drawing.Color.Silver;
            this.pel2.Location = new System.Drawing.Point(1, 71);
            this.pel2.Name = "pel2";
            this.pel2.Size = new System.Drawing.Size(791, 185);
            this.pel2.TabIndex = 4;
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhap.Location = new System.Drawing.Point(438, 25);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(220, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập các lớp tin và xác suất tương ứng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtN2
            // 
            this.txtN2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtN2.Location = new System.Drawing.Point(229, 25);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(152, 20);
            this.txtN2.TabIndex = 2;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập số lớp tin của nguồn tin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mã hóa số học";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.tabP1.ResumeLayout(false);
            this.tabP1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabP2.ResumeLayout(false);
            this.tabP2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabP1;
        private System.Windows.Forms.TabPage tabP2;
        private System.Windows.Forms.Button btnNP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguonTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pel;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pel2;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDE;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

