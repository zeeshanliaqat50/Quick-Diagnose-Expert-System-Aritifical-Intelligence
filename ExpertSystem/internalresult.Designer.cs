namespace ExpertSystem
{
    partial class internalresult
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
            this.stomachButton = new System.Windows.Forms.Button();
            this.kidneyinfbutton = new System.Windows.Forms.Button();
            this.lungsdisoderbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stomachButton
            // 
            this.stomachButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.stomachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stomachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stomachButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stomachButton.ImageKey = "(none)";
            this.stomachButton.Location = new System.Drawing.Point(43, 263);
            this.stomachButton.Name = "stomachButton";
            this.stomachButton.Size = new System.Drawing.Size(175, 32);
            this.stomachButton.TabIndex = 13;
            this.stomachButton.Text = "STOMACH DISORDER";
            this.stomachButton.UseVisualStyleBackColor = true;
            this.stomachButton.Click += new System.EventHandler(this.stomachButton_Click);
            // 
            // kidneyinfbutton
            // 
            this.kidneyinfbutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.kidneyinfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kidneyinfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidneyinfbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kidneyinfbutton.ImageKey = "(none)";
            this.kidneyinfbutton.Location = new System.Drawing.Point(43, 211);
            this.kidneyinfbutton.Name = "kidneyinfbutton";
            this.kidneyinfbutton.Size = new System.Drawing.Size(175, 32);
            this.kidneyinfbutton.TabIndex = 12;
            this.kidneyinfbutton.Text = "KIDNEY INFECTION";
            this.kidneyinfbutton.UseVisualStyleBackColor = true;
            this.kidneyinfbutton.Click += new System.EventHandler(this.kidneyinfbutton_Click);
            // 
            // lungsdisoderbutton
            // 
            this.lungsdisoderbutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.lungsdisoderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lungsdisoderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lungsdisoderbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lungsdisoderbutton.ImageKey = "(none)";
            this.lungsdisoderbutton.Location = new System.Drawing.Point(43, 159);
            this.lungsdisoderbutton.Name = "lungsdisoderbutton";
            this.lungsdisoderbutton.Size = new System.Drawing.Size(175, 32);
            this.lungsdisoderbutton.TabIndex = 11;
            this.lungsdisoderbutton.Text = "LUNGS DISORDER";
            this.lungsdisoderbutton.UseVisualStyleBackColor = true;
            this.lungsdisoderbutton.Click += new System.EventHandler(this.Denguebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "POSSIBLE DESEASE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "RESULTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // internalresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.Controls.Add(this.stomachButton);
            this.Controls.Add(this.kidneyinfbutton);
            this.Controls.Add(this.lungsdisoderbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "internalresult";
            this.Text = "internalresult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stomachButton;
        private System.Windows.Forms.Button kidneyinfbutton;
        private System.Windows.Forms.Button lungsdisoderbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}