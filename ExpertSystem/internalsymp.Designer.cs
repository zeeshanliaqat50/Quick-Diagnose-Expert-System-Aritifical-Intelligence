namespace ExpertSystem
{
    partial class internalsymp
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
            this.label1 = new System.Windows.Forms.Label();
            this.appweightchecheckBox = new System.Windows.Forms.CheckBox();
            this.dgnButton = new System.Windows.Forms.Button();
            this.percoughCheckBox = new System.Windows.Forms.CheckBox();
            this.backpaincheckBox = new System.Windows.Forms.CheckBox();
            this.paincoughcheckBox = new System.Windows.Forms.CheckBox();
            this.wheezcheckBox = new System.Windows.Forms.CheckBox();
            this.heartburncheckBox = new System.Windows.Forms.CheckBox();
            this.resultpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "SYMPTOMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // appweightchecheckBox
            // 
            this.appweightchecheckBox.AutoSize = true;
            this.appweightchecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appweightchecheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.appweightchecheckBox.Location = new System.Drawing.Point(30, 97);
            this.appweightchecheckBox.Name = "appweightchecheckBox";
            this.appweightchecheckBox.Size = new System.Drawing.Size(345, 20);
            this.appweightchecheckBox.TabIndex = 16;
            this.appweightchecheckBox.Text = "LOSS OF APPETITE/UNEXPLAINED WEIGHT LOSS";
            this.appweightchecheckBox.UseVisualStyleBackColor = true;
            this.appweightchecheckBox.CheckedChanged += new System.EventHandler(this.HeadachecheckBox_CheckedChanged);
            // 
            // dgnButton
            // 
            this.dgnButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgnButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgnButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dgnButton.Location = new System.Drawing.Point(30, 298);
            this.dgnButton.Name = "dgnButton";
            this.dgnButton.Size = new System.Drawing.Size(186, 58);
            this.dgnButton.TabIndex = 15;
            this.dgnButton.Text = ">> START  DIAGNOSE";
            this.dgnButton.UseVisualStyleBackColor = false;
            this.dgnButton.Click += new System.EventHandler(this.dgnButton_Click);
            // 
            // percoughCheckBox
            // 
            this.percoughCheckBox.AutoSize = true;
            this.percoughCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percoughCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.percoughCheckBox.Location = new System.Drawing.Point(30, 201);
            this.percoughCheckBox.Name = "percoughCheckBox";
            this.percoughCheckBox.Size = new System.Drawing.Size(188, 20);
            this.percoughCheckBox.TabIndex = 14;
            this.percoughCheckBox.Text = "PERSISTENT COUGHING";
            this.percoughCheckBox.UseVisualStyleBackColor = true;
            this.percoughCheckBox.CheckedChanged += new System.EventHandler(this.mdpCheckBox_CheckedChanged);
            // 
            // backpaincheckBox
            // 
            this.backpaincheckBox.AutoSize = true;
            this.backpaincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpaincheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backpaincheckBox.Location = new System.Drawing.Point(30, 175);
            this.backpaincheckBox.Name = "backpaincheckBox";
            this.backpaincheckBox.Size = new System.Drawing.Size(158, 20);
            this.backpaincheckBox.TabIndex = 13;
            this.backpaincheckBox.Text = "INTENSE BACK PAIN";
            this.backpaincheckBox.UseVisualStyleBackColor = true;
            this.backpaincheckBox.CheckedChanged += new System.EventHandler(this.backpaincheckBox_CheckedChanged);
            // 
            // paincoughcheckBox
            // 
            this.paincoughcheckBox.AutoSize = true;
            this.paincoughcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paincoughcheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paincoughcheckBox.Location = new System.Drawing.Point(30, 123);
            this.paincoughcheckBox.Name = "paincoughcheckBox";
            this.paincoughcheckBox.Size = new System.Drawing.Size(261, 20);
            this.paincoughcheckBox.TabIndex = 12;
            this.paincoughcheckBox.Text = "PAIN WHEN COUGHING/BREATHING";
            this.paincoughcheckBox.UseVisualStyleBackColor = true;
            this.paincoughcheckBox.CheckedChanged += new System.EventHandler(this.paincoughcheckBox_CheckedChanged);
            // 
            // wheezcheckBox
            // 
            this.wheezcheckBox.AutoSize = true;
            this.wheezcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheezcheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wheezcheckBox.Location = new System.Drawing.Point(30, 149);
            this.wheezcheckBox.Name = "wheezcheckBox";
            this.wheezcheckBox.Size = new System.Drawing.Size(99, 20);
            this.wheezcheckBox.TabIndex = 11;
            this.wheezcheckBox.Text = "WHEEZING";
            this.wheezcheckBox.UseVisualStyleBackColor = true;
            this.wheezcheckBox.CheckedChanged += new System.EventHandler(this.wheezcheckBox_CheckedChanged);
            // 
            // heartburncheckBox
            // 
            this.heartburncheckBox.AutoSize = true;
            this.heartburncheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartburncheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heartburncheckBox.Location = new System.Drawing.Point(30, 227);
            this.heartburncheckBox.Name = "heartburncheckBox";
            this.heartburncheckBox.Size = new System.Drawing.Size(363, 20);
            this.heartburncheckBox.TabIndex = 17;
            this.heartburncheckBox.Text = "HEARTBURN (BURNING SENSATION IN THE CHEST)";
            this.heartburncheckBox.UseVisualStyleBackColor = true;
            this.heartburncheckBox.CheckedChanged += new System.EventHandler(this.heartburncheckBox_CheckedChanged);
            // 
            // resultpanel
            // 
            this.resultpanel.Location = new System.Drawing.Point(393, 0);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(336, 373);
            this.resultpanel.TabIndex = 18;
            this.resultpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultpanel_Paint);
            // 
            // internalsymp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 385);
            this.Controls.Add(this.resultpanel);
            this.Controls.Add(this.heartburncheckBox);
            this.Controls.Add(this.appweightchecheckBox);
            this.Controls.Add(this.dgnButton);
            this.Controls.Add(this.percoughCheckBox);
            this.Controls.Add(this.backpaincheckBox);
            this.Controls.Add(this.paincoughcheckBox);
            this.Controls.Add(this.wheezcheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "internalsymp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "internalsymp";
            this.Load += new System.EventHandler(this.internalsymp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox appweightchecheckBox;
        private System.Windows.Forms.Button dgnButton;
        private System.Windows.Forms.CheckBox percoughCheckBox;
        private System.Windows.Forms.CheckBox backpaincheckBox;
        private System.Windows.Forms.CheckBox paincoughcheckBox;
        private System.Windows.Forms.CheckBox wheezcheckBox;
        private System.Windows.Forms.CheckBox heartburncheckBox;
        private System.Windows.Forms.Panel resultpanel;
    }
}