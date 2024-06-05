namespace kp
{
    partial class teacher_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher_editor));
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel_answers = new System.Windows.Forms.Panel();
            this.label_answers = new System.Windows.Forms.Label();
            this.panel_editor = new System.Windows.Forms.Panel();
            this.label_editor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_logout.SuspendLayout();
            this.panel_answers.SuspendLayout();
            this.panel_editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.panel_logout);
            this.panel.Controls.Add(this.panel_answers);
            this.panel.Controls.Add(this.panel_editor);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(802, 43);
            this.panel.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 1);
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
            // 
            // panel_answers
            // 
            this.panel_answers.Controls.Add(this.label_answers);
            this.panel_answers.Location = new System.Drawing.Point(28, 3);
            this.panel_answers.Name = "panel_answers";
            this.panel_answers.Size = new System.Drawing.Size(183, 43);
            this.panel_answers.TabIndex = 25;
            this.panel_answers.Click += new System.EventHandler(this.panel_answers_Click);
            // 
            // label_answers
            // 
            this.label_answers.AutoSize = true;
            this.label_answers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_answers.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_answers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_answers.Location = new System.Drawing.Point(3, 5);
            this.label_answers.Name = "label_answers";
            this.label_answers.Size = new System.Drawing.Size(168, 28);
            this.label_answers.TabIndex = 23;
            this.label_answers.Text = "Ответы студентов";
            this.label_answers.Click += new System.EventHandler(this.panel_answers_Click);
            // 
            // panel_editor
            // 
            this.panel_editor.Controls.Add(this.label_editor);
            this.panel_editor.Location = new System.Drawing.Point(213, 3);
            this.panel_editor.Name = "panel_editor";
            this.panel_editor.Size = new System.Drawing.Size(191, 43);
            this.panel_editor.TabIndex = 25;
            this.panel_editor.Click += new System.EventHandler(this.panel_editor_Click);
            // 
            // label_editor
            // 
            this.label_editor.AutoSize = true;
            this.label_editor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_editor.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_editor.Location = new System.Drawing.Point(3, 5);
            this.label_editor.Name = "label_editor";
            this.label_editor.Size = new System.Drawing.Size(170, 28);
            this.label_editor.TabIndex = 21;
            this.label_editor.Text = "Редактор заданий";
            this.label_editor.Click += new System.EventHandler(this.panel_editor_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 513);
            this.panel1.TabIndex = 27;
            // 
            // panelWindow
            // 
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(0, 43);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(802, 553);
            this.panelWindow.TabIndex = 28;
            // 
            // teacher_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 596);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teacher_editor";
            this.Text = "teacher_editor";
            this.Load += new System.EventHandler(this.teacher_editor_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout.PerformLayout();
            this.panel_answers.ResumeLayout(false);
            this.panel_answers.PerformLayout();
            this.panel_editor.ResumeLayout(false);
            this.panel_editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Panel panel_answers;
        private System.Windows.Forms.Label label_answers;
        private System.Windows.Forms.Panel panel_editor;
        private System.Windows.Forms.Label label_editor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWindow;
    }
}