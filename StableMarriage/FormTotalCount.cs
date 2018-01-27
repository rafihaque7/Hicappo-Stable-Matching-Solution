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
    public partial class FormTotalCount : Form
    {
        
        public FormTotalCount()
        {
            InitializeComponent();
        }

        private void buttonTotalCount_Click(object sender, EventArgs e)
        {

            int totalCount = 0;
            try
            {
                totalCount = Convert.ToInt32(textTotalCount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (totalCount % 2 == 0)
            {
                string msg = "So " + totalCount / 2 + " Boys and " + totalCount / 2 + " Girls!";
                MessageBox.Show(msg);
                FormMainInput formMainInput = new FormMainInput(totalCount);
                Hide();
                formMainInput.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("The number is not even or valid");
            }


        
        }

        private void textTotalCount_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonTotalCount;
        }
    }
}
