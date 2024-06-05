namespace kp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_projection = new System.Windows.Forms.Button();
            this.button_selection = new System.Windows.Forms.Button();
            this.button_union = new System.Windows.Forms.Button();
            this.button_intersection = new System.Windows.Forms.Button();
            this.flowLayoutPanel_tables = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.provider = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel_result = new System.Windows.Forms.FlowLayoutPanel();
            this.button_exception = new System.Windows.Forms.Button();
            this.button_cross_join = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_natural_join = new System.Windows.Forms.Button();
            this.button_leftjoin = new System.Windows.Forms.Button();
            this.button_rightjoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_projection
            // 
            this.button_projection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_projection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_projection.ForeColor = System.Drawing.SystemColors.Control;
            this.button_projection.Image = ((System.Drawing.Image)(resources.GetObject("button_projection.Image")));
            this.button_projection.Location = new System.Drawing.Point(31, 61);
            this.button_projection.Name = "button_projection";
            this.button_projection.Size = new System.Drawing.Size(75, 75);
            this.button_projection.TabIndex = 1;
            this.button_projection.TabStop = false;
            this.button_projection.UseVisualStyleBackColor = false;
            this.button_projection.Click += new System.EventHandler(this.button_projection_Click);
            // 
            // button_selection
            // 
            this.button_selection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selection.ForeColor = System.Drawing.SystemColors.Control;
            this.button_selection.Image = ((System.Drawing.Image)(resources.GetObject("button_selection.Image")));
            this.button_selection.Location = new System.Drawing.Point(31, 137);
            this.button_selection.Name = "button_selection";
            this.button_selection.Size = new System.Drawing.Size(75, 75);
            this.button_selection.TabIndex = 3;
            this.button_selection.TabStop = false;
            this.button_selection.UseVisualStyleBackColor = false;
            this.button_selection.Click += new System.EventHandler(this.button_selection_Click);
            // 
            // button_union
            // 
            this.button_union.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_union.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_union.ForeColor = System.Drawing.SystemColors.Control;
            this.button_union.Image = ((System.Drawing.Image)(resources.GetObject("button_union.Image")));
            this.button_union.Location = new System.Drawing.Point(108, 61);
            this.button_union.Name = "button_union";
            this.button_union.Size = new System.Drawing.Size(75, 75);
            this.button_union.TabIndex = 4;
            this.button_union.TabStop = false;
            this.button_union.UseVisualStyleBackColor = false;
            this.button_union.Click += new System.EventHandler(this.button_union_Click);
            // 
            // button_intersection
            // 
            this.button_intersection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_intersection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_intersection.ForeColor = System.Drawing.SystemColors.Control;
            this.button_intersection.Image = ((System.Drawing.Image)(resources.GetObject("button_intersection.Image")));
            this.button_intersection.Location = new System.Drawing.Point(108, 137);
            this.button_intersection.Name = "button_intersection";
            this.button_intersection.Size = new System.Drawing.Size(75, 75);
            this.button_intersection.TabIndex = 5;
            this.button_intersection.TabStop = false;
            this.button_intersection.UseVisualStyleBackColor = false;
            this.button_intersection.Click += new System.EventHandler(this.button_intersection_Click);
            // 
            // flowLayoutPanel_tables
            // 
            this.flowLayoutPanel_tables.AutoScroll = true;
            this.flowLayoutPanel_tables.Controls.Add(this.label4);
            this.flowLayoutPanel_tables.Controls.Add(this.employee);
            this.flowLayoutPanel_tables.Controls.Add(this.label5);
            this.flowLayoutPanel_tables.Controls.Add(this.provider);
            this.flowLayoutPanel_tables.Location = new System.Drawing.Point(31, 293);
            this.flowLayoutPanel_tables.Name = "flowLayoutPanel_tables";
            this.flowLayoutPanel_tables.Size = new System.Drawing.Size(495, 179);
            this.flowLayoutPanel_tables.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Сотрудники";
            // 
            // employee
            // 
            this.employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.Location = new System.Drawing.Point(3, 23);
            this.employee.Name = "employee";
            this.employee.RowHeadersVisible = false;
            this.employee.RowHeadersWidth = 51;
            this.employee.RowTemplate.Height = 24;
            this.employee.Size = new System.Drawing.Size(455, 146);
            this.employee.TabIndex = 8;
            this.employee.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поставщики";
            // 
            // provider
            // 
            this.provider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.provider.BackgroundColor = System.Drawing.SystemColors.Control;
            this.provider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider.Location = new System.Drawing.Point(3, 195);
            this.provider.Name = "provider";
            this.provider.RowHeadersVisible = false;
            this.provider.RowHeadersWidth = 51;
            this.provider.RowTemplate.Height = 24;
            this.provider.Size = new System.Drawing.Size(455, 150);
            this.provider.TabIndex = 9;
            this.provider.TabStop = false;
            // 
            // flowLayoutPanel_result
            // 
            this.flowLayoutPanel_result.AutoScroll = true;
            this.flowLayoutPanel_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel_result.Location = new System.Drawing.Point(568, 61);
            this.flowLayoutPanel_result.Name = "flowLayoutPanel_result";
            this.flowLayoutPanel_result.Size = new System.Drawing.Size(581, 411);
            this.flowLayoutPanel_result.TabIndex = 8;
            // 
            // button_exception
            // 
            this.button_exception.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exception.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exception.Image = ((System.Drawing.Image)(resources.GetObject("button_exception.Image")));
            this.button_exception.Location = new System.Drawing.Point(185, 61);
            this.button_exception.Name = "button_exception";
            this.button_exception.Size = new System.Drawing.Size(75, 75);
            this.button_exception.TabIndex = 9;
            this.button_exception.TabStop = false;
            this.button_exception.UseVisualStyleBackColor = false;
            this.button_exception.Click += new System.EventHandler(this.button_exception_Click);
            // 
            // button_cross_join
            // 
            this.button_cross_join.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cross_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cross_join.ForeColor = System.Drawing.SystemColors.Control;
            this.button_cross_join.Image = ((System.Drawing.Image)(resources.GetObject("button_cross_join.Image")));
            this.button_cross_join.Location = new System.Drawing.Point(185, 137);
            this.button_cross_join.Name = "button_cross_join";
            this.button_cross_join.Size = new System.Drawing.Size(75, 75);
            this.button_cross_join.TabIndex = 10;
            this.button_cross_join.TabStop = false;
            this.button_cross_join.UseVisualStyleBackColor = false;
            this.button_cross_join.Click += new System.EventHandler(this.button_cross_join_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.Control;
            this.button_reset.Image = ((System.Drawing.Image)(resources.GetObject("button_reset.Image")));
            this.button_reset.Location = new System.Drawing.Point(340, 138);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 75);
            this.button_reset.TabIndex = 11;
            this.button_reset.TabStop = false;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_natural_join
            // 
            this.button_natural_join.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_natural_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_natural_join.ForeColor = System.Drawing.SystemColors.Control;
            this.button_natural_join.Image = ((System.Drawing.Image)(resources.GetObject("button_natural_join.Image")));
            this.button_natural_join.Location = new System.Drawing.Point(339, 61);
            this.button_natural_join.Name = "button_natural_join";
            this.button_natural_join.Size = new System.Drawing.Size(75, 75);
            this.button_natural_join.TabIndex = 12;
            this.button_natural_join.TabStop = false;
            this.button_natural_join.UseVisualStyleBackColor = false;
            this.button_natural_join.Click += new System.EventHandler(this.button_natural_join_Click);
            // 
            // button_leftjoin
            // 
            this.button_leftjoin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_leftjoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_leftjoin.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_leftjoin.ForeColor = System.Drawing.SystemColors.Control;
            this.button_leftjoin.Image = ((System.Drawing.Image)(resources.GetObject("button_leftjoin.Image")));
            this.button_leftjoin.Location = new System.Drawing.Point(262, 61);
            this.button_leftjoin.Name = "button_leftjoin";
            this.button_leftjoin.Size = new System.Drawing.Size(75, 75);
            this.button_leftjoin.TabIndex = 14;
            this.button_leftjoin.TabStop = false;
            this.button_leftjoin.UseVisualStyleBackColor = false;
            this.button_leftjoin.Click += new System.EventHandler(this.button_leftjoin_Click);
            // 
            // button_rightjoin
            // 
            this.button_rightjoin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_rightjoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rightjoin.ForeColor = System.Drawing.SystemColors.Control;
            this.button_rightjoin.Image = ((System.Drawing.Image)(resources.GetObject("button_rightjoin.Image")));
            this.button_rightjoin.Location = new System.Drawing.Point(262, 138);
            this.button_rightjoin.Name = "button_rightjoin";
            this.button_rightjoin.Size = new System.Drawing.Size(75, 75);
            this.button_rightjoin.TabIndex = 15;
            this.button_rightjoin.TabStop = false;
            this.button_rightjoin.UseVisualStyleBackColor = false;
            this.button_rightjoin.Click += new System.EventHandler(this.button_rightjoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Операторы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(29, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Отношения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(563, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Вывод запроса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_rightjoin);
            this.Controls.Add(this.button_leftjoin);
            this.Controls.Add(this.button_natural_join);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_cross_join);
            this.Controls.Add(this.button_exception);
            this.Controls.Add(this.flowLayoutPanel_result);
            this.Controls.Add(this.flowLayoutPanel_tables);
            this.Controls.Add(this.button_intersection);
            this.Controls.Add(this.button_union);
            this.Controls.Add(this.button_selection);
            this.Controls.Add(this.button_projection);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel_tables.ResumeLayout(false);
            this.flowLayoutPanel_tables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_projection;
        private System.Windows.Forms.Button button_selection;
        private System.Windows.Forms.Button button_union;
        private System.Windows.Forms.Button button_intersection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_tables;
        private System.Windows.Forms.DataGridView employee;
        private System.Windows.Forms.DataGridView provider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_result;
        private System.Windows.Forms.Button button_exception;
        private System.Windows.Forms.Button button_cross_join;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_natural_join;
        private System.Windows.Forms.Button button_leftjoin;
        private System.Windows.Forms.Button button_rightjoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

