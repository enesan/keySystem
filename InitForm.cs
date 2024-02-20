using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_systemAlpha
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text.Equals("") && passBox.Text.Equals(""))
            {
                new Boss().Show();
                this.Close();
            }
            else if (loginBox.Text.Equals("1") && passBox.Text.Equals("1"))
            {
                new Form1().Show();
                this.Close();
            }
        }

        private void InitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
