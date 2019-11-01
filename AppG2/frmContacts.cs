using AppG2.Controller;
using AppG2.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppG2
{
    public partial class frmContacts : Form
    {
        #region Path data file
        String pathContactDataFile;
        
        #endregion 
        public frmContacts()
        {
            InitializeComponent();
            pathContactDataFile = Application.StartupPath + @"\Data\contacts.txt";
            loadDataContact();
        }

        public void loadDataContact()
        {
            bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;
            var listContact = ContactService.GetContact(pathContactDataFile);
            var listContactSort = listContact.OrderBy(a => a.nameContact);
            if (listContactSort == null)
            {
                throw new Exception("Không tồn tại sinh viên này");
            }
            else
            {
                bdsContact.DataSource = listContactSort;
            }
            
            dtgContact.DataSource = bdsContact;
        }


        private void DtgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc là muốn xóa quá trình học tập này không?",
                "Thông báo"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {

                var contact = (Contact)bdsContact.Current;

                //var contactID = dtgContact.CurrentRow.Cells[1].Value.ToString();
                var idContact = contact.iDContact;
                ContactService.DeleteContact(pathContactDataFile, idContact);

                loadDataContact();
               

                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //frmContactChiTiet frm1 = new frmContactChiTiet(null, pathContactDataFile);
            //frm1.Show();
            var f = new frmContactChiTiet(null, pathContactDataFile);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadDataContact();
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var contact = bdsContact.Current as Contact;
            if(contact != null)
            {
                var f = new frmContactChiTiet(contact, pathContactDataFile);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadDataContact();
                }
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;
            
            var listContact = ContactService.GetContactBySearch(pathContactDataFile, txtSearch.Text);   
            var listContactSort = listContact.OrderBy(a => a.nameContact);
            if (listContactSort == null)
            {
                throw new Exception("Không tồn tại sinh viên này");
            }
            else
            {
                bdsContact.DataSource = listContactSort;
            
            }

            dtgContact.DataSource = bdsContact;*/
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;

            var listContact = ContactService.GetContactBySearch(pathContactDataFile, txtSearch.Text);
            var listContactSort = listContact.OrderBy(a => a.nameContact);
            if (listContactSort == null)
            {
                throw new Exception("Không tồn tại sinh viên này");
            }
            else
            {
                bdsContact.DataSource = listContactSort;

            }

            dtgContact.DataSource = bdsContact;
        }

        private void A_Click(object sender, EventArgs e)
        {
            bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;

            var listContact = ContactService.GetContactChar(pathContactDataFile, A.Text);
            var listContactSort = listContact.OrderBy(a => a.nameContact);
            if (listContactSort == null)
            {
                throw new Exception("Không tồn tại sinh viên này");
            }
            else
            {
                bdsContact.DataSource = listContactSort;

            }

            dtgContact.DataSource = bdsContact;
        }
    }
}
