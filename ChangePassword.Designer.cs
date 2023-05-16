
namespace Kursach_6_sem_UIP
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.matchLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.oldPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.BackColor = System.Drawing.Color.Transparent;
            this.matchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matchLabel.ForeColor = System.Drawing.Color.Red;
            this.matchLabel.Location = new System.Drawing.Point(227, 234);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(236, 28);
            this.matchLabel.TabIndex = 7;
            this.matchLabel.Text = "Пароли не совпадают!";
            this.matchLabel.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.saveBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(245, 283);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(201, 46);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(271, 176);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(156, 27);
            this.newPasswordBox.TabIndex = 5;
            this.newPasswordBox.UseSystemPasswordChar = true;
            this.newPasswordBox.TextChanged += new System.EventHandler(this.newPasswordBox_TextChanged);
            // 
            // oldPasswordBox
            // 
            this.oldPasswordBox.Location = new System.Drawing.Point(271, 110);
            this.oldPasswordBox.Name = "oldPasswordBox";
            this.oldPasswordBox.Size = new System.Drawing.Size(156, 27);
            this.oldPasswordBox.TabIndex = 4;
            this.oldPasswordBox.UseSystemPasswordChar = true;
            this.oldPasswordBox.TextChanged += new System.EventHandler(this.oldPasswordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(120, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(126, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Новый пароль";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.oldPasswordBox);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.TextBox oldPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}