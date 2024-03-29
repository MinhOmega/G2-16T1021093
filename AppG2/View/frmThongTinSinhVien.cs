<<<<<<< HEAD
﻿using System;
=======
﻿using AppG2.Controllor;
using System;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Controller;
using AppG2.Model;
=======
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac

namespace AppG2.View
{
    public partial class frmThongTinSinhVien : Form
    {
<<<<<<< HEAD
        #region variables for process Image Avatar
        Image image;
        string maSinhVien;
        
        string pathDirectoryImg;
        string pathAvatarImg;
        #endregion

        #region Path data file
        String pathStudentDataFile;
        String pathLearningHistoryDataFile;
        #endregion

        public frmThongTinSinhVien(string maSinhVien)
        {
            InitializeComponent();
            this.maSinhVien = maSinhVien;
            pathDirectoryImg = Application.StartupPath + "/Img";
            pathAvatarImg = pathDirectoryImg + "/avatar.png";
            lnkChonAnhDaiDien.AllowDrop = true;

            pathStudentDataFile = Application.StartupPath + @"\Data\student.txt";
            pathLearningHistoryDataFile = Application.StartupPath + @"\Data\learninghistory.txt";

            if (File.Exists(pathAvatarImg))
            {
                FileStream fileStream = new FileStream(pathAvatarImg, FileMode.Open, FileAccess.Read);
                //image = Image.FromFile(fileStream);
                lnkChonAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
            loadDataHistory(maSinhVien);
        }
        public void loadDataHistory(string maSinhVien)
        {
            //bds de luu data trung gian, sau do dung bds de do vao datagridview
            bdsQuaTrinhHocTap.DataSource = null;
            dtgQuaTrinhHocTap.AutoGenerateColumns = false; // để mình tự tạo chứ ko phải máy tạo

            //var student = StudentService.GetStudent(maSinhVien);
            var student = StudentService.GetStudent(pathStudentDataFile, maSinhVien);
            if (student == null)
            {
                throw new Exception("Không tồn tại sinh viên này");
            }
            else
            {
                student.ListHistoryLearning = StudentService.GetHistoryLearnings(pathLearningHistoryDataFile, maSinhVien);
                txtMSV.Text = student.IDStudent;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                txtQueQuan.Text = student.POB;
                DTPNgaySinh.Value = student.DOB;
=======
        #region Variables to process Image Avatar 
        Image image;
        string pathDirectoryImg;
        string pathAvatarImg;
        #endregion
        /// <summary>
        /// hàm khởi tạo cho frmTTSV
        /// </summary>
        public frmThongTinSinhVien(string maSinhVien)
        {
            InitializeComponent();
            pathDirectoryImg = Application.StartupPath + "\\Img";
            pathAvatarImg = pathDirectoryImg + "\\avatar.png";
            picAnhDaiDien.AllowDrop = true;
            if (File.Exists(pathAvatarImg))
            {
                FileStream fileStream = new FileStream(pathAvatarImg, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
            bdsQuaTrinhHocTap.DataSource = null; // khởi tạo giá trị null nếu ban đầu chưa có gì
            dtgQuaTrinhHocTap.AutoGenerateColumns = false; //tắt chế độ tự tạo cột, 
            var student = StudentService.GetStudent(maSinhVien);
            //hàm kiểm tra sinh viên
            if (student == null)
                throw new Exception("Không tồn tại sinh viên này");
            else
            {
                txtMaSinhVien.Text = student.IDStudent;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                txtQueQuan.Text = student.POB;
                dtpNgaySinh.Value = student.DOB;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
                chkGioiTinh.Checked = student.Gender == Model.GENDER.Male;
                if (student.ListHistoryLearning != null)
                {
                    bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
<<<<<<< HEAD
                    
                    // lưu trữ lên bộ nhớ RAM
                    // để hiển thị mượt hơn
                }
            }
            dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
            //hiển thị ra
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmThongTinSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "File ảnh|*.png;*.jpg"; //mô tả | định dạng
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {

                image = Image.FromFile(openFileDialog.FileName);
                lnkChonAnhDaiDien.Image = image;
                // từ đường dẫn openfIledialog.filename tạo ra 1 cái Image rồi gán lnkChonAnh vào image
=======
                }
                dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
            }
        }

        private void LnkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "File ảnh(*.png, *.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                picAnhDaiDien.Image = image;
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            #region Cập nhật hình đại diện
            bool imageSave = false;
            if(image!=null) // lưu ảnh vào thư mục cần
            {
                //đầu tiên phải thêm thư viện system.IO
                //string pathDirectory = Application.StartupPath + "/Img";// trả về thư mục chứa ứng dụng
=======
            #region Cập nhật hình đại diện
            bool imageSave = false;
            if (image != null)
            {
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
                if (!Directory.Exists(pathDirectoryImg))
                {
                    Directory.CreateDirectory(pathDirectoryImg);
                }
                image.Save(pathAvatarImg);
                imageSave = true;
            }
            #endregion
<<<<<<< HEAD
            if(imageSave)
            {
                MessageBox.Show("Đã cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LnkChonAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var rs = (string[])e.Data.GetData(DataFormats.FileDrop);// lấy dữ liệu trên file mình thả, rs là một mảng
            var filePath = rs.FirstOrDefault();// lấy ptu đầu tiên, nếu rỗng thì bằng null;
            image = Image.FromFile(filePath);
            lnkChonAnhDaiDien.Image = image;
            //lnkChonAnhDaiDien.Image = Image.FromFile(filePath);
            // 2 câu trên khác nhau vì image là biến toàn cục
        }

        private void LnkChonAnhDaiDien_DragEnter(object sender, DragEventArgs e)
=======

            if (imageSave)
            {
                MessageBox.Show(
                    "Đã cập nhật thông tin sinh viên thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void PicAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var rs = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = rs.FirstOrDefault();
            image = Image.FromFile(filePath);
            picAnhDaiDien.Image = image;
        }

        private void PicAnhDaiDien_DragEnter(object sender, DragEventArgs e)
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac
        {
            e.Effect = DragDropEffects.Copy;
        }

<<<<<<< HEAD
        private void ContextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void MenuAvatar_Click(object sender, EventArgs e)
        {

            lnkChonAnhDaiDien.Image = Properties.Resources._1;
            File.Delete(pathAvatarImg);
        }

        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
           var rs= MessageBox.Show("Bạn có chắc là muốn xóa quá trình học tập này không?", 
                "Thông báo"
                , MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning);
            if(rs == DialogResult.OK)
            {
                
                var history = (HistoryLearning) bdsQuaTrinhHocTap.Current;


                //lay toan bộ nội dung bds ra lst
                /*List<HistoryLearning> h1 = (List<HistoryLearning>)bdsQuaTrinhHocTap.DataSource;
                h1.Remove(history);
                bdsQuaTrinhHocTap.DataSource = h1;
                bdsQuaTrinhHocTap.ResetBindings(true);
                String delete = history.IDHistoryLearning + "#" + history.YearFrom + "#" + history.YearTo + "#" + history.Address + "#" + history.IDStudent;
                var Lines = File.ReadAllLines(pathLearningHistoryDataFile);
                var newLines = Lines.Where(line => !line.Contains(delete));
                File.WriteAllLines(pathLearningHistoryDataFile, newLines);*/
                var historyID = dtgQuaTrinhHocTap.CurrentRow.Cells[0].Value.ToString();
                StudentService.DeleteHistoryLearning(pathLearningHistoryDataFile, historyID);
                //dtgQuaTrinhHocTap.Rows.RemoveAt(dtgQuaTrinhHocTap.CurrentRow.Index);
                loadDataHistory(maSinhVien);

                MessageBox.Show("Bạn đã xóa thành công địa chỉ "+ history.Address);
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var f = new frmQuaTrinhHocTapChiTiet(null, maSinhVien, pathLearningHistoryDataFile);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadDataHistory(maSinhVien);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            if (history != null)
            {
                var f = new frmQuaTrinhHocTapChiTiet(history, maSinhVien, pathLearningHistoryDataFile);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Tiến hành nạp lại dữ liệu lên lưới
                    loadDataHistory(maSinhVien);
                }
            }
=======
        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {
            picAnhDaiDien.Image = Properties.Resources.avatar;
            File.Delete(pathAvatarImg);
        }

        private void PicAnhDaiDien_Click(object sender, EventArgs e)
        {
>>>>>>> fa6656062ad07236aecf31725e24efd42b4eb4ac

        }
    }
}
