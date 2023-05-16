using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Kursach_6_sem_UIP
{
    public partial class AdminCatalogue : Form
    {
        public AdminCatalogue()
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

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String querystring = "SELECT * FROM Treats";
            SqlDataAdapter da = new SqlDataAdapter(querystring, Program.connectionString);
           DataSet ds = new DataSet();
            SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
            da.Update(ds, "Events");
        }
    }
}
