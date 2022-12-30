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
    public partial class loss : Form
    {
        public loss()
        {
            InitializeComponent();
        }

        private void Loss_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit...");
            Application.Exit();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            running r = new running();
            r.ShowDialog();
        }
    }
}
