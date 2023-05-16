
namespace Kursach_6_sem_UIP
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.changeCatalogueBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeCatalogueBtn
            // 
            this.changeCatalogueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.changeCatalogueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCatalogueBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeCatalogueBtn.ForeColor = System.Drawing.Color.White;
            this.changeCatalogueBtn.Location = new System.Drawing.Point(226, 198);
            this.changeCatalogueBtn.Name = "changeCatalogueBtn";
            this.changeCatalogueBtn.Size = new System.Drawing.Size(252, 80);
            this.changeCatalogueBtn.TabIndex = 8;
            this.changeCatalogueBtn.Text = "ИЗМЕНИТЬ КАТАЛОГ";
            this.changeCatalogueBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(12, 353);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 45);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "ВЫХОД";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.accountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.Location = new System.Drawing.Point(226, 106);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(252, 56);
            this.accountBtn.TabIndex = 11;
            this.accountBtn.Text = "УЧЕТНАЯ ЗАПИСЬ";
            this.accountBtn.UseVisualStyleBackColor = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 410);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.changeCatalogueBtn);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeCatalogueBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button accountBtn;
    }
}