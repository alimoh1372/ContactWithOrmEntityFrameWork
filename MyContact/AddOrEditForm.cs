using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class AddOrEditForm : Form
    {

        public int contactID;
        public AddOrEditForm()
        {

            InitializeComponent();
            contactID = 0;

        }
        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            if (contactID != 0)
            {
                using (ContactDbEntities db = new ContactDbEntities())
                {
                    
                    Person p = db.Persons.SingleOrDefault(per => per.ID == contactID);
                    txtName.Text = p.Name;
                    txtFamily.Text = p.Family;
                    numDwnAge.Value = p.Age;
                    txtPhonNumber.Text = p.PhonNumber;
                    txtMobile.Text = p.Mobile;
                    txtEmail.Text = p.Email;
                    txtAddress.Text = p.Address;
                    
                }

            }
        }



        private void btnSubmitAddOrEdit_Click(object sender, EventArgs e)
        {
            using (ContactDbEntities db = new ContactDbEntities())
            {


                if (contactID == 0)
                {

                    if (validateInfo() == true)
                    {
                        Random random = new Random();
                        Person p = new Person()
                        {
                            Name = txtName.Text,
                            Family = txtFamily.Text,
                            Age = Convert.ToInt32(numDwnAge.Value),
                            CityID = random.Next(1, 4),
                            PhonNumber = txtPhonNumber.Text,
                            Mobile = txtMobile.Text,
                            Email = txtEmail.Text,
                            Address = txtAddress.Text
                              
                        };
                        db.Persons.Add(p);
                        int isSuccess = db.SaveChanges();
                        if (isSuccess > 0)
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
                        Random random = new Random();
                        Person p = db.Persons.SingleOrDefault(p1 => p1.ID == contactID);
                        p.Name = txtName.Text;
                        p.Family = txtFamily.Text;
                        p.Age = Convert.ToInt32(numDwnAge.Value);
                        p.CityID = random.Next(1, 4);
                        p.PhonNumber = txtPhonNumber.Text;
                        p.Mobile = txtMobile.Text;
                        p.Email = txtEmail.Text;
                        p.Address = txtAddress.Text;
                        int isSuccess = 0;
                        try
                        {
                          isSuccess= db.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            foreach (var entityValidationErrors in ex.EntityValidationErrors)
                            {
                                foreach (var validationError in entityValidationErrors.ValidationErrors)
                                {
                                    MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                                }
                            }
                        }
                       
                        if (isSuccess > 0)
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
