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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\VULCAN_TOP_CASINO\VULCAN_TOP_CASINO\Database1.mdf;Integrated Security=True;");
                        String str = "insert into users (name,email,pass) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you are registred, thank you!");
                        this.Close();
                    }
                    else
                    {
                        label5.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You do not fill data!");
                }
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
