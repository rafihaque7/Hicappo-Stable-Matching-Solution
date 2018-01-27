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
    public partial class FormMainInput : Form
    {
        int totalCount;
        public static int halfCount;
        ListViewItem[] arrMaleName;
        ListViewItem[] arrFemaleName;

        int[,] menPref;
        int[,] womenPref;
        int nextInvisIter = 0;
       

        public FormMainInput(int num)
        {
            InitializeComponent();
            listViewMale.Columns.Add("Name",200);
            listViewFemale.Columns.Add("Name",200);
            totalCount = num;
            halfCount = num / 2;

            //Displays in green what it is suppose to be
            labelHalfCountMale.Text = halfCount.ToString();
            labelHalfCountFemale.Text = halfCount.ToString();

            //Next button is greyed 
            buttonNextinvis.Enabled = false;

            //Display the current count
            labelCurrentMale.Text = listViewMale.Items.Count.ToString();
            labelCurrentFemale.Text = listViewFemale.Items.Count.ToString();
            //Make the preference button invisible
            buttonPreference.Visible = false;
       

        }

        private void buttonAddMale_Click(object sender, EventArgs e)
        {
            FormMaleName formMaleName = new FormMaleName(listViewMale, labelCurrentMale);
            formMaleName.ShowDialog();

            checkCountforNextbtn();

        }



        private void buttonAddFemale_Click(object sender, EventArgs e)
        {
            FormFemaleName formFemaleName = new FormFemaleName(listViewFemale, labelCurrentFemale);
            formFemaleName.ShowDialog();
            checkCountforNextbtn();

        }

        public void setlabelCurrentFemale()
        {
            labelCurrentFemale.Text = listViewFemale.Items.Count.ToString();
        }

        //Checks whether the number of items in male and female list equals the desired amount -> Next button becomes visible
        public void checkCountforNextbtn()
        {
            if ((listViewMale.Items.Count == halfCount) && (listViewFemale.Items.Count == halfCount))
            {
                buttonNextinvis.Enabled = true;

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listViewMale.SelectedItems)
            {
                listViewMale.Items.Remove(eachItem);
            }

            foreach (ListViewItem eachItem in listViewFemale.SelectedItems)
            {
                listViewFemale.Items.Remove(eachItem);
            }

            labelCurrentMale.Text = listViewMale.Items.Count.ToString();
            labelCurrentFemale.Text = listViewFemale.Items.Count.ToString();
        }

        private void buttonNextinvis_Click(object sender, EventArgs e)
        {
            switch (nextInvisIter)
            {
                case 0:
                    buttonAddMale.Enabled = false; //Grey add female
                    buttonAddFemale.Enabled = false; //Grey add female
                    buttonRemove.Enabled = false; //Grey Remove button
                    buttonPreference.Visible = true; //Make the preference button visible

                    arrMaleName = new ListViewItem[listViewMale.Items.Count];
                    listViewMale.Items.CopyTo(arrMaleName, 0);

                    arrFemaleName = new ListViewItem[listViewFemale.Items.Count];
                    listViewFemale.Items.CopyTo(arrFemaleName, 0);
                    //MessageBox.Show(arrMaleName[0].Text);

                    menPref = new int[halfCount, halfCount];
                    womenPref = new int[halfCount, halfCount];

                    //Filling out menPref and womenPref
                    for (int i = 0; i < halfCount; i++)
                    {
                        for (int j = 0; j < halfCount; j++)
                        {
                            menPref[i, j] = j;
                            womenPref[i, j] = j;
                        }
                    }
                    nextInvisIter = 1;
                    break;
                case 1:
                    int[,] womenPrefC = new int[halfCount, halfCount]; //To be able to access in constant time
                    for (int i = 0; i < halfCount; i++)
                    {
                        for (int j = 0; j < halfCount; j++)
                        {
                            womenPrefC[i, womenPref[i, j]] = j;
                        }
                    }
                    FormResult formResult = new FormResult(arrMaleName, arrFemaleName, menPref, womenPrefC);
                    formResult.Show();
                    break;
            }
              
        }

        private void buttonPreference_Click(object sender, EventArgs e)
        {

            //formPreference.ShowDialog();
            foreach (ListViewItem eachItem in listViewMale.SelectedItems)
            {
                FormPreference formPreference = new FormPreference();
                formPreference.updateForm(arrMaleName,arrFemaleName, menPref,womenPref,0, eachItem.Index);
                formPreference.Show();
                //MessageBox.Show(eachItem.Index.ToString());
            }

            foreach (ListViewItem eachItem in listViewFemale.SelectedItems)
            {
                FormPreference formPreference = new FormPreference();
                formPreference.updateForm(arrMaleName, arrFemaleName, menPref, womenPref,1, eachItem.Index);
                formPreference.Show();
            }


            //It clears the selection
            //listViewMale.SelectedItems.Clear();
            //listViewFemale.SelectedItems.Clear();


        }



    }
}
