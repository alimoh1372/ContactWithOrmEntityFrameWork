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
            DataTable tblContacts = contacts.SelectAll();
            dgContactsInfo.DataSource = tblContacts;
        }

        private void dgContactsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
