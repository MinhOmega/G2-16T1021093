using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AppG2
{
    public partial class frmStudent : Form
    {
        string Dirpath;
        
        int imgindex;
        public frmStudent()
        {
            InitializeComponent();
        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 10; i++)
            {
                comboBox1.Items.Add(i);
                comboBox1.SelectedIndex = 0;
            }
        }
        private void Btn_Loadimg_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = fBdImage.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                listBox1.Items.Clear();
                Dirpath = fBdImage.SelectedPath;
                string[] files = Directory.GetFiles(Dirpath, "*.png");
                foreach (string file in files)
                {
                    int pos = file.LastIndexOf("||");
                    string FName = file.Substring(pos + 1);
                    listBox1.Items.Add(FName);

                    
                }
                listBox1.SelectedIndex = imgindex;
                btn_previous.Enabled = true;
                btn_next.Enabled = true;     
                
            }
            
           
            

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if(imgindex < listBox1.Items.Count - 1)
            {
                imgindex += 1;
                if (imgindex == listBox1.Items.Count - 1)
                    btn_next.Enabled = false;
                if (imgindex > 0)
                    btn_previous.Enabled = true;
                listBox1.SelectedIndex = imgindex;
            }
           
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            if(imgindex > 0)
            {
                imgindex -= 1;
                if (imgindex == 0)
                    btn_previous.Enabled = false;
                if (imgindex < listBox1.Items.Count -1 )
                    btn_next.Enabled = true;
                listBox1.SelectedIndex = imgindex;
            }
            
        }
        private void Btn_slideshow_Click(object sender, EventArgs e)
        {
            if (btn_slideshow.Text == "Slide Show")
            {
                btn_slideshow.Text = "Stop Show";
                Delay.Interval = int.Parse(comboBox1.Text) * 1000;
                Delay.Start();
            }
            else
            {
                Delay.Stop();
                btn_slideshow.Text = "Slide Show";
            }

        }
        private void Delay_Tick(object sender, EventArgs e)
        {
            btn_next.PerformClick();
        }
      
        
    }
}
