using System;
using System.Collections;
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
    public partial class FormResult : Form
    {
        ListViewItem[] arrMaleName, arrFemaleName;
        int[,] menPref, womenPref;
        int[] engagedMen;
        int[] engagedWomen;

        int halfCount = FormMainInput.halfCount;

        public FormResult(ListViewItem[] arrMaleName, ListViewItem[] arrFemaleName, int[,] menPref, int[,] womenPref)
        {
            InitializeComponent();
            this.arrMaleName = arrMaleName;
            this.arrFemaleName = arrFemaleName;
            this.menPref = menPref;
            this.womenPref = womenPref;
            this.halfCount = arrMaleName.Length;

            stableMatch();

            string str = "";

            for (int i = 0; i < halfCount; i++)
            {
                str += arrMaleName[i].Text;
                str += " - ";
                str+= arrFemaleName[engagedMen[i]].Text + "\n";
            }

            labelResult.Text = str;
            


        }

        void stableMatch()
        {
            int n = halfCount; //How many men or women?

            Queue<int> menQueue = new Queue<int>();
            LinkedList<int>[] menList = new LinkedList<int>[n];


            for (int i = 0; i < n; i++)
            {
                menQueue.Enqueue(i);
                menList[i] = new LinkedList<int>();
                for (int j = 0; j < n; j++)
                {
                    menList[i].AddLast(menPref[i, j]);
                }
            }


            engagedMen = Enumerable.Repeat(-1, n).ToArray();
            engagedWomen = Enumerable.Repeat(-1, n).ToArray();
            int totalProposed = 0;
            int posTotalProposed = n * n;


            while (menQueue.Count != 0 && totalProposed != posTotalProposed)
            {
                int m = menQueue.Dequeue();
                int w = menList[m].First();
                menList[m].RemoveFirst();


                if (engagedWomen[w] == -1)
                {
                    totalProposed++;
                    engagedMen[m] = w;
                    engagedWomen[w] = m;
                }
                else if (womenPref[w, m] < womenPref[w, engagedWomen[w]])
                {
                    int oldGuy = engagedWomen[w];
                    menQueue.Enqueue(oldGuy);
                    engagedMen[oldGuy] = -1;

                    totalProposed++;
                    engagedMen[m] = w;
                    engagedWomen[w] = m;
                }
                else
                {
                    totalProposed++;
                    menQueue.Enqueue(m);
                }
            }
        }

        void printList(LinkedList<int>[] list)
        {
            string str = "Printing menList \n";
            for (int i = 0; i < halfCount; i++)
            {
                foreach (int j in list[i])
                {
                    str += j.ToString() + " ";
                }
                str += "\n";
            }

            MessageBox.Show(str);
        }

        void printQueue(Queue<int> Q)
        {
            string str = "Printing the Queue\n";
            for (int i = 0; i < Q.Count; i++)
            {
                str += Q.ElementAt(i) + " ";
            }
            str += "\n";
            MessageBox.Show(str);
        }
    }


}
