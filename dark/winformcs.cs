using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dark
{
    public partial class winformcs : Form
    {
        public winformcs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            running r = new running();
            r.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit...");
            Application.Exit();
        }
    }
}
