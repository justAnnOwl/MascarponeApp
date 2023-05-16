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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void catalogBtn_Click(object sender, EventArgs e)
        {
            BaseWindowManager.Hide<UserMenu>();
            BaseWindowManager.Show<Catalogue>();
        }
      
        private void accountBtn_Click(object sender, EventArgs e)
        {
            BaseWindowManager.Hide<UserMenu>();
            BaseWindowManager.Show<ChangePassword>();
        }
    }
}
