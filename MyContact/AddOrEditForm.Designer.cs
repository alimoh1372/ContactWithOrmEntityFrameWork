namespace MyContact
{
    partial class AddOrEditForm
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
            this.gbAddOrEdit = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.numDwnAge = new System.Windows.Forms.NumericUpDown();
            this.txtPhonNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmitAddOrEdit = new System.Windows.Forms.Button();
            this.gbAddOrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDwnAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddOrEdit
            // 
            this.gbAddOrEdit.Controls.Add(this.txtAddress);
            this.gbAddOrEdit.Controls.Add(this.lblAddress);
            this.gbAddOrEdit.Controls.Add(this.txtEmail);
            this.gbAddOrEdit.Controls.Add(this.lblEmail);
            this.gbAddOrEdit.Controls.Add(this.txtMobile);
            this.gbAddOrEdit.Controls.Add(this.lblMobile);
            this.gbAddOrEdit.Controls.Add(this.numDwnAge);
            this.gbAddOrEdit.Controls.Add(this.txtPhonNumber);
            this.gbAddOrEdit.Controls.Add(this.label1);
            this.gbAddOrEdit.Controls.Add(this.lblAge);
            this.gbAddOrEdit.Controls.Add(this.txtFamily);
            this.gbAddOrEdit.Controls.Add(this.lblLastName);
            this.gbAddOrEdit.Controls.Add(this.txtName);
            this.gbAddOrEdit.Controls.Add(this.lblName);
            this.gbAddOrEdit.Location = new System.Drawing.Point(12, 6);
            this.gbAddOrEdit.Name = "gbAddOrEdit";
            this.gbAddOrEdit.Size = new System.Drawing.Size(473, 211);
            this.gbAddOrEdit.TabIndex = 0;
            this.gbAddOrEdit.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 133);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(410, 72);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(422, 136);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 16);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "آدرس :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(410, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(422, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "ایمیل :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(133, 75);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(191, 23);
            this.txtMobile.TabIndex = 5;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(330, 82);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(51, 16);
            this.lblMobile.TabIndex = 9;
            this.lblMobile.Text = "موبایل :";
            // 
            // numDwnAge
            // 
            this.numDwnAge.Location = new System.Drawing.Point(261, 46);
            this.numDwnAge.Name = "numDwnAge";
            this.numDwnAge.Size = new System.Drawing.Size(155, 23);
            this.numDwnAge.TabIndex = 3;
            // 
            // txtPhonNumber
            // 
            this.txtPhonNumber.Location = new System.Drawing.Point(6, 45);
            this.txtPhonNumber.Name = "txtPhonNumber";
            this.txtPhonNumber.Size = new System.Drawing.Size(155, 23);
            this.txtPhonNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "تلفن ثابت :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(422, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "سن :";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(6, 16);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(155, 23);
            this.txtFamily.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(167, 19);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(422, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام :";
            // 
            // btnSubmitAddOrEdit
            // 
            this.btnSubmitAddOrEdit.Location = new System.Drawing.Point(145, 223);
            this.btnSubmitAddOrEdit.Name = "btnSubmitAddOrEdit";
            this.btnSubmitAddOrEdit.Size = new System.Drawing.Size(191, 41);
            this.btnSubmitAddOrEdit.TabIndex = 8;
            this.btnSubmitAddOrEdit.Text = "ثبت";
            this.btnSubmitAddOrEdit.UseVisualStyleBackColor = true;
            this.btnSubmitAddOrEdit.Click += new System.EventHandler(this.btnSubmitAddOrEdit_Click);
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 276);
            this.Controls.Add(this.btnSubmitAddOrEdit);
            this.Controls.Add(this.gbAddOrEdit);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gbAddOrEdit.ResumeLayout(false);
            this.gbAddOrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDwnAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddOrEdit;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.NumericUpDown numDwnAge;
        private System.Windows.Forms.TextBox txtPhonNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmitAddOrEdit;
    }
}