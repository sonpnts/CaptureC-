using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace BaiTapLon
{
    public partial class FormMain : Form
    {
        Bitmap bmp;
        Graphics g;
        FormResult formRel = new FormResult();


        public FormMain()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 3;
            Instance = this;

        }

        public void CapMouse()
        {
            hideForm();
            FormCaptureByMouse f = new FormCaptureByMouse();
            f.ShowDialog();
            Thread.Sleep(100);
            formRel.upload(f.img);
            formRel.ShowDialog();
            this.Show(); 
        }
        public void CapFull()
        {
            this.Hide();
            Thread.Sleep(500);
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            bmp = new Bitmap(bounds.Width, bounds.Height);
            g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 0, 0, 0, bounds.Size);
            formRel.upload((Image)bmp);
            formRel.ShowDialog();
            Thread.Sleep(500);
            this.Show();
        }

        private void hideForm()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }
        private void ShowForm()
        {
                this.Show();
                this.notifyIcon.Visible = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.notifyIcon.ContextMenuStrip.Enabled = true;
            }
            else
            {
                this.Show();
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.notifyIcon.Visible = false;
            }
        }

        private void notifyExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void CapFullScreen_Click(object sender, EventArgs e)
        {
            CapFull();
        }
        private void CapByMouse_Click(object sender, EventArgs e)
        {
            CapMouse();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            hideForm();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _hookID = SetHook(_proc);
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc = HookCallback;
        //Khai báo hàm 
        private static IntPtr _hookID = IntPtr.Zero;
	//Thiết lập một hook bàn phím vào hệ thống.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);


	//loại bỏ một hook đã được thiết lập trước đó
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
	        private static extern bool UnhookWindowsHookEx(IntPtr hhk);


	//được gọi bởi hàm callback để chuyển tiếp sự kiện bàn phím đến hook tiếp theo trong chuỗi hook
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	
	//Trả về con trỏ tới mô-đun có tên được chỉ định.
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
	

	//hàm delegate, được sử dụng để định nghĩa hàm callback được gọi khi có sự kiện bàn phím xảy ra
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);


        
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                //đọc giá trị từ địa chỉ bộ nhớ được chỉ định.
                int vkCode = Marshal.ReadInt32(lParam);


                if (Control.ModifierKeys == Keys.Control && vkCode == 112)
                {
                    FormMain.Instance.ShowForm();
                }
                //Form đang hiện thì không cho chụp tiếp mà phải tắt đi rồi mới cho chụp tiếp
                else if (Control.ModifierKeys == Keys.Control && vkCode == 113 && FormMain.Instance.formRel.Visible == false)
                {
                    FormMain.Instance.CapMouse();
                }
                else if (Control.ModifierKeys == Keys.Control && vkCode == 114 && FormMain.Instance.formRel.Visible == false)
                {
                    FormMain.Instance.CapFull();
                }

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        //lay het process dang chay de thiet lap hook
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        //Form1.Instance có thể được truy cập từ bất kỳ đâu trong chương trình 
        public static FormMain Instance { get; private set; }

    }
}

