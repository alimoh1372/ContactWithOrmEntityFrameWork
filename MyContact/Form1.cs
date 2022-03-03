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
        
        
        public ContactMainForm()
        {
            InitializeComponent(); 
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
            using (ContactDbEntities db = new ContactDbEntities())
            {
                dgContactsInfo.AutoGenerateColumns = false;
                dgContactsInfo.Columns[0].Visible = false;
                dgContactsInfo.DataSource = db.Persons.ToList();
            }
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
                    
                    using (ContactDbEntities db =new ContactDbEntities())
                    {
                        Person p = new Person();
                        p = db.Persons.Find(contactID);
                        if (p!=null)
                        {
                            db.Persons.Remove(p);
                            int result = db.SaveChanges();
                            if (result >0)
                            {
                                MessageBox.Show(string.Format(".اطلاعات {0} {1} از لیست مخاطبین حذف گردید", name, family), "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshMycontactGriedview();
                            }
                            else
                            {
                                MessageBox.Show(string.Format("با عرض پوزش ، به علت بروز خطا حذف انجام نگردید لطفا مجددا تلاش فرمائید.با تشکر..."), "عدم انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Format("اطلاعات مخاطب مورد نظر یافت نشد."), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    
                  

                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص(ردیف)را انتخاب نمائید...", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (ContactDbEntities db = new ContactDbEntities())
            {
                dgContactsInfo.DataSource = db.Persons.Where(p => p.Name.Contains(txtSearch.Text) || p.Family.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
