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

namespace VULCAN_TOP_CASINO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttoncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\VULCAN_TOP_CASINO\VULCAN_TOP_CASINO\Database1.mdf;Integrated Security=True;");
            con.Open();
            String str1 = "select name, email, pass from users where email='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("hi " + dr["name"].ToString() + " thank you for using this app");
                }
            }
            else
            {
                MessageBox.Show("login failed");
            }
        }
    }
}
