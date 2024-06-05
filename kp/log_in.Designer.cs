namespace kp
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.authoriz = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_incorrectLogin = new System.Windows.Forms.Label();
            this.label_emptyInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authoriz
            // 
            this.authoriz.AutoSize = true;
            this.authoriz.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authoriz.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.authoriz.Location = new System.Drawing.Point(156, 59);
            this.authoriz.Name = "authoriz";
            this.authoriz.Size = new System.Drawing.Size(238, 50);
            this.authoriz.TabIndex = 0;
            this.authoriz.Text = "Авторизация";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.login.Location = new System.Drawing.Point(110, 127);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(62, 25);
            this.login.TabIndex = 1;
            this.login.Text = "Логин";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(115, 162);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(309, 38);
            this.textBox_login.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.Location = new System.Drawing.Point(165, 253);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(216, 55);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_incorrectLogin
            // 
            this.label_incorrectLogin.AutoSize = true;
            this.label_incorrectLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_incorrectLogin.ForeColor = System.Drawing.Color.Brown;
            this.label_incorrectLogin.Location = new System.Drawing.Point(111, 214);
            this.label_incorrectLogin.Name = "label_incorrectLogin";
            this.label_incorrectLogin.Size = new System.Drawing.Size(201, 23);
            this.label_incorrectLogin.TabIndex = 8;
            this.label_incorrectLogin.Text = "Введён неверный логин";
            // 
            // label_emptyInput
            // 
            this.label_emptyInput.AutoSize = true;
            this.label_emptyInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_emptyInput.ForeColor = System.Drawing.Color.Brown;
            this.label_emptyInput.Location = new System.Drawing.Point(111, 214);
            this.label_emptyInput.Name = "label_emptyInput";
            this.label_emptyInput.Size = new System.Drawing.Size(164, 23);
            this.label_emptyInput.TabIndex = 9;
            this.label_emptyInput.Text = "Поле не заполнено";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 398);
            this.Controls.Add(this.label_emptyInput);
            this.Controls.Add(this.label_incorrectLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.login);
            this.Controls.Add(this.authoriz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_in";
            this.Text = "Relational Algebra App ";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authoriz;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_incorrectLogin;
        private System.Windows.Forms.Label label_emptyInput;
    }
}