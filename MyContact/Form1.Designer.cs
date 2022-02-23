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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.gbInfoContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.dgContactsInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContactsInfo_CellContentClick);
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
            // ContactMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 665);
            this.Controls.Add(this.gbInfoContact);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

