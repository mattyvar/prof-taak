namespace Simon_Says2
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbtEasy = new System.Windows.Forms.RadioButton();
            this.rbtMedium = new System.Windows.Forms.RadioButton();
            this.rbtHard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(951, 564);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(218, 81);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Afsluiten";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(727, 564);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(218, 81);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Start";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rbtEasy
            // 
            this.rbtEasy.AutoSize = true;
            this.rbtEasy.Checked = true;
            this.rbtEasy.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEasy.Location = new System.Drawing.Point(898, 392);
            this.rbtEasy.Name = "rbtEasy";
            this.rbtEasy.Size = new System.Drawing.Size(98, 44);
            this.rbtEasy.TabIndex = 3;
            this.rbtEasy.TabStop = true;
            this.rbtEasy.Text = "Easy";
            this.rbtEasy.UseVisualStyleBackColor = true;
            // 
            // rbtMedium
            // 
            this.rbtMedium.AutoSize = true;
            this.rbtMedium.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMedium.Location = new System.Drawing.Point(898, 442);
            this.rbtMedium.Name = "rbtMedium";
            this.rbtMedium.Size = new System.Drawing.Size(152, 44);
            this.rbtMedium.TabIndex = 4;
            this.rbtMedium.Text = "Medium";
            this.rbtMedium.UseVisualStyleBackColor = true;
            // 
            // rbtHard
            // 
            this.rbtHard.AutoSize = true;
            this.rbtHard.BackColor = System.Drawing.Color.White;
            this.rbtHard.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHard.Location = new System.Drawing.Point(898, 492);
            this.rbtHard.Name = "rbtHard";
            this.rbtHard.Size = new System.Drawing.Size(108, 44);
            this.rbtHard.TabIndex = 5;
            this.rbtHard.Text = "Hard";
            this.rbtHard.UseVisualStyleBackColor = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1511, 852);
            this.Controls.Add(this.rbtHard);
            this.Controls.Add(this.rbtMedium);
            this.Controls.Add(this.rbtEasy);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnQuit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbtEasy;
        private System.Windows.Forms.RadioButton rbtMedium;
        private System.Windows.Forms.RadioButton rbtHard;
    }
}