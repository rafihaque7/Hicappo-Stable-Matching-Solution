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
    public partial class FormPreference : Form
    {
        public FormPreference()
        {
            InitializeComponent();
        }

        int[,] menPref;
        int[,] womenPref;
        int gender;
        int index;
        ListViewItem[] arrMaleName;
        ListViewItem[] arrFemaleName;

        public void updateForm(ListViewItem[] arrMaleName, ListViewItem[] arrFemaleName,int[,] menPref, int[,] womenPref,int gender, int index)
        {
            labelPreferenceName.Text = gender==0 ? arrMaleName[index].Text : arrFemaleName[index].Text;

            //Generates the listview items
            switch (gender)
            {
                case 0:
                    for (int i = 0; i < arrFemaleName.Length; i++)
                    {
                        listViewPreference.Items.Add(arrFemaleName[menPref[index,i]].Text);
                    }
                    break;
                case 1:
                    for (int i = 0; i < arrMaleName.Length; i++)
                    {
                        listViewPreference.Items.Add(arrMaleName[womenPref[index, i]].Text);
                    }
                    break;
             
            }

            this.menPref = menPref;
            this.womenPref = womenPref;
            this.gender = gender;
            this.index = index;
            this.arrMaleName = arrMaleName;
            this.arrFemaleName = arrFemaleName;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewPreference.SelectedItems)
            {
                if (lvi.Index > 0)
                {
                    int index = lvi.Index - 1;
                    swapPref(lvi.Index, index);
                    listViewPreference.Items.RemoveAt(lvi.Index);
                    listViewPreference.Items.Insert(index, lvi);

                }
            }
        }

        void swapPref(int a, int b)
        {
            switch (gender)
            {
                case 0:
                    int temp = menPref[index, a];
                    menPref[index, a] = menPref[index, b];
                    menPref[index, b] = temp;
                    break;

                case 1:
                    int temp2 = womenPref[index, a];
                    womenPref[index, a] = womenPref[index, b];
                    womenPref[index, b] = temp2;
                    break;
            }
             
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewPreference.SelectedItems)
            {
                if (lvi.Index < arrMaleName.Length-1)
                {
                    int index = lvi.Index + 1;
                    swapPref(lvi.Index, index);
                    listViewPreference.Items.RemoveAt(lvi.Index);
                    listViewPreference.Items.Insert(index, lvi);

                    //MessageBox.Show(arrMaleName.Length.ToString());

                }
            }

        }
    }
}
