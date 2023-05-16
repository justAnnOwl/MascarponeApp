using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_6_sem_UIP
{
    public partial class ChangePassword : Form
    {
        static String oldPassword;
        static String newPassword;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void oldPasswordBox_TextChanged(object sender, EventArgs e)
        {
            matchLabel.Visible = false;
            oldPassword = oldPasswordBox.Text;
        }

        private void newPasswordBox_TextChanged(object sender, EventArgs e)
        {
            matchLabel.Visible = false;
            newPassword = newPasswordBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (oldPassword != newPassword)
            {
                matchLabel.Visible = true;
            }
            else
            {
                String login = User.login;

                SqlConnection sqlConn = new SqlConnection(Program.connectionString);
                sqlConn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Users(Hash) VALUES (@newPassword) WHERE Useres.Login=@login", sqlConn);         
              //  SqlDataReader reader = command.ExecuteReader();

                SqlParameter parametr = new SqlParameter();
                parametr.ParameterName = "@newPassword";
                parametr.Value = newPassword;
                parametr.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parametr);
            }
        }
    }
}
