using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Kursach_6_sem_UIP
{
    public partial class Catalogue : Form
    {
        public Catalogue()
        {
            InitializeComponent();
            CatForm_Load();
        }

        private void CatForm_Load()
        {
            CatdataGridView.DataSource = GetCatList();
        }

        private DataTable GetCatList()
        {
            DataTable dtCat = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        //    MessageBox.Show(ConfigurationManager.ConnectionStrings["dbx"].ToString());
            /*
            using (StreamWriter writer = new StreamWriter("file111.txt", false))
            {
                 writer.WriteLineAsync(ConfigurationManager.ConnectionStrings["dbx"].ToString());
            }*/
           // Console.WriteLine(ConfigurationManager.ConnectionStrings["dbx"]);
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Treat_name as Название, Price as [Цена, руб/кг] FROM Treats", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCat.Load(reader);
                }
            }
            return dtCat;
        }

    }
}
