namespace BaiTapLon
{
    partial class FormCaptureByMouse
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
            this.picCap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCap)).BeginInit();
            this.SuspendLayout();
            // 
            // picCap
            // 
            this.picCap.Location = new System.Drawing.Point(-2, -2);
            this.picCap.Name = "picCap";
            this.picCap.Size = new System.Drawing.Size(100, 50);
            this.picCap.TabIndex = 0;
            this.picCap.TabStop = false;
            this.picCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCap_MouseDown);
            this.picCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCap_MouseMove);
            this.picCap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCap_MouseUp);
            // 
            // FormCaptureByMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCap);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaptureByMouse";
            this.Text = "FormCaptureByMouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCaptureByMouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCap;
    }
}