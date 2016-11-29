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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\VULCAN_TOP_CASINO\VULCAN_TOP_CASINO\Database1.mdf;Integrated Security=True;");
            con.Open();
            String str = "update users set money = money + ('" + textBox1.Text + "') where id = ('" + Class1.Id + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Class1.Money = Convert.ToDouble(dr["money"]);
            }
            con.Close();
        }
    }
}
