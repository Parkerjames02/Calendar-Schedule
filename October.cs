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
    public partial class October : Form
    {
        public October()
        {
            InitializeComponent();
        }

        private void October_Load(object sender, EventArgs e)
        {
            RightButton.Enabled = false;
        }

        private void October_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
