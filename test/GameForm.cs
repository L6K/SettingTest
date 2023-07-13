using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            EndGameButton.Visible = false;

            if (Properties.Settings.Default.FullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            //EndGameButton.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                EndGameButton.Visible = true;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void EndGameButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }
}
