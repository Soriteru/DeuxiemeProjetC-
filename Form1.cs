using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeuxiemeProjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables Globales
        string[] tabImmat = new string[5000];
        string[] tabCarburant = new string[5000];
        int[] tabAnnee = new int[100];
        int[] tabNbCh = new int[100];
        int NbVoit ;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            NbVoit = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnreg_Click(object sender, EventArgs e)
        {
            tabImmat[NbVoit] = TextBoxImmat.Text;
            if (radioEssence.Checked) {
                tabCarburant[NbVoit] = "Essence";
            }
            else
            {
                tabCarburant[NbVoit] = "Diesel";
            }
            tabAnnee[NbVoit] = Convert.ToInt16(TextBoxAnnee.Text);
            tabNbCh[NbVoit] = Convert.ToInt16(TextBoxCheveaux.Text);
            NbVoit++;
        }

        private void buttonAffich_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NbVoit;i++)
                if (tabAnnee[i] < 2018)
                     listPrime.Items.Add(tabImmat[i]);
        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NbVoit; i++)
            {
                if (tabImmat[i] == TextBoxVoit.Text)
                {
                    if (tabCarburant[i] == "Essence" && tabAnnee[i] >= 2013)
                    {
                        labelNumero.Text = "1";
                        labelCouleur.Text = "Blanc";
                    }
                    if (tabCarburant[i] == "Essence" && tabAnnee[i] < 2013)
                    {
                        labelNumero.Text = "2";
                        labelCouleur.Text = "Vert";
                    }

                    if (tabCarburant[i] == "Diesel" && tabAnnee[i] >= 2013)
                    {
                        labelNumero.Text = "3";
                        labelCouleur.Text = "Jaune";
                    }
                    if (tabCarburant[i] == "Diesel" && tabAnnee[i] < 2013)
                    {
                        labelNumero.Text = "4";
                        labelCouleur.Text = "Orange";
                    }
                }
            }
        }
    }
}
