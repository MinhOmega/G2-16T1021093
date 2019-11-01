namespace AppG2
{
    partial class frmTinhToanCoBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(180, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thắng Hoàng Phế Vật";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtA
            // 
            this.txtA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtA.Location = new System.Drawing.Point(194, 154);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(230, 22);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "a";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "b";
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB.Location = new System.Drawing.Point(194, 199);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(230, 22);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCong.Location = new System.Drawing.Point(143, 243);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(83, 36);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.BtnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTru.Location = new System.Drawing.Point(256, 243);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(83, 36);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNhan.Location = new System.Drawing.Point(366, 243);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(83, 36);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChia.Location = new System.Drawing.Point(477, 243);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(83, 36);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tính cơ bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

