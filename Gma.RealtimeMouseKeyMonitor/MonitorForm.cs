using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Gma.RealtimeMouseKeyMonitor
{
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    cbspacebar.CheckState = CheckState.Checked;
                    break;

                case Keys.Return:
                    cbenter.CheckState = CheckState.Checked;
                    break;
            }
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    cbspacebar.CheckState = CheckState.Unchecked;
                    break;

                case Keys.Return:
                    cbenter.CheckState = CheckState.Unchecked;
                    break;
            }
        }

        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cbleftmouse.CheckState = CheckState.Checked;
            }
        }

        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cbleftmouse.CheckState = CheckState.Unchecked;
            }
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            HookManager.KeyDown += HookManager_KeyDown;
            HookManager.KeyUp += HookManager_KeyUp;
            HookManager.MouseDown += HookManager_MouseDown;
            HookManager.MouseUp += HookManager_MouseUp;
        }
    }
}
