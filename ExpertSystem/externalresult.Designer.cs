namespace ExpertSystem
{
    partial class externalresult
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
            this.presbyopiaButton = new System.Windows.Forms.Button();
            this.eyesdryfbutton = new System.Windows.Forms.Button();
            this.Eyeinfbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // presbyopiaButton
            // 
            this.presbyopiaButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.presbyopiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presbyopiaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presbyopiaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presbyopiaButton.ImageKey = "(none)";
            this.presbyopiaButton.Location = new System.Drawing.Point(76, 260);
            this.presbyopiaButton.Name = "presbyopiaButton";
            this.presbyopiaButton.Size = new System.Drawing.Size(175, 32);
            this.presbyopiaButton.TabIndex = 18;
            this.presbyopiaButton.Text = "PRESBYOPIA";
            this.presbyopiaButton.UseVisualStyleBackColor = true;
            this.presbyopiaButton.Click += new System.EventHandler(this.presbyopiaButton_Click);
            // 
            // eyesdryfbutton
            // 
            this.eyesdryfbutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.eyesdryfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyesdryfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesdryfbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eyesdryfbutton.ImageKey = "(none)";
            this.eyesdryfbutton.Location = new System.Drawing.Point(76, 208);
            this.eyesdryfbutton.Name = "eyesdryfbutton";
            this.eyesdryfbutton.Size = new System.Drawing.Size(175, 32);
            this.eyesdryfbutton.TabIndex = 17;
            this.eyesdryfbutton.Text = "EYES DRY SNYDROME";
            this.eyesdryfbutton.UseVisualStyleBackColor = true;
            this.eyesdryfbutton.Click += new System.EventHandler(this.eyesdryfbutton_Click);
            // 
            // Eyeinfbutton
            // 
            this.Eyeinfbutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.Eyeinfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eyeinfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eyeinfbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Eyeinfbutton.ImageKey = "(none)";
            this.Eyeinfbutton.Location = new System.Drawing.Point(76, 156);
            this.Eyeinfbutton.Name = "Eyeinfbutton";
            this.Eyeinfbutton.Size = new System.Drawing.Size(175, 32);
            this.Eyeinfbutton.TabIndex = 16;
            this.Eyeinfbutton.Text = "EYES INFECTION ";
            this.Eyeinfbutton.UseVisualStyleBackColor = true;
            this.Eyeinfbutton.Click += new System.EventHandler(this.Eyeinfbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(76, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "POSSIBLE DESEASE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "RESULTS";
            // 
            // externalresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 336);
            this.Controls.Add(this.presbyopiaButton);
            this.Controls.Add(this.eyesdryfbutton);
            this.Controls.Add(this.Eyeinfbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "externalresult";
            this.Text = "externalresult";
            this.Load += new System.EventHandler(this.externalresult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button presbyopiaButton;
        private System.Windows.Forms.Button eyesdryfbutton;
        private System.Windows.Forms.Button Eyeinfbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}