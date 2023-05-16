using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
//using System.Windows.Controls.Ribbon;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// System.Data.SqlClient;


namespace Kursach_6_sem_UIP
{
    partial class Catalogue
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
        /*
        static DataTable ExecuteSql(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(
                "Data Source=.\\SQLEXPRESS;Integrated Security=True;Initial Catalog=base"
                );

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();

                using (read)
                {
                    dt.Load(read);
                }
            }
        
            return dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = ExecuteSql("SELECT * FROM Users");
            listviewUsers.ItemsSource = dt.DefaultView;
        }*/
    

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogue));
            this.label1 = new System.Windows.Forms.Label();
            this.zapBtn = new System.Windows.Forms.Button();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.CatdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CatdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(249, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "КАТАЛОГ";
            // 
            // zapBtn
            // 
            this.zapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.zapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zapBtn.ForeColor = System.Drawing.Color.White;
            this.zapBtn.Location = new System.Drawing.Point(174, 347);
            this.zapBtn.Name = "zapBtn";
            this.zapBtn.Size = new System.Drawing.Size(208, 42);
            this.zapBtn.TabIndex = 6;
            this.zapBtn.Text = "Подробнее";
            this.zapBtn.UseVisualStyleBackColor = false;
            // 
            // catalogBtn
            // 
            this.catalogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.catalogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogBtn.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogBtn.ForeColor = System.Drawing.Color.White;
            this.catalogBtn.Location = new System.Drawing.Point(12, 12);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(105, 42);
            this.catalogBtn.TabIndex = 5;
            this.catalogBtn.Text = "Назад";
            this.catalogBtn.UseVisualStyleBackColor = false;
            // 
            // CatdataGridView
            // 
            this.CatdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatdataGridView.Location = new System.Drawing.Point(75, 107);
            this.CatdataGridView.Name = "CatdataGridView";
            this.CatdataGridView.RowHeadersWidth = 51;
            this.CatdataGridView.RowTemplate.Height = 29;
            this.CatdataGridView.Size = new System.Drawing.Size(441, 188);
            this.CatdataGridView.TabIndex = 7;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 413);
            this.Controls.Add(this.CatdataGridView);
            this.Controls.Add(this.zapBtn);
            this.Controls.Add(this.catalogBtn);
            this.Controls.Add(this.label1);
            this.Name = "Catalogue";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.CatdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Button zapBtn;
        private Button catalogBtn;
        private DataGridView CatdataGridView;
    }
}