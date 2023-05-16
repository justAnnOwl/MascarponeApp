
namespace Kursach_6_sem_UIP
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.passwordMatchLabel = new System.Windows.Forms.Label();
            this.Далее = new System.Windows.Forms.Button();
            this.passwordBox_2 = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox_1 = new System.Windows.Forms.TextBox();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordMatchLabel
            // 
            this.passwordMatchLabel.AutoSize = true;
            this.passwordMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordMatchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordMatchLabel.Location = new System.Drawing.Point(228, 267);
            this.passwordMatchLabel.Name = "passwordMatchLabel";
            this.passwordMatchLabel.Size = new System.Drawing.Size(236, 28);
            this.passwordMatchLabel.TabIndex = 7;
            this.passwordMatchLabel.Text = "Пароли не совпадают!";
            this.passwordMatchLabel.Visible = false;
            // 
            // Далее
            // 
            this.Далее.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.Далее.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Далее.ForeColor = System.Drawing.Color.White;
            this.Далее.Location = new System.Drawing.Point(243, 306);
            this.Далее.Name = "Далее";
            this.Далее.Size = new System.Drawing.Size(201, 46);
            this.Далее.TabIndex = 6;
            this.Далее.Text = "Войти";
            this.Далее.UseVisualStyleBackColor = false;
            this.Далее.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // passwordBox_2
            // 
            this.passwordBox_2.Location = new System.Drawing.Point(270, 230);
            this.passwordBox_2.Name = "passwordBox_2";
            this.passwordBox_2.PlaceholderText = "Повторите пароль";
            this.passwordBox_2.Size = new System.Drawing.Size(156, 27);
            this.passwordBox_2.TabIndex = 5;
            this.passwordBox_2.UseSystemPasswordChar = true;
            this.passwordBox_2.TextChanged += new System.EventHandler(this.passwordBox_2_TextChanged);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(270, 113);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин";
            this.loginBox.Size = new System.Drawing.Size(156, 27);
            this.loginBox.TabIndex = 4;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            // 
            // passwordBox_1
            // 
            this.passwordBox_1.Location = new System.Drawing.Point(270, 173);
            this.passwordBox_1.Name = "passwordBox_1";
            this.passwordBox_1.PlaceholderText = "Пароль";
            this.passwordBox_1.Size = new System.Drawing.Size(156, 27);
            this.passwordBox_1.TabIndex = 8;
            this.passwordBox_1.UseSystemPasswordChar = true;
            this.passwordBox_1.TextChanged += new System.EventHandler(this.passwordBox_1_TextChanged);
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(449, 112);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(138, 28);
            this.loginErrorLabel.TabIndex = 9;
            this.loginErrorLabel.Text = "Логин занят!";
            this.loginErrorLabel.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 413);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.passwordBox_1);
            this.Controls.Add(this.passwordMatchLabel);
            this.Controls.Add(this.Далее);
            this.Controls.Add(this.passwordBox_2);
            this.Controls.Add(this.loginBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordMatchLabel;
        private System.Windows.Forms.Button Далее;
        private System.Windows.Forms.TextBox passwordBox_2;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox_1;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}