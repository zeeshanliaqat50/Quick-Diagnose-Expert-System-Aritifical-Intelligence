namespace ExpertSystem
{
    partial class bmb
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
            this.backpaincheckBox = new System.Windows.Forms.CheckBox();
            this.jointpaincheckBox = new System.Windows.Forms.CheckBox();
            this.lowerbackpaincheckBox = new System.Windows.Forms.CheckBox();
            this.mdpCheckBox = new System.Windows.Forms.CheckBox();
            this.dgnButton = new System.Windows.Forms.Button();
            this.resultpanel = new System.Windows.Forms.Panel();
            this.HeadachecheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "SYMPTOMS";
            // 
            // backpaincheckBox
            // 
            this.backpaincheckBox.AutoSize = true;
            this.backpaincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpaincheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backpaincheckBox.Location = new System.Drawing.Point(46, 164);
            this.backpaincheckBox.Name = "backpaincheckBox";
            this.backpaincheckBox.Size = new System.Drawing.Size(96, 20);
            this.backpaincheckBox.TabIndex = 4;
            this.backpaincheckBox.Text = "BACK PAIN";
            this.backpaincheckBox.UseVisualStyleBackColor = true;
            this.backpaincheckBox.CheckedChanged += new System.EventHandler(this.backpaincheckBox_CheckedChanged);
            // 
            // jointpaincheckBox
            // 
            this.jointpaincheckBox.AutoSize = true;
            this.jointpaincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jointpaincheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jointpaincheckBox.Location = new System.Drawing.Point(46, 127);
            this.jointpaincheckBox.Name = "jointpaincheckBox";
            this.jointpaincheckBox.Size = new System.Drawing.Size(100, 20);
            this.jointpaincheckBox.TabIndex = 5;
            this.jointpaincheckBox.Text = "JOINT PAIN";
            this.jointpaincheckBox.UseVisualStyleBackColor = true;
            this.jointpaincheckBox.CheckedChanged += new System.EventHandler(this.jointpaincheckBox_CheckedChanged);
            // 
            // lowerbackpaincheckBox
            // 
            this.lowerbackpaincheckBox.AutoSize = true;
            this.lowerbackpaincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerbackpaincheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lowerbackpaincheckBox.Location = new System.Drawing.Point(46, 204);
            this.lowerbackpaincheckBox.Name = "lowerbackpaincheckBox";
            this.lowerbackpaincheckBox.Size = new System.Drawing.Size(148, 20);
            this.lowerbackpaincheckBox.TabIndex = 6;
            this.lowerbackpaincheckBox.Text = "LOWER BACK PAIN";
            this.lowerbackpaincheckBox.UseVisualStyleBackColor = true;
            this.lowerbackpaincheckBox.CheckedChanged += new System.EventHandler(this.lowerbackpaincheckBox_CheckedChanged);
            // 
            // mdpCheckBox
            // 
            this.mdpCheckBox.AutoSize = true;
            this.mdpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mdpCheckBox.Location = new System.Drawing.Point(46, 244);
            this.mdpCheckBox.Name = "mdpCheckBox";
            this.mdpCheckBox.Size = new System.Drawing.Size(158, 20);
            this.mdpCheckBox.TabIndex = 7;
            this.mdpCheckBox.Text = "MUSCLE/BODY PAIN";
            this.mdpCheckBox.UseVisualStyleBackColor = true;
            this.mdpCheckBox.CheckedChanged += new System.EventHandler(this.mdpCheckBox_CheckedChanged);
            // 
            // dgnButton
            // 
            this.dgnButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgnButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgnButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dgnButton.Location = new System.Drawing.Point(46, 305);
            this.dgnButton.Name = "dgnButton";
            this.dgnButton.Size = new System.Drawing.Size(186, 58);
            this.dgnButton.TabIndex = 8;
            this.dgnButton.Text = ">> START  DIAGNOSE";
            this.dgnButton.UseVisualStyleBackColor = false;
            this.dgnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultpanel
            // 
            this.resultpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.resultpanel.Location = new System.Drawing.Point(376, 0);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(365, 385);
            this.resultpanel.TabIndex = 9;
            // 
            // HeadachecheckBox
            // 
            this.HeadachecheckBox.AutoSize = true;
            this.HeadachecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadachecheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeadachecheckBox.Location = new System.Drawing.Point(46, 92);
            this.HeadachecheckBox.Name = "HeadachecheckBox";
            this.HeadachecheckBox.Size = new System.Drawing.Size(105, 20);
            this.HeadachecheckBox.TabIndex = 10;
            this.HeadachecheckBox.Text = "HEAD ACHE";
            this.HeadachecheckBox.UseVisualStyleBackColor = true;
            this.HeadachecheckBox.CheckedChanged += new System.EventHandler(this.HeadachecheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(54, 270);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "kashif";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // bmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 385);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.HeadachecheckBox);
            this.Controls.Add(this.resultpanel);
            this.Controls.Add(this.dgnButton);
            this.Controls.Add(this.mdpCheckBox);
            this.Controls.Add(this.lowerbackpaincheckBox);
            this.Controls.Add(this.jointpaincheckBox);
            this.Controls.Add(this.backpaincheckBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bmb";
            this.Text = "kashif";
            this.Load += new System.EventHandler(this.bmb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox backpaincheckBox;
        private System.Windows.Forms.CheckBox jointpaincheckBox;
        private System.Windows.Forms.CheckBox lowerbackpaincheckBox;
        private System.Windows.Forms.CheckBox mdpCheckBox;
        private System.Windows.Forms.Button dgnButton;
        private System.Windows.Forms.Panel resultpanel;
        private System.Windows.Forms.CheckBox HeadachecheckBox;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}