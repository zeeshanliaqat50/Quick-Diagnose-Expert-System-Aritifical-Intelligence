namespace ExpertSystem
{
    partial class bmbextd
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
            this.label2 = new System.Windows.Forms.Label();
            this.Denguebutton = new System.Windows.Forms.Button();
            this.Anemiabutton = new System.Windows.Forms.Button();
            this.ColdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "RESULTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "POSSIBLE DESEASE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Denguebutton
            // 
            this.Denguebutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.Denguebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Denguebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Denguebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Denguebutton.ImageKey = "(none)";
            this.Denguebutton.Location = new System.Drawing.Point(16, 170);
            this.Denguebutton.Name = "Denguebutton";
            this.Denguebutton.Size = new System.Drawing.Size(175, 32);
            this.Denguebutton.TabIndex = 6;
            this.Denguebutton.Text = "DENGUE";
            this.Denguebutton.UseVisualStyleBackColor = true;
            this.Denguebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Anemiabutton
            // 
            this.Anemiabutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.Anemiabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anemiabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anemiabutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Anemiabutton.ImageKey = "(none)";
            this.Anemiabutton.Location = new System.Drawing.Point(12, 220);
            this.Anemiabutton.Name = "Anemiabutton";
            this.Anemiabutton.Size = new System.Drawing.Size(175, 32);
            this.Anemiabutton.TabIndex = 7;
            this.Anemiabutton.Text = "ANEMIA";
            this.Anemiabutton.UseVisualStyleBackColor = true;
            this.Anemiabutton.Click += new System.EventHandler(this.Anemiabutton_Click);
            // 
            // ColdButton
            // 
            this.ColdButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.ColdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColdButton.ImageKey = "(none)";
            this.ColdButton.Location = new System.Drawing.Point(16, 267);
            this.ColdButton.Name = "ColdButton";
            this.ColdButton.Size = new System.Drawing.Size(175, 32);
            this.ColdButton.TabIndex = 8;
            this.ColdButton.Text = "COLD FEVER";
            this.ColdButton.UseVisualStyleBackColor = true;
            this.ColdButton.Click += new System.EventHandler(this.ColdButton_Click);
            // 
            // bmbextd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.Controls.Add(this.ColdButton);
            this.Controls.Add(this.Anemiabutton);
            this.Controls.Add(this.Denguebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bmbextd";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Denguebutton;
        private System.Windows.Forms.Button Anemiabutton;
        private System.Windows.Forms.Button ColdButton;
    }
}