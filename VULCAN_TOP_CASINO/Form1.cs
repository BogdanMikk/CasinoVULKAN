using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VULCAN_TOP_CASINO
{
    public partial class MForm : Form//////
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginForm fl = new LoginForm();
            fl.ShowDialog();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            RegisterForm f2 = new RegisterForm();
            f2.Show();
        }
    }
}
