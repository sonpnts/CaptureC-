namespace BaiTapLon
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.CapFullScreen = new System.Windows.Forms.Button();
            this.CapByMouse = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.captureFullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.btn_hide);
            this.panel1.Controls.Add(this.CapFullScreen);
            this.panel1.Controls.Add(this.CapByMouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 58);
            this.panel1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Window;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Exit.Location = new System.Drawing.Point(274, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 58);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.SystemColors.Window;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.Location = new System.Drawing.Point(205, 0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(71, 58);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = "__";
            this.btn_hide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // CapFullScreen
            // 
            this.CapFullScreen.BackColor = System.Drawing.SystemColors.Window;
            this.CapFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CapFullScreen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CapFullScreen.Location = new System.Drawing.Point(121, 0);
            this.CapFullScreen.Name = "CapFullScreen";
            this.CapFullScreen.Size = new System.Drawing.Size(88, 58);
            this.CapFullScreen.TabIndex = 1;
            this.CapFullScreen.Text = "Capture Full";
            this.CapFullScreen.UseVisualStyleBackColor = false;
            this.CapFullScreen.Click += new System.EventHandler(this.CapFullScreen_Click);
            // 
            // CapByMouse
            // 
            this.CapByMouse.BackColor = System.Drawing.SystemColors.Window;
            this.CapByMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CapByMouse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CapByMouse.Location = new System.Drawing.Point(0, 0);
            this.CapByMouse.Name = "CapByMouse";
            this.CapByMouse.Size = new System.Drawing.Size(130, 58);
            this.CapByMouse.TabIndex = 1;
            this.CapByMouse.Text = "Capture By Mouse";
            this.CapByMouse.UseVisualStyleBackColor = false;
            this.CapByMouse.Click += new System.EventHandler(this.CapByMouse_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Application to capture screen";
            this.notifyIcon.BalloonTipTitle = "Capture Screen";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Capture Screen";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.captureFullScreenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 110);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::BaiTapLon.Properties.Resources.capture_by_mouse;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItem1.Text = "Capture By Mouse";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.CapByMouse_Click);
            // 
            // captureFullScreenToolStripMenuItem
            // 
            this.captureFullScreenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("captureFullScreenToolStripMenuItem.Image")));
            this.captureFullScreenToolStripMenuItem.Name = "captureFullScreenToolStripMenuItem";
            this.captureFullScreenToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.captureFullScreenToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.captureFullScreenToolStripMenuItem.Text = "Capture Full Screen";
            this.captureFullScreenToolStripMenuItem.Click += new System.EventHandler(this.CapFullScreen_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.notifyExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 58);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Capture Screen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem captureFullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button CapFullScreen;
        private System.Windows.Forms.Button CapByMouse;
    }
}

