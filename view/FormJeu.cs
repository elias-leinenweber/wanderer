using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wanderer.model;
using Wanderer.view.Controls;

namespace Wanderer.view
{
    public partial class FormJeu : Form
    {
        bool gareCreated = true;
        int nombreMarks;
        int nombreRandonneurs;
        int tailleTerritoire;
        int nombreTour;
        int nombreUsine;
        int nombreRefuge;
        int nombreChemin;
        int nombreClub;
        int bonus = 0;


        const int limiteRandonneur = 100;
        const int limiteTerritoire = 200;

        public void updateNombreMarks(int nombreUsine, int nombreRefuge)
        {
            nombreMarks = nombreUsine * 5 + nombreRefuge * 5 + 10 + nombreMarks;
        }

        public void updateNombreRandonneurs(int nombreClub, int nombreChemins, int nombreRefuges)
        {
            nombreRandonneurs = nombreClub * 6 + nombreChemins * 2 + nombreRefuges * 3 - 10 * nombreUsine + bonus;
        }

        public void updateTailleTerritoire(int nombreClub, int nombreChemins, int nombreRefuges)
        {
            tailleTerritoire = nombreChemins * 5 + nombreRefuges * 10;
        }

        public void disable()
        {
            this.Enabled = false;
        }


        public void updateLabels()
        {
            if(nombreTour > 0)
            {
                updateNombreMarks(nombreUsine, nombreRefuge);
            }
            updateNombreRandonneurs(nombreClub, nombreChemin, nombreRefuge);
            updateTailleTerritoire(nombreClub, nombreChemin, nombreRefuge);

            lblArgent.Text = "Argent :" + nombreMarks;
            lblMarcheur.Text = "Marcheurs : " + nombreRandonneurs;
            lblTour.Text = "Nombre d'action : " + nombreTour++;
            if (MapView.SelectedTile != null && MapView.SelectedTile.model.HasChanged)
            {
                MapView.SelectedTile.Image = image();
                MapView.SelectedTile.model.HasChanged = false;
            }
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
            if (nombreMarks < 60) return;
            MapView.SelectedTile.model.Improvement = Improvement.Factory;
            nombreUsine++;
            nombreMarks -= 40;
            updateLabels();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if(nombreMarks >= 10 && gareCreated)
            {
                MapView.SelectedTile.model.Improvement = Improvement.TrainStation;
                gareCreated = false;
                nombreMarks -= 10;
                updateLabels();
            }
        }

        private void btnRefuge_Click(object sender, EventArgs e)
        {
            if (nombreRefuge % 5 == 0 && nombreRefuge != 0)
            {
                bonus += 5;
            }
            if (nombreMarks >= 30)
            {
                MapView.SelectedTile.model.Improvement = Improvement.Refuge;
                nombreRefuge++;
                nombreMarks -= 30;
                updateLabels();
            }
        }


        private void btnChemin_Click(object sender, EventArgs e)
        {
            if (nombreChemin % 5 == 0 && nombreRefuge != 0)
            {
                bonus += 2;
            }
            if (nombreMarks >= 10)
            {
                MapView.SelectedTile.model.Improvement = Improvement.Path;
                nombreChemin++;
                nombreMarks -= 10;
                updateLabels();
            }
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            if(nombreMarks >= 15)
            {
                MapView.SelectedTile.model.Improvement = Improvement.Club;
                nombreClub++;
                nombreMarks -= 10;
                updateLabels();
            }
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
            nombreMarks = 40;
            updateLabels();
        }

        private void FormJeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Image image()
        {
            switch (MapView.SelectedTile.model.Improvement)
            {
                case Improvement.Club:
                    return btnClub.Image;
                case Improvement.Factory:
                    return btnUsine.Image;
                case Improvement.Path:
                    return btnChemin.Image;
                case Improvement.Refuge:
                    return btnRefuge.Image;
                case Improvement.TrainStation:
                    return btnTrain.Image;
            }

            return null;
        }

    }
}
