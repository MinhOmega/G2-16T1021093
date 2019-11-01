using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2
{
    
    public partial class frmContactChiTiet : Form
    {
        Contact contact;
        string pathContactDataFile;
        public frmContactChiTiet(Contact contact = null, string pathContactFile = null)
        {
            InitializeComponent();
            this.contact = contact;
            this.pathContactDataFile = pathContactFile;
            if(contact != null)
            {
                this.Text = "Chỉnh sửa contact";
                txtName.Text = contact.nameContact;
                txtPhone.Text = contact.phoneContact;
                txtEmail.Text = contact.emailContact;
                
                
            }
            else
            {
                this.Text = "Thêm contact";
            }
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if(contact != null)
            {
                var name = txtName.Text;
                var phone = txtPhone.Text;
                var email = txtEmail.Text;
                ContactService.EditContact(contact.iDContact, pathContactDataFile, name, phone, email);
            }
            else
            {
                var name = txtName.Text;
                var phone = txtPhone.Text;
                var email = txtEmail.Text;
                ContactService.CreateContact(pathContactDataFile, name, phone, email);
            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;//thuộc tính có sự thay đổi -> sẽ đóng lại
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
