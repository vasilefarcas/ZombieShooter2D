namespace ZombieShooter2D
{
    partial class Form1
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
            this.ammoLabel = new System.Windows.Forms.Label();
            this.ammoCount = new System.Windows.Forms.Label();
            this.killsLabel = new System.Windows.Forms.Label();
            this.killsCount = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ammoLabel
            // 
            this.ammoLabel.AutoSize = true;
            this.ammoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ammoLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoLabel.ForeColor = System.Drawing.Color.White;
            this.ammoLabel.Location = new System.Drawing.Point(2, 12);
            this.ammoLabel.Name = "ammoLabel";
            this.ammoLabel.Size = new System.Drawing.Size(120, 37);
            this.ammoLabel.TabIndex = 0;
            this.ammoLabel.Text = "Ammo:";
            // 
            // ammoCount
            // 
            this.ammoCount.AutoSize = true;
            this.ammoCount.BackColor = System.Drawing.Color.Transparent;
            this.ammoCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoCount.ForeColor = System.Drawing.Color.White;
            this.ammoCount.Location = new System.Drawing.Point(128, 12);
            this.ammoCount.Name = "ammoCount";
            this.ammoCount.Size = new System.Drawing.Size(30, 37);
            this.ammoCount.TabIndex = 2;
            this.ammoCount.Text = "-";
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.BackColor = System.Drawing.Color.Transparent;
            this.killsLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killsLabel.ForeColor = System.Drawing.Color.White;
            this.killsLabel.Location = new System.Drawing.Point(359, 12);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(81, 37);
            this.killsLabel.TabIndex = 3;
            this.killsLabel.Text = "Kills:";
            // 
            // killsCount
            // 
            this.killsCount.AutoSize = true;
            this.killsCount.BackColor = System.Drawing.Color.Transparent;
            this.killsCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killsCount.ForeColor = System.Drawing.Color.White;
            this.killsCount.Location = new System.Drawing.Point(461, 12);
            this.killsCount.Name = "killsCount";
            this.killsCount.Size = new System.Drawing.Size(30, 37);
            this.killsCount.TabIndex = 4;
            this.killsCount.Text = "-";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(834, 12);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(110, 37);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(941, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(311, 35);
            this.healthBar.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.killsCount);
            this.Controls.Add(this.killsLabel);
            this.Controls.Add(this.ammoCount);
            this.Controls.Add(this.ammoLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammoLabel;
        private System.Windows.Forms.Label ammoCount;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.Label killsCount;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.ProgressBar healthBar;
        public System.Windows.Forms.Timer timer1;
    }
}

