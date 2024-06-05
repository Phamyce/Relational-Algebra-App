namespace kp
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_main = new System.Windows.Forms.Label();
            this.panel_theory = new System.Windows.Forms.Panel();
            this.label_theory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_logout.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_theory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.panel_logout);
            this.panel.Controls.Add(this.panel_main);
            this.panel.Controls.Add(this.panel_theory);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1182, 43);
            this.panel.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1182, 1);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_logout
            // 
            this.panel_logout.Controls.Add(this.label_logout);
            this.panel_logout.Location = new System.Drawing.Point(1086, 1);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(75, 43);
            this.panel_logout.TabIndex = 26;
            this.panel_logout.Click += new System.EventHandler(this.panel_logout_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_logout.Location = new System.Drawing.Point(4, 6);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(67, 28);
            this.label_logout.TabIndex = 22;
            this.label_logout.Text = "Выйти";
            this.label_logout.Click += new System.EventHandler(this.panel_logout_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_main);
            this.panel_main.Location = new System.Drawing.Point(28, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(147, 43);
            this.panel_main.TabIndex = 25;
            this.panel_main.Click += new System.EventHandler(this.panel_main_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_main.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_main.Location = new System.Drawing.Point(3, 5);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(129, 28);
            this.label_main.TabIndex = 23;
            this.label_main.Text = "Главное окно";
            this.label_main.Click += new System.EventHandler(this.panel_main_Click);
            // 
            // panel_theory
            // 
            this.panel_theory.Controls.Add(this.label_theory);
            this.panel_theory.Location = new System.Drawing.Point(173, 3);
            this.panel_theory.Name = "panel_theory";
            this.panel_theory.Size = new System.Drawing.Size(78, 43);
            this.panel_theory.TabIndex = 25;
            this.panel_theory.Click += new System.EventHandler(this.panel_theory_Click);
            // 
            // label_theory
            // 
            this.label_theory.AutoSize = true;
            this.label_theory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_theory.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_theory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_theory.Location = new System.Drawing.Point(3, 5);
            this.label_theory.Name = "label_theory";
            this.label_theory.Size = new System.Drawing.Size(73, 28);
            this.label_theory.TabIndex = 21;
            this.label_theory.Text = "Теория";
            this.label_theory.Click += new System.EventHandler(this.panel_theory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 10);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panelWindow
            // 
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(0, 43);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1182, 510);
            this.panelWindow.TabIndex = 27;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_theory.ResumeLayout(false);
            this.panel_theory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Panel panel_theory;
        private System.Windows.Forms.Label label_theory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}