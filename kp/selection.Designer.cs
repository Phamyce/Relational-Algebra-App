namespace kp
{
    partial class selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selection));
            this.label_tables = new System.Windows.Forms.Label();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.label_condition = new System.Windows.Forms.Label();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_tables
            // 
            this.label_tables.AutoSize = true;
            this.label_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tables.Location = new System.Drawing.Point(40, 31);
            this.label_tables.Name = "label_tables";
            this.label_tables.Size = new System.Drawing.Size(181, 28);
            this.label_tables.TabIndex = 0;
            this.label_tables.Text = "Выберите таблицу";
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(45, 73);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(288, 36);
            this.comboBox_tables.TabIndex = 1;
            this.comboBox_tables.SelectedIndexChanged += new System.EventHandler(this.comboBox_tables_SelectedIndexChanged);
            // 
            // label_condition
            // 
            this.label_condition.AutoSize = true;
            this.label_condition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_condition.Location = new System.Drawing.Point(43, 127);
            this.label_condition.Name = "label_condition";
            this.label_condition.Size = new System.Drawing.Size(165, 28);
            this.label_condition.TabIndex = 2;
            this.label_condition.Text = "Введите условие";
            // 
            // textBox_condition
            // 
            this.textBox_condition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_condition.Location = new System.Drawing.Point(45, 166);
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(285, 34);
            this.textBox_condition.TabIndex = 4;
            this.textBox_condition.TextChanged += new System.EventHandler(this.textBox_condition_TextChanged);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(131, 281);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(115, 60);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "Готово";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Для объединения условий по нескольким \r\nстолбцам используйте or, and\r\n\r\n";
            // 
            // selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_condition);
            this.Controls.Add(this.label_condition);
            this.Controls.Add(this.comboBox_tables);
            this.Controls.Add(this.label_tables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selection";
            this.Text = "selection";
            this.Load += new System.EventHandler(this.selection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tables;
        private System.Windows.Forms.ComboBox comboBox_tables;
        private System.Windows.Forms.Label label_condition;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label1;
    }
}