namespace kp
{
    partial class projection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projection));
            this.label_columns = new System.Windows.Forms.Label();
            this.label_tables = new System.Windows.Forms.Label();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkedListBox_columns = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label_columns
            // 
            this.label_columns.AutoSize = true;
            this.label_columns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_columns.Location = new System.Drawing.Point(40, 131);
            this.label_columns.Name = "label_columns";
            this.label_columns.Size = new System.Drawing.Size(287, 28);
            this.label_columns.TabIndex = 1;
            this.label_columns.Text = "Выберите атрибут отношения";
            // 
            // label_tables
            // 
            this.label_tables.AutoSize = true;
            this.label_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tables.Location = new System.Drawing.Point(40, 37);
            this.label_tables.Name = "label_tables";
            this.label_tables.Size = new System.Drawing.Size(210, 28);
            this.label_tables.TabIndex = 2;
            this.label_tables.Text = "Выберите отношение";
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(45, 79);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(288, 36);
            this.comboBox_tables.TabIndex = 3;
            this.comboBox_tables.SelectedIndexChanged += new System.EventHandler(this.comboBox_tables_SelectedIndexChanged);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_ok.Location = new System.Drawing.Point(133, 300);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(115, 60);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "Готово";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkedListBox_columns
            // 
            this.checkedListBox_columns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox_columns.FormattingEnabled = true;
            this.checkedListBox_columns.Location = new System.Drawing.Point(45, 174);
            this.checkedListBox_columns.Name = "checkedListBox_columns";
            this.checkedListBox_columns.Size = new System.Drawing.Size(288, 91);
            this.checkedListBox_columns.TabIndex = 6;
            this.checkedListBox_columns.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_columns_SelectedIndexChanged);
            // 
            // projection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 404);
            this.Controls.Add(this.checkedListBox_columns);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox_tables);
            this.Controls.Add(this.label_tables);
            this.Controls.Add(this.label_columns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "projection";
            this.Text = "projection";
            this.Load += new System.EventHandler(this.projection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_columns;
        private System.Windows.Forms.Label label_tables;
        private System.Windows.Forms.ComboBox comboBox_tables;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckedListBox checkedListBox_columns;
    }
}