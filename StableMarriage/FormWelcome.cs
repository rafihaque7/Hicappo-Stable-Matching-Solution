using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StableMarriage
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void buttonGetstarted_Click(object sender, EventArgs e)
        {
            FormTotalCount formTotalCount = new FormTotalCount();
            Hide();
            formTotalCount.ShowDialog();
            Close();
        }
    }
}
