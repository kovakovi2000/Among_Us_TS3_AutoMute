using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us_TS3BotUpdate
{
    public partial class GameWatcher : Form
    {
        public GameWatcher()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            panel_CrewImp.BackColor = Color.Lime;
            panel_p0.BackColor = Color.Lime;
            panel_p1.BackColor = Color.Lime;
            panel_p2.BackColor = Color.Lime;
            panel_p3.BackColor = Color.Lime;
            panel_p4.BackColor = Color.Lime;
            panel_p5.BackColor = Color.Lime;
            panel_p6.BackColor = Color.Lime;
            panel_p7.BackColor = Color.Lime;
            panel_p8.BackColor = Color.Lime;
            panel_p9.BackColor = Color.Lime;
            panel_VoteProcEnd.BackColor = Color.Lime;
            panel_WinDef.BackColor = Color.Lime;
            panel_TabletCorner.BackColor = Color.Lime;
        }
    }
}
