using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchSubs4Vids
{
    public partial class ConsoleLogForm : Form
    {
        public ConsoleLogForm()
        {
            InitializeComponent();
        }

        public void ShowMsg(string message)
        {
            lConsoleLog.Text = message;

            lConsoleLog.SelectionStart = lConsoleLog.TextLength;
            lConsoleLog.ScrollToCaret();

            //this.ShowDialog();
        }

        public void AppendShowMsg(string message)
        {
            lConsoleLog.Text += message;

            lConsoleLog.SelectionStart = lConsoleLog.TextLength;
            lConsoleLog.ScrollToCaret();

            //this.ShowDialog();
        }

        private void ConsoleLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
            {
                this.Hide();
            }
        }
    }
}
