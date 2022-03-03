using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_windowsform
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void registration_tile_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
        }

        private void update_tile_Click(object sender, EventArgs e)
        {
           Update_member obj = new Update_member();
            obj.ShowDialog();
        }

        private void Delete_tile_Click(object sender, EventArgs e)
        {
            Delete_member obj = new Delete_member();
            obj.ShowDialog();
        }

        private void display_tile_Click(object sender, EventArgs e)
        {
            Display_client obj = new Display_client();
            obj.Show();
        }
    }
}
