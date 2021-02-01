using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void login_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes form1 = new Notes();
            form1.Show();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Show();
        }
    }
}
