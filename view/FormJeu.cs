using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wanderer.view.Controls;

namespace Wanderer.view
{
    public partial class FormJeu : Form
    {

        int nombreMarks;
        int nombreRandonneurs;
        int tailleTerritoire;
        int nombreTour;
        int nombreUsine;
        int nombreRefuge;
        int nombreChemin;
        int nombreClub;

        public void updateNombreMarks(int nombreUsine, int nombreRefuge)
        {
            nombreMarks = nombreUsine * 10 + nombreRefuge * 5 + 10;
        }

        public void updateNombreRandonneurs(int nombreClub, int nombreChemins, int nombreRefuges)
        {
            nombreRandonneurs = nombreClub * 6 + nombreChemins * 4 + nombreRefuges * 3;
        }

        public void updateTailleTerritoire(int nombreClub, int nombreChemins, int nombreRefuges)
        {
            tailleTerritoire = nombreChemins * 5 + nombreRefuges * 10;
        }


        public void updateLabels()
        {
            updateNombreMarks(nombreUsine, nombreRefuge);
            updateNombreRandonneurs(nombreClub, nombreChemin, nombreRefuge);
            updateTailleTerritoire(nombreClub, nombreChemin, nombreRefuge);

            lblArgent.Text = "Argent :" + nombreMarks;
            lblMarcheur.Text = "Marcheurs : " + nombreRandonneurs;
            lblTour.Text = "Nombre d'action : " + nombreTour;
        }



        public FormJeu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAide formAide = new FormAide();
            formAide.Show();
        }

        private void btnUsine_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefuge_Click(object sender, EventArgs e)
        {
            MapView.SelectedTile.Image = btnRefuge.Image;
        }

        private void mapView1_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mapView1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            mapView1.Model = new Map(20,10);
        }

        private void FormJeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
