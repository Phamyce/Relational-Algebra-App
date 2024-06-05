namespace kp
{
    partial class union
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(union));
            this.checkedListBox_tables = new System.Windows.Forms.CheckedListBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_tables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox_tables
            // 
            this.checkedListBox_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox_tables.FormattingEnabled = true;
            this.checkedListBox_tables.Location = new System.Drawing.Point(47, 81);
            this.checkedListBox_tables.Name = "checkedListBox_tables";
            this.checkedListBox_tables.Size = new System.Drawing.Size(288, 91);
            this.checkedListBox_tables.TabIndex = 13;
            this.checkedListBox_tables.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_tables_SelectedIndexChanged);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(134, 206);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(115, 60);
            this.button_ok.TabIndex = 12;
            this.button_ok.Text = "Готово";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_tables
            // 
            this.label_tables.AutoSize = true;
            this.label_tables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tables.Location = new System.Drawing.Point(42, 38);
            this.label_tables.Name = "label_tables";
            this.label_tables.Size = new System.Drawing.Size(247, 28);
            this.label_tables.TabIndex = 11;
            this.label_tables.Text = "Выберите два отношения";
            // 
            // union
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 318);
            this.Controls.Add(this.checkedListBox_tables);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_tables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "union";
            this.Text = "union";
            this.Load += new System.EventHandler(this.binaryOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_tables;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_tables;
    }
}