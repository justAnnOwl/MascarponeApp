using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Kursach_6_sem_UIP
{
   
    static class Program
    {
        /*  static async Task Main(string[] args)
          {
              string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

              // �������� �����������
              SqlConnection connection = new SqlConnection(connectionString);
              try
              {
                  // ��������� �����������
                  await connection.OpenAsync();
                  Console.WriteLine("����������� �������");
              }
              catch (SqlException ex)
              {
                  Console.WriteLine(ex.Message);
              }
              finally
              {

                  if (connection.State == ConnectionState.Open)
                  {
                      await connection.CloseAsync();
                      Console.WriteLine("����������� �������...");
                  }
              }
              Console.WriteLine("��������� ��������� ������.");
              Console.Read();
          }*/
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HelloPage());

            
        }     
       public const String connectionString = @"Data Source=ANN;Initial Catalog=AppDB;Integrated Security=True";

    }
}
