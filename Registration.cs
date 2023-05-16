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
    public partial class Registration : Form
    {
        static String passwordFirst;
        static String passwordSecond;
        static String login;
        public Registration()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // ПРОВЕРКА ЛОГИНА!

            SqlConnection sqlConn = new SqlConnection(Program.connectionString);
            sqlConn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users;", sqlConn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == login )
                    loginErrorLabel.Visible = true;

                else
                {
                    if (passwordFirst != passwordSecond)
                    {
                        passwordMatchLabel.Visible = true;
                    }
                    else
                    {
                        User.login = login;
                        User.password = passwordFirst;
                        User.role = 0;

                        SqlCommand command1 = new SqlCommand("INSERT INTO Users(Login, Hash, Role) VALUES (@login,@passwordFirst, 0); SET @User_ID=SCOPE_IDENTITY()", sqlConn);
                        
                        SqlParameter parametr = new SqlParameter();
                        parametr.ParameterName = "@login";
                        parametr.Value = login;
                        parametr.SqlDbType = SqlDbType.NVarChar;
                        command.Parameters.Add(parametr);

                        parametr = new SqlParameter();
                        parametr.ParameterName = "@passwordFirst";
                        parametr.Value = passwordFirst;
                        parametr.SqlDbType = SqlDbType.NVarChar;
                        command.Parameters.Add(parametr);

                     
                        BaseWindowManager.Hide<Registration>();
                        BaseWindowManager.Show<UserMenu>();
                    }
                }
            }

               

            
        }

        
            private void passwordBox_2_TextChanged(object sender, EventArgs e)
            {
                passwordMatchLabel.Visible = false;
          
            passwordSecond = passwordBox_2.Text;
            }

            private void passwordBox_1_TextChanged(object sender, EventArgs e)
            {
                passwordMatchLabel.Visible = false;
             
                passwordFirst = passwordBox_1.Text;
            }

            private void loginBox_TextChanged(object sender, EventArgs e)
            {
                loginErrorLabel.Visible = false;
                login = loginBox.Text;
            }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
    } 
