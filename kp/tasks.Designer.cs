namespace kp
{
    partial class tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tasks));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tasks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mark_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(497, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ответ";
            // 
            // textBox_answer
            // 
            this.textBox_answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_answer.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_answer.Location = new System.Drawing.Point(502, 64);
            this.textBox_answer.Multiline = true;
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_answer.Size = new System.Drawing.Size(449, 373);
            this.textBox_answer.TabIndex = 20;
            this.textBox_answer.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Location = new System.Drawing.Point(502, 458);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(177, 49);
            this.button_save.TabIndex = 21;
            this.button_save.Text = "Отправить ответ";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Задания";
            // 
            // textBox_tasks
            // 
            this.textBox_tasks.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_tasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tasks.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_tasks.Location = new System.Drawing.Point(37, 64);
            this.textBox_tasks.Multiline = true;
            this.textBox_tasks.Name = "textBox_tasks";
            this.textBox_tasks.ReadOnly = true;
            this.textBox_tasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_tasks.Size = new System.Drawing.Size(449, 455);
            this.textBox_tasks.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(707, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Оценка:";
            // 
            // mark_textBox
            // 
            this.mark_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.mark_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mark_textBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mark_textBox.Location = new System.Drawing.Point(796, 470);
            this.mark_textBox.MaxLength = 10;
            this.mark_textBox.Name = "mark_textBox";
            this.mark_textBox.ReadOnly = true;
            this.mark_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mark_textBox.Size = new System.Drawing.Size(131, 27);
            this.mark_textBox.TabIndex = 25;
            // 
            // tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 565);
            this.Controls.Add(this.mark_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tasks";
            this.Text = "tasks";
            this.Load += new System.EventHandler(this.tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mark_textBox;
    }
}