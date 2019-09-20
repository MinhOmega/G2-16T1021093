namespace AppG2
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.fBdImage = new System.Windows.Forms.FolderBrowserDialog();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_NdLstB = new System.Windows.Forms.Label();
            this.lb_NdDelay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_slideshow = new System.Windows.Forms.Button();
            this.btn_Loadimg = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delay
            // 
            this.Delay.Enabled = true;
            this.Delay.Interval = 3000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "Screenshot (1).png");
            this.imgLst.Images.SetKeyName(1, "Screenshot (2).png");
            this.imgLst.Images.SetKeyName(2, "Screenshot (3).png");
            this.imgLst.Images.SetKeyName(3, "Screenshot (4).png");
            this.imgLst.Images.SetKeyName(4, "Screenshot (5).png");
            this.imgLst.Images.SetKeyName(5, "Screenshot (6).png");
            this.imgLst.Images.SetKeyName(6, "Screenshot (7).png");
            this.imgLst.Images.SetKeyName(7, "Screenshot (8).png");
            this.imgLst.Images.SetKeyName(8, "Screenshot (9).png");
            this.imgLst.Images.SetKeyName(9, "Screenshot (10).png");
            this.imgLst.Images.SetKeyName(10, "Screenshot (11).png");
            this.imgLst.Images.SetKeyName(11, "Screenshot (12).png");
            this.imgLst.Images.SetKeyName(12, "Screenshot (13).png");
            this.imgLst.Images.SetKeyName(13, "Screenshot (14).png");
            this.imgLst.Images.SetKeyName(14, "Screenshot (15).png");
            this.imgLst.Images.SetKeyName(15, "Screenshot (16).png");
            this.imgLst.Images.SetKeyName(16, "Screenshot (17).png");
            this.imgLst.Images.SetKeyName(17, "Screenshot (18).png");
            this.imgLst.Images.SetKeyName(18, "Screenshot (19).png");
            this.imgLst.Images.SetKeyName(19, "Screenshot (20).png");
            this.imgLst.Images.SetKeyName(20, "Screenshot (21).png");
            this.imgLst.Images.SetKeyName(21, "Screenshot (22).png");
            this.imgLst.Images.SetKeyName(22, "Screenshot (23).png");
            this.imgLst.Images.SetKeyName(23, "Screenshot (24).png");
            this.imgLst.Images.SetKeyName(24, "Screenshot (25).png");
            this.imgLst.Images.SetKeyName(25, "Screenshot (26).png");
            this.imgLst.Images.SetKeyName(26, "Screenshot (27).png");
            this.imgLst.Images.SetKeyName(27, "Screenshot (28).png");
            this.imgLst.Images.SetKeyName(28, "Screenshot (29).png");
            this.imgLst.Images.SetKeyName(29, "Screenshot (30).png");
            this.imgLst.Images.SetKeyName(30, "Screenshot (31).png");
            this.imgLst.Images.SetKeyName(31, "Screenshot (32).png");
            this.imgLst.Images.SetKeyName(32, "Screenshot (33).png");
            this.imgLst.Images.SetKeyName(33, "Screenshot (34).png");
            this.imgLst.Images.SetKeyName(34, "Screenshot (35).png");
            this.imgLst.Images.SetKeyName(35, "Screenshot (36).png");
            this.imgLst.Images.SetKeyName(36, "Screenshot (37).png");
            this.imgLst.Images.SetKeyName(37, "Screenshot (38).png");
            this.imgLst.Images.SetKeyName(38, "Screenshot (39).png");
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(102, 351);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(594, 56);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // lb_NdLstB
            // 
            this.lb_NdLstB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NdLstB.AutoSize = true;
            this.lb_NdLstB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_NdLstB.Location = new System.Drawing.Point(4, 369);
            this.lb_NdLstB.Name = "lb_NdLstB";
            this.lb_NdLstB.Size = new System.Drawing.Size(92, 15);
            this.lb_NdLstB.TabIndex = 5;
            this.lb_NdLstB.Text = "Đường dẫn ảnh";
            // 
            // lb_NdDelay
            // 
            this.lb_NdDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NdDelay.AutoSize = true;
            this.lb_NdDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_NdDelay.Location = new System.Drawing.Point(201, 416);
            this.lb_NdDelay.Name = "lb_NdDelay";
            this.lb_NdDelay.Size = new System.Drawing.Size(44, 17);
            this.lb_NdDelay.TabIndex = 5;
            this.lb_NdDelay.Text = "Delay";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_previous.Enabled = false;
            this.btn_previous.Image = global::AppG2.Properties.Resources.iconfinder_previous_925904__1_;
            this.btn_previous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_previous.ImageKey = "(none)";
            this.btn_previous.Location = new System.Drawing.Point(12, 130);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(25, 25);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // btn_slideshow
            // 
            this.btn_slideshow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_slideshow.Image = global::AppG2.Properties.Resources.iconfinder_tv_show_172610;
            this.btn_slideshow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_slideshow.Location = new System.Drawing.Point(398, 412);
            this.btn_slideshow.Name = "btn_slideshow";
            this.btn_slideshow.Size = new System.Drawing.Size(94, 29);
            this.btn_slideshow.TabIndex = 4;
            this.btn_slideshow.Text = "Slide Show";
            this.btn_slideshow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_slideshow.UseVisualStyleBackColor = true;
            this.btn_slideshow.Click += new System.EventHandler(this.Btn_slideshow_Click);
            // 
            // btn_Loadimg
            // 
            this.btn_Loadimg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Loadimg.Image = global::AppG2.Properties.Resources.iconfinder_179_Upload_183298;
            this.btn_Loadimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Loadimg.Location = new System.Drawing.Point(339, 281);
            this.btn_Loadimg.Name = "btn_Loadimg";
            this.btn_Loadimg.Size = new System.Drawing.Size(94, 29);
            this.btn_Loadimg.TabIndex = 2;
            this.btn_Loadimg.Text = "Load Image";
            this.btn_Loadimg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Loadimg.UseVisualStyleBackColor = true;
            this.btn_Loadimg.Click += new System.EventHandler(this.Btn_Loadimg_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_next.Enabled = false;
            this.btn_next.Image = global::AppG2.Properties.Resources.iconfinder_next_925898__1_;
            this.btn_next.Location = new System.Drawing.Point(763, 130);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(25, 25);
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot (1).png");
            this.imageList1.Images.SetKeyName(1, "Screenshot (2).png");
            this.imageList1.Images.SetKeyName(2, "Screenshot (3).png");
            this.imageList1.Images.SetKeyName(3, "Screenshot (4).png");
            this.imageList1.Images.SetKeyName(4, "Screenshot (5).png");
            this.imageList1.Images.SetKeyName(5, "Screenshot (6).png");
            this.imageList1.Images.SetKeyName(6, "Screenshot (7).png");
            this.imageList1.Images.SetKeyName(7, "Screenshot (8).png");
            this.imageList1.Images.SetKeyName(8, "Screenshot (9).png");
            this.imageList1.Images.SetKeyName(9, "Screenshot (10).png");
            this.imageList1.Images.SetKeyName(10, "Screenshot (11).png");
            this.imageList1.Images.SetKeyName(11, "Screenshot (12).png");
            this.imageList1.Images.SetKeyName(12, "Screenshot (13).png");
            this.imageList1.Images.SetKeyName(13, "Screenshot (14).png");
            this.imageList1.Images.SetKeyName(14, "Screenshot (15).png");
            this.imageList1.Images.SetKeyName(15, "Screenshot (16).png");
            this.imageList1.Images.SetKeyName(16, "Screenshot (17).png");
            this.imageList1.Images.SetKeyName(17, "Screenshot (18).png");
            this.imageList1.Images.SetKeyName(18, "Screenshot (19).png");
            this.imageList1.Images.SetKeyName(19, "Screenshot (20).png");
            this.imageList1.Images.SetKeyName(20, "Screenshot (21).png");
            this.imageList1.Images.SetKeyName(21, "Screenshot (22).png");
            this.imageList1.Images.SetKeyName(22, "Screenshot (23).png");
            this.imageList1.Images.SetKeyName(23, "Screenshot (24).png");
            this.imageList1.Images.SetKeyName(24, "Screenshot (25).png");
            this.imageList1.Images.SetKeyName(25, "Screenshot (26).png");
            this.imageList1.Images.SetKeyName(26, "Screenshot (27).png");
            this.imageList1.Images.SetKeyName(27, "Screenshot (28).png");
            this.imageList1.Images.SetKeyName(28, "Screenshot (29).png");
            this.imageList1.Images.SetKeyName(29, "Screenshot (30).png");
            this.imageList1.Images.SetKeyName(30, "Screenshot (31).png");
            this.imageList1.Images.SetKeyName(31, "Screenshot (32).png");
            this.imageList1.Images.SetKeyName(32, "Screenshot (33).png");
            this.imageList1.Images.SetKeyName(33, "Screenshot (34).png");
            this.imageList1.Images.SetKeyName(34, "Screenshot (35).png");
            this.imageList1.Images.SetKeyName(35, "Screenshot (36).png");
            this.imageList1.Images.SetKeyName(36, "Screenshot (37).png");
            this.imageList1.Images.SetKeyName(37, "Screenshot (38).png");
            this.imageList1.Images.SetKeyName(38, "Screenshot (39).png");
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_NdDelay);
            this.Controls.Add(this.lb_NdLstB);
            this.Controls.Add(this.btn_slideshow);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Loadimg);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fBdImage;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_Loadimg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_slideshow;
        private System.Windows.Forms.Label lb_NdLstB;
        private System.Windows.Forms.Label lb_NdDelay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}