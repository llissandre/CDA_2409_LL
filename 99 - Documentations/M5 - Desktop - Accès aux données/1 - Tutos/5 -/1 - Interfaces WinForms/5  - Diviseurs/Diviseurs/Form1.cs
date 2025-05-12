using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diviseurs
{
    /// <summary>
    /// 
    /// Cette application permet de simplifier une fraction
    /// 
    /// Pour cela on utilisera l'opérateur 'modulo' (%) qui retourne le reste de la division entière
    /// 
    /// Si Numérateur % A == 0 et Dénominateur % A == 0 alors A est un diviseur commun et on peut simplifier
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            // On récupère le numérateur et le dénominateur
            long num = 0;
            long den = 0;

            // On teste si le numérateur est correct
            if (!long.TryParse(txtNumerateur.Text, out num))
            {
                MessageBox.Show("Le numérateur doit être un nombre entier.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumerateur.SelectAll();
                txtNumerateur.Focus();
                return;
            }

            // On teste si le dénominateur est correct
            if (!long.TryParse(txtDenominateur.Text, out den))
            {
                MessageBox.Show("Le dénominateur doit être un nombre entier.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDenominateur.SelectAll();
                txtDenominateur.Focus();
                return;
            }

            // On teste si le dénominateur est <> 0
            if (den == 0)
            {
                MessageBox.Show("Le dénominateur doit être un nombre entier positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDenominateur.SelectAll();
                txtDenominateur.Focus();
                return;
            }

            // On fixe la limite de recherche des diviseurs au nombre le plus petit
            long limite = 0;
            if (num < den)
            {
                limite = num;
            }
            else
            {
                limite = den;
            }

            // On peut aussi utiliser la condition ternaire
            limite = (num < den) ? num : den;

            // On peut également utiliser la fonction Min de la classe Math
            limite = Math.Min(num, den);

            // On déclare une variable qui nous servira à stocker les diviseurs
            string diviseurs = "Diviseurs : ";

            // On teste tous les diviseurs compris entre 2 et la limite
            for (int i = 2; i <= limite; i++)
            {
                // Si le diviseur est commun au deux nombres
                if (num % i == 0 && den % i == 0)
                {
                    // On simplifie la division 
                    num = num / i;
                    den = den / i;

                    // Stocke les diviseurs
                    diviseurs += i + " - ";

                    // On décrémente i pour pouvoir re-tester le même diviseur
                    i--;
                }
            }

            // On affiche le résultat
            lblNumerateur.Text = num.ToString();
            lblDenominateur.Text = den.ToString();

            // On affiche les diviseurs dans les tooltips
            diviseurs = diviseurs.Substring(0, diviseurs.Length - 3);
            toolTip1.SetToolTip(lblNumerateur, diviseurs);
            toolTip1.SetToolTip(lblDenominateur, diviseurs);
        }
    }
}
