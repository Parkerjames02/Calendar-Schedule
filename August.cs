using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarScheduleApp
{
    public partial class August : Form
    {
        public August()
        {
            InitializeComponent();
        }

        private void August_Load(object sender, EventArgs e)
        {
            LeftButton.Enabled = false;
        }

        private void August_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
