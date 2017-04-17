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
    public partial class frmVictory : Form
    {
        public frmVictory()
        {
            InitializeComponent();
            int x = lblTitle.Location.X;
        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picReplay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmVictory_Load(object sender, EventArgs e)
        {
            if (UserInfo.PlayerClickNum <= 5)
            {
                lblTitle.Text = "获得称号：精神病院长的帮手";
            }
            else if(UserInfo.PlayerClickNum >5 && UserInfo.PlayerClickNum <=10)
            {
                lblTitle.Text = "获得称号：隔壁的王伯伯";
            }
            else if (UserInfo.PlayerClickNum > 10 && UserInfo.PlayerClickNum <= 15)
            {
                lblTitle.Text = "获得称号：根本停不下来";
            }
            else if (UserInfo.PlayerClickNum > 15 && UserInfo.PlayerClickNum <= 20)
            {
                lblTitle.Text = "获得称号：喵了个咪的";
            }
            else
            {
                lblTitle.Text = "获得称号：小菜猫";
            }
            lblInfo.Text = "您用" + UserInfo.PlayerClickNum + "步抓住了神经猫";
        }
    }
}
