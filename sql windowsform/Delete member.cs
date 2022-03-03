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

namespace sql_windowsform
{
    public partial class Delete_member : MetroFramework.Forms.MetroForm
    {
        public Delete_member()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Delete_member_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MINUL;Initial Catalog=Hotel;Integrated Security=True");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Delete from Client where Client_Id = '" + txt_id.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MetroFramework.MetroMessageBox.Show(this, "Data delete successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "Data cannot delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_id.Text = String.Empty;
        }
    }
}
