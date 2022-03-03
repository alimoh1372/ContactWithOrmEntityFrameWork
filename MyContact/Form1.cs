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
    public partial class ContactMainForm : Form
    {
        IContactRepository contacts;
        
        public ContactMainForm()
        {
            InitializeComponent();
            contacts = new ContactRepository();
            
        }

        private void ContactMainForm_Load(object sender, EventArgs e)
        {
            refreshMycontactGriedview();
        }


        private void tlstbtnRefresh_Click(object sender, EventArgs e)
        {
            refreshMycontactGriedview();
        }
        private void tlstbtnAdd_Click(object sender, EventArgs e)
        {
            AddOrEditForm frmAdd = new AddOrEditForm();
            frmAdd.Text = "افزودن شخص جدید";
            frmAdd.ShowDialog();
            if (frmAdd.DialogResult==DialogResult.OK)
            {
                refreshMycontactGriedview();
                frmAdd.Close();
            }

        }
        private void refreshMycontactGriedview()
        {
            dgContactsInfo.AutoGenerateColumns = false;
            dgContactsInfo.Columns[0].Visible = false;
            dgContactsInfo.DataSource = contacts.SelectAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContactsInfo.CurrentRow!=null)
            {
                
                AddOrEditForm frm1 = new AddOrEditForm();
                frm1.contactID=Convert.ToInt32(dgContactsInfo.CurrentRow.Cells[0].Value);
                frm1.Text = "ویرایش مخاطب";
                frm1.ShowDialog();
                if (frm1.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("اصلاح مشخصات مخاطب مورد نظر با موفقیت انجام گردید...", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshMycontactGriedview();
                    frm1.Close();
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContactsInfo.CurrentRow != null)
            {
                string name = dgContactsInfo.CurrentRow.Cells[1].Value.ToString();
                string family = dgContactsInfo.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show($"مطمئن هستید؟ {family} {name} آیا از حذف ","حذف مخاطب؟",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int contactID =Convert.ToInt32( dgContactsInfo.CurrentRow.Cells[0].Value);
                    bool result= contacts.Delet(contactID);
                    if (result==true)
                    {
                        MessageBox.Show(string.Format(".اطلاعات {0} {1} از لیست مخاطبین حذف گردید", name, family), "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("با عرض پوزش ، به علت بروز خطا حذف انجام نگردید لطفا مجددا تلاش فرمائید.با تشکر...", name, family), "عدم انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص(ردیف)را انتخاب نمائید...", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbInfoContact_Enter(object sender, EventArgs e)
        {

        }
    }
}
