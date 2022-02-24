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
            dgContactsInfo.DataSource = contacts.SelectAll();
        }


    }
}
