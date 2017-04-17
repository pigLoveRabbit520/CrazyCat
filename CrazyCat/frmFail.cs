using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrayzyCat
{
    public partial class frmFail : Form
    {
        public frmFail()
        {
            InitializeComponent();
        }

        private void picReplay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
