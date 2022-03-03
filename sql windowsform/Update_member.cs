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
    public partial class Update_member : MetroFramework.Forms.MetroForm
    {
        public Update_member()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Update_member_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MINUL;Initial Catalog=Hotel;" +
                "Integrated Security=True");
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - date_picker.Value.Year).ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Update Client set  Client_Name= '" + txt_name.Text + "', Client_Address = '" + txt_address.Text + "', Client_DOB=  '" + date_picker.Value+ "'," +
                " Client_Age= '" + txt_age.Text + "', Client_TP= '" + txt_tp.Text + "' where Client_Id = '" + txt_id.Text + "'", con);


            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MetroFramework.MetroMessageBox.Show(this,"Data Update Successfully", "Information",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this,"Data cannot save","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();        }
    }
}
