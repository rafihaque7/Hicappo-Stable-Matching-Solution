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
    public partial class FormMaleName : Form
    {
        ListView listViewMale;
        Label labelCurrentMale;
        

        public FormMaleName(ListView listViewMale, Label labelCurrentMale)
        {
            InitializeComponent();
            this.listViewMale = listViewMale;
            this.labelCurrentMale = labelCurrentMale;
        

        }

        private void buttonAddMale_Click(object sender, EventArgs e)
        {
            listViewMale.Items.Add(textMaleName.Text);
            textMaleName.Text = null;

            //Updates the counter
            labelCurrentMale.Text = listViewMale.Items.Count.ToString();
            checkCountforMale();



        }

        private void textMaleName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonAddMale;
        }

        private void checkCountforMale()
        {
            if (listViewMale.Items.Count == FormMainInput.halfCount)
            {
                Close();
            }
        }

    }
}
