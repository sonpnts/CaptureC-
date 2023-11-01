using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace BaiTapLon
{
    public partial class FormCaptureByMouse : Form
    {
        int StartX;
        int StartY;
        int minX;
        int minY;
        int selectWidth;
        int selectHeight;
        public Pen selectPen;
        public Image img;
        bool start = false;
        public FormCaptureByMouse()
        {

            InitializeComponent();
            //thiết lập vị trí khởi đầu của cửa sổ Form 
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Top = 0;
            this.Left = 0;
        }

        private void FormCaptureByMouse_Load(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500);
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            picCap.Size = printscreen.Size;
            picCap.Image = printscreen;
            this.Show();
            Cursor = Cursors.Cross;
        }


        private void SaveImage()
        {
            if (selectWidth > 0)
            {
                Rectangle rect = new Rectangle(minX, minY, selectWidth, selectHeight);
                //tao tu hinh goc
                Bitmap OriginalImage = new Bitmap(picCap.Image, picCap.Width, picCap.Height);
                Bitmap _img = new Bitmap(selectWidth, selectHeight);
                Graphics g = Graphics.FromImage(_img);
                //cho phép hình ảnh được phóng to hoặc thu nhỏ mà không làm mờ.
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //cho phép hình ảnh được cắt và di chuyển một cách chính xác.
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                //ghép ảnh được thực hiện với chất lượng cao, cho phép hình ảnh được ghép một cách chính xác và không bị vỡ
                g.CompositingQuality = CompositingQuality.HighQuality;
                //Vẽ hình ảnh được cắt ra từ hình ảnh gốc và phóng to
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
                img = _img;
                Clipboard.SetImage(_img);
            }
            this.Close();
        }

     

        private void picCap_MouseDown(object sender, MouseEventArgs e)
        {
            if (!start)
            {
                if (e.Button == MouseButtons.Left)
                {
                    StartX = e.X;
                    StartY = e.Y;
                    selectPen = new Pen(Color.Black, 4);
                    selectPen.DashStyle = DashStyle.Dot;
                }
                start = true;
                picCap.Refresh();
            }
        }

        private void picCap_MouseUp(object sender, MouseEventArgs e)
        {
            if (picCap.Image == null)
                return;

            if ((e.Button == MouseButtons.Left))
            {
                picCap.Refresh();

                //truong hop ve nguoc tu duoi len
                minX = Math.Min(StartX, e.X);
                minY = Math.Min(StartY, e.Y);
                selectWidth = Math.Abs(e.X - StartX);
                selectHeight = Math.Abs(e.Y - StartY);

                picCap.CreateGraphics().DrawRectangle(selectPen, minX, minY, selectWidth, selectHeight);
            }
            start = false;
            SaveImage();
        }

        private void picCap_MouseMove(object sender, MouseEventArgs e)
        {

            if (picCap.Image == null)
                return;
            if (start)
            {

                picCap.Refresh();
                //truong hop ve nguoc tu duoi len
                minX = Math.Min(StartX, e.X);
                minY = Math.Min(StartY, e.Y);
                selectWidth = Math.Abs(e.X - StartX);
                selectHeight = Math.Abs(e.Y - StartY);
                picCap.CreateGraphics().DrawRectangle(selectPen, minX, minY, selectWidth, selectHeight);
            }
        }
    }
}
