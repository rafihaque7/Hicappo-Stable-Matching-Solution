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
    public partial class FormFemaleName : Form
    {
        ListView listViewFemale;
        Label labelCurrentFemale;
        public FormFemaleName(ListView listViewFemale, Label labelCurrentFemale)
        {
            InitializeComponent();
            this.listViewFemale = listViewFemale;
            this.labelCurrentFemale = labelCurrentFemale;
        }

        private void buttonAddFemale_Click(object sender, EventArgs e)
        {
            listViewFemale.Items.Add(textFemaleName.Text);
            textFemaleName.Text = null;

            labelCurrentFemale.Text = listViewFemale.Items.Count.ToString();
            checkCountforFemale();
        }

        private void textFemaleName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonAddFemale;
        }

        private void checkCountforFemale()
        {
            if (listViewFemale.Items.Count == FormMainInput.halfCount)
            {
                Close();
            }
        }
    }
}
