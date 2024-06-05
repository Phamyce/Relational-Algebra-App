namespace kp
{
    partial class answerUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.button_see_answer = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fio_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.answer_status_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mark_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Controls.Add(this.button_see_answer);
            this.panel.Controls.Add(this.flowLayoutPanel);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(831, 39);
            this.panel.TabIndex = 8;
            // 
            // button_see_answer
            // 
            this.button_see_answer.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_see_answer.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_see_answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_see_answer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_see_answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_see_answer.Location = new System.Drawing.Point(658, 0);
            this.button_see_answer.Name = "button_see_answer";
            this.button_see_answer.Size = new System.Drawing.Size(173, 39);
            this.button_see_answer.TabIndex = 8;
            this.button_see_answer.TabStop = false;
            this.button_see_answer.Text = "Посмотреть ответ";
            this.button_see_answer.UseVisualStyleBackColor = false;
            this.button_see_answer.Click += new System.EventHandler(this.button_see_answer_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel.Controls.Add(this.splitter2);
            this.flowLayoutPanel.Controls.Add(this.splitter3);
            this.flowLayoutPanel.Controls.Add(this.splitter4);
            this.flowLayoutPanel.Controls.Add(this.statusStrip1);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(636, 39);
            this.flowLayoutPanel.TabIndex = 8;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 28);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(12, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 28);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(21, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 28);
            this.splitter4.TabIndex = 2;
            this.splitter4.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fio_toolStripStatusLabel,
            this.answer_status_toolStripStatusLabel,
            this.mark_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(27, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(422, 34);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fio_toolStripStatusLabel
            // 
            this.fio_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_toolStripStatusLabel.Name = "fio_toolStripStatusLabel";
            this.fio_toolStripStatusLabel.Size = new System.Drawing.Size(56, 28);
            this.fio_toolStripStatusLabel.Text = "ФИО";
            // 
            // answer_status_toolStripStatusLabel
            // 
            this.answer_status_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_status_toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answer_status_toolStripStatusLabel.Name = "answer_status_toolStripStatusLabel";
            this.answer_status_toolStripStatusLabel.Size = new System.Drawing.Size(195, 28);
            this.answer_status_toolStripStatusLabel.Text = "Статус сдачи работы";
            // 
            // mark_toolStripStatusLabel
            // 
            this.mark_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_toolStripStatusLabel.Name = "mark_toolStripStatusLabel";
            this.mark_toolStripStatusLabel.Size = new System.Drawing.Size(117, 28);
            this.mark_toolStripStatusLabel.Text = "Не оценено";
            // 
            // answerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "answerUserControl";
            this.Size = new System.Drawing.Size(834, 52);
            this.Load += new System.EventHandler(this.answerUserControl_Load);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_see_answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fio_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel answer_status_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mark_toolStripStatusLabel;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
    }
}
