namespace kp
{
    partial class answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(answer));
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.fio_label = new System.Windows.Forms.Label();
            this.mark_textBox = new System.Windows.Forms.TextBox();
            this.mark_label = new System.Windows.Forms.Label();
            this.button_mark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer_textBox
            // 
            this.answer_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer_textBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answer_textBox.Location = new System.Drawing.Point(30, 62);
            this.answer_textBox.Multiline = true;
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.ReadOnly = true;
            this.answer_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer_textBox.Size = new System.Drawing.Size(594, 350);
            this.answer_textBox.TabIndex = 0;
            this.answer_textBox.TabStop = false;
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.Location = new System.Drawing.Point(25, 22);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(56, 28);
            this.fio_label.TabIndex = 1;
            this.fio_label.Text = "ФИО";
            // 
            // mark_textBox
            // 
            this.mark_textBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_textBox.Location = new System.Drawing.Point(123, 431);
            this.mark_textBox.MaxLength = 1;
            this.mark_textBox.Name = "mark_textBox";
            this.mark_textBox.Size = new System.Drawing.Size(100, 34);
            this.mark_textBox.TabIndex = 2;
            // 
            // mark_label
            // 
            this.mark_label.AutoSize = true;
            this.mark_label.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_label.Location = new System.Drawing.Point(25, 434);
            this.mark_label.Name = "mark_label";
            this.mark_label.Size = new System.Drawing.Size(79, 28);
            this.mark_label.TabIndex = 3;
            this.mark_label.Text = "Оценка";
            // 
            // button_mark
            // 
            this.button_mark.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_mark.Location = new System.Drawing.Point(409, 427);
            this.button_mark.Name = "button_mark";
            this.button_mark.Size = new System.Drawing.Size(194, 43);
            this.button_mark.TabIndex = 22;
            this.button_mark.Text = "Поставить оценку";
            this.button_mark.UseVisualStyleBackColor = false;
            this.button_mark.Click += new System.EventHandler(this.button_mark_Click);
            // 
            // answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 509);
            this.Controls.Add(this.button_mark);
            this.Controls.Add(this.mark_label);
            this.Controls.Add(this.mark_textBox);
            this.Controls.Add(this.fio_label);
            this.Controls.Add(this.answer_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "answer";
            this.Text = "answer";
            this.Load += new System.EventHandler(this.answer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.TextBox mark_textBox;
        private System.Windows.Forms.Label mark_label;
        private System.Windows.Forms.Button button_mark;
    }
}