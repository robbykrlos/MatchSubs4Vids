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
        private readonly MainForm mainForm;

        //avoid showing "X" close button.
        private const int CS_NOCLOSE = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams mdiCp = base.CreateParams;
                mdiCp.ClassStyle = mdiCp.ClassStyle | CS_NOCLOSE;

                return mdiCp;
            }
        }

        public ConsoleLogForm(MainForm parentMainForm)
        {
            InitializeComponent();
            this.mainForm = parentMainForm;
        }

        public void ShowMsg(string message)
        {
            lConsoleLog.Text = message;

            lConsoleLog.SelectionStart = lConsoleLog.TextLength;
            lConsoleLog.ScrollToCaret();
        }

        private void ConsoleLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
            {
                this.Hide();
                this.mainForm.pbProgress.Value = 0;
            }
        }
    }
}
