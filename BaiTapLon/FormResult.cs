using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class FormResult : Form
    {
      
        public FormResult()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void upload(Image picture)
        {
            this.pictureBox.Image = null;
            this.pictureBox.Image = picture;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Image temp = (Image)this.pictureBox.Image;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image file (jpg file(*.jpg)|*.jpg|" + "gif file(*.gif)|*.gif|" + "bitmap file(*.bmp) | *.bmp|" + "png file (*.png)|*.png";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FileName.ToLower().EndsWith(".jpg"))
                {
                    temp.Save(saveFile.FileName,ImageFormat.Jpeg);
                }
                else if(saveFile.FileName.ToLower().EndsWith(".bmp"))
                {
                    temp.Save(saveFile.FileName, ImageFormat.Bmp);
                }
                else if (saveFile.FileName.ToLower().EndsWith(".png"))
                {
                    temp.Save(saveFile.FileName, ImageFormat.Png);
                } 
                else if (saveFile.FileName.ToLower().EndsWith(".gif"))
                {
                    temp.Save(saveFile.FileName, ImageFormat.Gif);
                }
            }
            this.Close();
            
        }
    }
}
