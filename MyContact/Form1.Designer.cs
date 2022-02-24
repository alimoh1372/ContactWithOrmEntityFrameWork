namespace MyContact
{
    partial class ContactMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactMainForm));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbInfoContact = new System.Windows.Forms.GroupBox();
            this.dgContactsInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlstbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tlstbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.gbInfoContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsInfo)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Location = new System.Drawing.Point(0, 33);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSearch.Size = new System.Drawing.Size(1237, 123);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "جست و جو";
            // 
            // gbInfoContact
            // 
            this.gbInfoContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoContact.Controls.Add(this.dgContactsInfo);
            this.gbInfoContact.Location = new System.Drawing.Point(0, 163);
            this.gbInfoContact.Name = "gbInfoContact";
            this.gbInfoContact.Size = new System.Drawing.Size(1237, 490);
            this.gbInfoContact.TabIndex = 2;
            this.gbInfoContact.TabStop = false;
            this.gbInfoContact.Text = "اطلاعات مخاطبان";
            // 
            // dgContactsInfo
            // 
            this.dgContactsInfo.AllowUserToAddRows = false;
            this.dgContactsInfo.AllowUserToDeleteRows = false;
            this.dgContactsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContactsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ContactName,
            this.Family,
            this.Age,
            this.PhonNumber,
            this.Mobile,
            this.Email,
            this.Address});
            this.dgContactsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgContactsInfo.Location = new System.Drawing.Point(3, 20);
            this.dgContactsInfo.Name = "dgContactsInfo";
            this.dgContactsInfo.ReadOnly = true;
            this.dgContactsInfo.Size = new System.Drawing.Size(1231, 467);
            this.dgContactsInfo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد شخص";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "Name";
            this.ContactName.HeaderText = "نام";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "سن";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // PhonNumber
            // 
            this.PhonNumber.DataPropertyName = "PhonNumber";
            this.PhonNumber.HeaderText = "شماره تلفن ثابت";
            this.PhonNumber.Name = "PhonNumber";
            this.PhonNumber.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstbtnAdd,
            this.tlstbtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1237, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlstbtnAdd
            // 
            this.tlstbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlstbtnAdd.Image")));
            this.tlstbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstbtnAdd.Name = "tlstbtnAdd";
            this.tlstbtnAdd.Size = new System.Drawing.Size(106, 22);
            this.tlstbtnAdd.Text = "افزودن شخص جدید";
            this.tlstbtnAdd.Click += new System.EventHandler(this.tlstbtnAdd_Click);
            // 
            // tlstbtnRefresh
            // 
            this.tlstbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlstbtnRefresh.Image")));
            this.tlstbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstbtnRefresh.Name = "tlstbtnRefresh";
            this.tlstbtnRefresh.Size = new System.Drawing.Size(150, 22);
            this.tlstbtnRefresh.Text = "بروزرسانی اطلاعات مخاطبین";
            this.tlstbtnRefresh.Click += new System.EventHandler(this.tlstbtnRefresh_Click);
            // 
            // ContactMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 665);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbInfoContact);
            this.Controls.Add(this.gbSearch);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.ContactMainForm_Load);
            this.gbInfoContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsInfo)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbInfoContact;
        private System.Windows.Forms.DataGridView dgContactsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlstbtnAdd;
        private System.Windows.Forms.ToolStripButton tlstbtnRefresh;
    }
}

