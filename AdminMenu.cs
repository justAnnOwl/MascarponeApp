using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_6_sem_UIP
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

       
        private void accountBtn_Clicked(object sender, EventArgs e)
        {
            BaseWindowManager.Hide<ChangePassword>();
            BaseWindowManager.Show<ChangePassword>();
        }
        private void changeCatalogueBtn_Clicked(object sender, EventArgs e)
        {
            BaseWindowManager.Hide<AdminMenu>();
            BaseWindowManager.Show<AdminCatalogue>();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            BaseWindowManager.Hide<AdminMenu>();
            BaseWindowManager.Show<HelloPage>();
        }
    }
}
