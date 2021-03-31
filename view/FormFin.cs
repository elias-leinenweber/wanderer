using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wanderer.controller;
using Wanderer.model;
using Wanderer.view.Controls;

namespace Wanderer.view
{
    public partial class FormFin : Form
    {
        public FormFin(Player currentPlayer, int nombreTour)
        {
            InitializeComponent();
            if (currentPlayer.Color == Color.Brown)
            {
                label1.Text = "Le joueur Rouge a gagné !";
                label1.BackColor = currentPlayer.Color;
            }
            else
            {
                label1.Text = "Le joueur Bleu a gagné !";
                label1.BackColor = currentPlayer.Color;
            }

            lblTour.Text = lblTour.Text + nombreTour;
            afficheResultat(currentPlayer);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void afficheResultat(Player p)
        {
            lblWinner.Text = "Marcheurs : " + p.randonneurs +
                "\n\nMarks : " + p.marks;
            flowLayoutPanel1.BackColor = p.Color;


            Game.Instance.currentPlayerIndex = (Game.Instance.currentPlayerIndex + 1) % Game.Instance.Players.Count;
            Player p2= Game.Instance.Players[Game.Instance.currentPlayerIndex];
            lblLooser.Text = "Marcheurs : " + p2.randonneurs +
                "\n\nMarks : " + p2.marks;
            flowLayoutPanel2.BackColor = p2.Color;
        }
    }
}
