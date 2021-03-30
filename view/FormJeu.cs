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
        int tailleTerritoire;
        int nombreTour;
        int bonusCh = 0;//bonus Chemin
        int bonusCl = 0; //bonus Club
        int marks = 40;
        int randonneurs = 0;

        const int limiteRandonneur = 100;
        const int limiteTerritoire = 200;
        
        int[] tbCouts = new int[] { 30, 10, 15, 10, 60 }; //Refuge,Chemin,Club,Train,Usine
        int[] tbRandonneur = new[] { 3, 2, 6, 0, -10 };
        int[] tbConstruct = new int[]{0, 0, 0, 0, 0}; //Refuge,Chemin,Club,Train,Usine

        /**
         * Action updateButtons()
         *   - vérifie si fond suffisant pour les éléments
         *      - si oui, enable + fond transparent
         *      - si non, disable + fond gris
         *   - premier tour grise tout sauf btn Train
         *  */
        public void updateButtons()
        {
            foreach (Object o in Controls)
            {
                if (o is Button b && b.Tag != null)
                {
                    if (tbCouts[Convert.ToInt32(b.Tag)] > marks)
                    {
                        b.Enabled = false;
                        b.BackColor = Color.Gray;
                    }
                    else
                    {
                        b.Enabled = true;
                        b.BackColor = Color.Transparent;
                    }

                    //Premier tour
                    if(nombreTour==1)
                    {
                        b.Enabled = false;
                        b.BackColor = Color.Gray;
                        btnTrain.Enabled = true;
                        btnTrain.BackColor = Color.Transparent;
                    }
                }                
            }
            //Désactive train
            if (nombreTour > 1)
            {
                btnTrain.BackColor = Color.Gray;
                btnTrain.Enabled = false;
            }
        }

        /**
         * Action btnClick
         *  - vérifie si fond suffisant
         *  - mise en place de l'image
         *  - calculs des bonus des chemins et club
         *  - lance update()
         **/

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Int32 i = Convert.ToInt32(b.Tag);
            int cout = tbCouts[i];

            //Calcul des marks et randonneurs, ajout d'image sur la map
            if (marks >= cout && MapView.SelectedTile.model.Improvement == 0)
            {
                MapView.SelectedTile.model.Improvement = (Improvement) i;
                if (!MapView.SelectedTile.model.HasChanged) return;

                tbConstruct[i]++;

                if (tbConstruct[1] % 5 ==0 && tbConstruct[1]!=0)
                {
                    bonusCh += 1;
                }
                if (tbConstruct[2] % 5 == 0 && tbConstruct[2] != 0)
                {
                    bonusCl += 2;
                }
                marks -= cout-10;
                randonneurs += tbRandonneur[i]+bonusCh+bonusCl;
                if (randonneurs < 0) 
                { 
                    randonneurs = 0; 
                }
                update();
            }
        }

        /**
         * Mise à jour des Lables et du MapView
        **/
        private void update()
        {
            lblArgent.Text = "Argent :" + marks;
            lblMarcheur.Text = "Marcheurs : " + randonneurs;
            lblTour.Text = "Nombre d'action : " + nombreTour++;
            if (MapView.SelectedTile != null && MapView.SelectedTile.model.HasChanged)
            {
                MapView.SelectedTile.Image = image();
                MapView.SelectedTile.model.HasChanged = false;
            }
            updateButtons();
        }


        

        public void updateTailleTerritoire(int nombreClub, int nombreChemins, int nombreRefuges)
        {
            tailleTerritoire = nombreChemins * 5 + nombreRefuges * 10;
        }

        public void disable()
        {
            this.Enabled = false;
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

        private void FormJeu_Load(object sender, EventArgs e)
        {
            mapView1.Model = new Map(20, 10);
            update();
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

        private void btnUsine_Click(object sender, EventArgs e)
        {
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
        }

        private void btnRefuge_Click(object sender, EventArgs e)
        {
        }


        private void btnChemin_Click(object sender, EventArgs e)
        {
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
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

        

    }
}
