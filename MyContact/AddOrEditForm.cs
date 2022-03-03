using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class AddOrEditForm : Form
    {
        private IContactRepository repository;
        public int contactID = 0;
        public AddOrEditForm()
        {

            InitializeComponent();
            repository = new ContactRepository();
        }
        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            if (contactID != 0)
            {
                DataTable dt = repository.SelectID(contactID);
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtFamily.Text = dt.Rows[0]["Family"].ToString();
                numDwnAge.Value = int.Parse(dt.Rows[0]["Age"].ToString());
                txtPhonNumber.Text = dt.Rows[0]["PhonNumber"].ToString();
                txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
            }
        }

        private void btnSubmitAddOrEdit_Click(object sender, EventArgs e)
        {

            if (contactID == 0)
            {

                if (validateInfo() == true)
                {
                    bool isSuccess = repository.Insert(txtName.Text, txtFamily.Text, (int)numDwnAge.Value, txtPhonNumber.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("عملیات انجام نشد...", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Focus();
                    }

                }

            }
            else
            {
                if (validateInfo() == true)
                {
                    bool isSuccess = repository.Edit(contactID, txtName.Text, txtFamily.Text, int.Parse(numDwnAge.Value.ToString()), txtPhonNumber.Text,txtMobile.Text, txtEmail.Text, txtAddress.Text);
                    if (isSuccess== true)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("خطا در ویرایش  اطلاعات....", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Focus();
                    }
                   
                }
            }


        }
        private bool validateInfo()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (txtFamily.Text == "")
            {

                MessageBox.Show("لطفا نام خانوادگی را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFamily.Focus();
                return false;
            }
            if (numDwnAge.Value == 0)
            {

                MessageBox.Show("لطفاسن را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDwnAge.Focus();
                return false;
            }
            if (txtPhonNumber.Text == "")
            {

                MessageBox.Show("لطفا شماره تلفن ثابت را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhonNumber.Focus();
                return false;
            }
            if (txtMobile.Text == "")
            {

                MessageBox.Show("لطفا شماره موبایل را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobile.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {

                MessageBox.Show("لطفا ایمیل را وارد نمائید....", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }


    }
}
