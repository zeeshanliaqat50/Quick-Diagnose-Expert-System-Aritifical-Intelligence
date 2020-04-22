using System;

namespace vv
{
   
    partial class vvd
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
        [STAThread]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vvd));
            this.vidslccomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // vidslccomboBox
            // 
            this.vidslccomboBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vidslccomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.vidslccomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.vidslccomboBox.FormattingEnabled = true;
            this.vidslccomboBox.Items.AddRange(new object[] {
            "SHOULDER PAIN RELIEF",
            "BACK PAIN RELIEF",
            "HEADACHE RELIEF",
            "Relaxtion Video"});
            this.vidslccomboBox.Location = new System.Drawing.Point(12, 25);
            this.vidslccomboBox.Name = "vidslccomboBox";
            this.vidslccomboBox.Size = new System.Drawing.Size(580, 24);
            this.vidslccomboBox.TabIndex = 3;
            this.vidslccomboBox.SelectedIndexChanged += new System.EventHandler(this.vidslccomboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(598, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(689, 275);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // vvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(738, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vidslccomboBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.Name = "vvd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoCorner";
            this.Load += new System.EventHandler(this.vvd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ComboBox vidslccomboBox;
        private System.Windows.Forms.Button button1;
    }
}