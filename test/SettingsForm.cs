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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbFullScreen.Checked)
            {
                Properties.Settings.Default.FullScreen = true;
            }
            else
            {
                Properties.Settings.Default.FullScreen = false;
            }
            Properties.Settings.Default.Save();
            this.Close();
            MenuForm menu = new MenuForm();
            menu.Show();

            
        }
    }
}
