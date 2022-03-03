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
    public partial class Display_client : MetroFramework.Forms.MetroForm
    {
        public Display_client()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;

        private void Display_client_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MINUL;Initial Catalog=Hotel;" +
                "Integrated Security=True");
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Client ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
