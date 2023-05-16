
namespace Kursach_6_sem_UIP
{
    partial class PersonalRegistration_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalRegistration_2));
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(253, 239);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.PlaceholderText = "Дом";
            this.phoneBox.Size = new System.Drawing.Size(82, 27);
            this.phoneBox.TabIndex = 14;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(253, 181);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "Улица";
            this.surnameBox.Size = new System.Drawing.Size(201, 27);
            this.surnameBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(253, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(253, 118);
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Город";
            this.nameBox.Size = new System.Drawing.Size(201, 27);
            this.nameBox.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Квартира";
            this.textBox1.Size = new System.Drawing.Size(92, 27);
            this.textBox1.TabIndex = 15;
            // 
            // PersonalRegistration_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Name = "PersonalRegistration_2";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}