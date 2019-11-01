namespace AppG2
{
    partial class frmContacts
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgContact = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsContact = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(111, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(394, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(495, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(596, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dtgContact
            // 
            this.dtgContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgContact.Location = new System.Drawing.Point(111, 187);
            this.dtgContact.MultiSelect = false;
            this.dtgContact.Name = "dtgContact";
            this.dtgContact.RowHeadersWidth = 51;
            this.dtgContact.RowTemplate.Height = 24;
            this.dtgContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContact.Size = new System.Drawing.Size(571, 314);
            this.dtgContact.TabIndex = 101;
            this.dtgContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgContact_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "firstCharacter";
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 24;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nameContact";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "phoneContact";
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "emailContact";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(328, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 102;
            this.label1.Text = "Contacts";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(596, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 35);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A.Location = new System.Drawing.Point(707, 187);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(17, 17);
            this.A.TabIndex = 104;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D.Location = new System.Drawing.Point(707, 254);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(18, 17);
            this.D.TabIndex = 105;
            this.D.Text = "D";
            this.D.Click += new System.EventHandler(this.A_Click);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 574);
            this.Controls.Add(this.D);
            this.Controls.Add(this.A);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgContact);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmContacts";
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgContact;
        private System.Windows.Forms.BindingSource bdsContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label D;
    }
}