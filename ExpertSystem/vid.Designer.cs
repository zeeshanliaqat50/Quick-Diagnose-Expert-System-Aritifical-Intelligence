namespace ExpertSystem
{
    partial class vid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vid));
            this.plybutton = new System.Windows.Forms.Button();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.vidslccomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // plybutton
            // 
            this.plybutton.Location = new System.Drawing.Point(517, 23);
            this.plybutton.Name = "plybutton";
            this.plybutton.Size = new System.Drawing.Size(85, 23);
            this.plybutton.TabIndex = 0;
            this.plybutton.Text = "Play";
            this.plybutton.UseVisualStyleBackColor = true;
            this.plybutton.Click += new System.EventHandler(this.plybutton_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 88);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(557, 240);
            this.axVLCPlugin21.TabIndex = 1;
            // 
            // vidslccomboBox
            // 
            this.vidslccomboBox.FormattingEnabled = true;
            this.vidslccomboBox.Items.AddRange(new object[] {
            "BACK PAIN RELIEF",
            "SHOULD PAIN RELIEF",
            "HEADACHE RELIEF"});
            this.vidslccomboBox.Location = new System.Drawing.Point(12, 24);
            this.vidslccomboBox.Name = "vidslccomboBox";
            this.vidslccomboBox.Size = new System.Drawing.Size(432, 21);
            this.vidslccomboBox.TabIndex = 2;
            // 
            // vid
            // 
            this.ClientSize = new System.Drawing.Size(781, 340);
            this.Controls.Add(this.vidslccomboBox);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.plybutton);
            this.Name = "vid";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ComboBox vidselectioncomboBox;
        private System.Windows.Forms.Button playbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button plybutton;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.ComboBox vidslccomboBox;
    }
}