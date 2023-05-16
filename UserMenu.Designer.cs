
namespace Kursach_6_sem_UIP
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            this.catalogBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogBtn
            // 
            this.catalogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.catalogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogBtn.ForeColor = System.Drawing.Color.White;
            this.catalogBtn.Location = new System.Drawing.Point(248, 89);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(252, 56);
            this.catalogBtn.TabIndex = 3;
            this.catalogBtn.Text = "КАТАЛОГ";
            this.catalogBtn.UseVisualStyleBackColor = false;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.accountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.Location = new System.Drawing.Point(248, 190);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(252, 56);
            this.accountBtn.TabIndex = 4;
            this.accountBtn.Text = "УЧЕТНАЯ ЗАПИСЬ";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(248, 290);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(252, 56);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "ВЫХОД";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.catalogBtn);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catalogBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}