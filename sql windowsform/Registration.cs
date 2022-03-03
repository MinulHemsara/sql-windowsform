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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MINUL;Initial Catalog=Hotel;" +
                "Integrated Security=True");
        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_Click(object sender, EventArgs e)
        {

        }

        private void txt_age_Click(object sender, EventArgs e)
        {

        }

        private void txt_tp_Click(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {          
            con.Open();
            cmd = new SqlCommand("Insert client values ('"+txt_id.Text+"','"+txt_name.Text+"'," +
                "'"+txt_address.Text+"','"+date_picker+"','"+txt_age+"'," +
                "'"+txt_tp+"')", con);
            
           int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save successfully", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data cannot save", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            con.Close();
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - date_picker.Value.Year).ToString();
        }
    }
}
