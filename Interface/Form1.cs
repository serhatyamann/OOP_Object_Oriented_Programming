using Interface.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        ContactRepository repo;
        public Form1()
        {
            InitializeComponent();
            repo = new ContactRepository(); //We created an instance from ContactRepository when Form1 calls its own constructor.
        }

        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            repo.CreateContact(int.Parse(txtID.Text), txtFirstName.Text, txtLastName.Text, txtPhone.Text);
            RefreshGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            repo.DeleteContact(int.Parse(txtID.Text));
            RefreshGridView();
        }

        void RefreshGridView()
        {
            dgvContacts.Refresh();
            dgvContacts.DataSource = repo.GetContacts();
        }
    }
}
