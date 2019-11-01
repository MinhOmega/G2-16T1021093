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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhToanCoBan));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
=======
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(180, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thắng Hoàng Phế Vật";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
=======
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính toán cơ bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a:";
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            // 
            // txtA
            // 
            this.txtA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
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
=======
            this.txtA.Location = new System.Drawing.Point(49, 52);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(318, 20);
            this.txtA.TabIndex = 3;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtB.Location = new System.Drawing.Point(194, 199);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(230, 22);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
=======
            this.txtB.Location = new System.Drawing.Point(49, 78);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(318, 20);
            this.txtB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "b:";
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            // 
            // btnCong
            // 
            this.btnCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< HEAD
            this.btnCong.Location = new System.Drawing.Point(143, 243);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(83, 36);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "Cộng";
=======
            this.btnCong.Location = new System.Drawing.Point(49, 105);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "Cộng";
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.BtnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< HEAD
            this.btnTru.Location = new System.Drawing.Point(256, 243);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(83, 36);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.Button2_Click);
=======
            this.btnTru.Location = new System.Drawing.Point(130, 105);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            // 
            // btnNhan
            // 
            this.btnNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< HEAD
            this.btnNhan.Location = new System.Drawing.Point(366, 243);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(83, 36);
            this.btnNhan.TabIndex = 7;
=======
            this.btnNhan.Location = new System.Drawing.Point(211, 105);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 6;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< HEAD
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
=======
            this.btnChia.Location = new System.Drawing.Point(292, 105);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 146);
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
<<<<<<< HEAD
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
=======
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trính tính toán cơ bản";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
=======
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
<<<<<<< HEAD
        private System.Windows.Forms.ErrorProvider errorProvider;
=======
        private System.Windows.Forms.ErrorProvider errProvider;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
    }
}

