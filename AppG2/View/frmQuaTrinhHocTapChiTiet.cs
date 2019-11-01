using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;
using AppG2.Controller;

namespace AppG2.View
{
    public partial class frmQuaTrinhHocTapChiTiet : Form
    {
        HistoryLearning history;
        string maSinhVien;
        string pathLearningHistoryDataFile;


        public frmQuaTrinhHocTapChiTiet(HistoryLearning history=null, string maSinhVien = null, string pathHistoryFile = null)
        {
            InitializeComponent();
            this.history = history;
            this.maSinhVien = maSinhVien;
            this.pathLearningHistoryDataFile = pathHistoryFile;
            if (history != null)
            {
                //Chỉnh Sửa
                this.Text = "Chỉnh sửa quá trình học tập";
                numTuNam.Value = history.YearFrom;
                numDenNam.Value = history.YearTo;
                txtNoiHoc.Text = history.Address;
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới quá trình học tập";
                
            }
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            
            if (history != null)
            {
                //Chỉnh Sửa
                var yearFrom = numTuNam.Value;
                var yearEnd = numDenNam.Value;
                var address = txtNoiHoc.Text;
                StudentService.EditHistoryLearnings(history.IDHistoryLearning, pathLearningHistoryDataFile, (int)yearFrom, (int)yearEnd, address);
            }
            else
            {

                //thêm mới
                var yearFrom = numTuNam.Value;
                var yearEnd = numDenNam.Value;
                var address = txtNoiHoc.Text;
                StudentService.CreateHistoryLearnings(pathLearningHistoryDataFile, (int)yearFrom, (int)yearEnd, address, maSinhVien);
                
              
            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;//thuộc tính có sự thay đổi -> sẽ đóng lại
        }
    }
}
