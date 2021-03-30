using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wanderer.view
{
    public partial class FormAide : Form
    {
        public FormAide()
        {
            InitializeComponent();
            lblTitre.Text = "Contexte historique";
            lblTexte.Text = "Nous sommes en 1875, toute l’Allemagne connaît une grande période d’industrialisation. De ce fait, la démographie du pays se voit exploser, les villes se remplissent et" +
                "rapidement beaucoup souhaitent s’échapper de la ville et se ressourcer à la nature.\n\n" +
                "Quelle autre bonne manière de le faire que de s’essayer à la randonnée!\n\n" +
                "Ainsi, c’est votre rôle, en tant que ministre allemand, de développer au plus rapidement votre territoire dans ce domaine pour battre les autres régions dans la course à l’aménagement" +
                " de votre région, pour que chacun de ces habitants puisse s’épanouir à son gré sur les chemins de randonnée.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblTitre.Text = b.Text;
            lblTexte.Text = "En Début de partie vous aurez le choix de l'endroit où vous voulez construire votre gare. Celle ci doit etre placée en bord de terrain.\n\n\n" +
                "Afin d'augmenter le nombre de marcheurs sur votre terrain vous devrez placer :\n" +
                "   - des usines : pour fabriquer du matériel de randonnée, et donc gagner de l'argent\n" +
                "   - des chemins : pour augmenter la superficie de votre territoire de randonnée\n" +
                "   - des refuges : pour attirer plus de marcheur \n\n" +
                "Vous aurez également la possibilité de financer des clubs de randonnées et d'améliorer vos chemins ferroviaires afin d'attirer plus de randonneurs.\n\n\n" +
                "Pour placer les différents éléments, cliquez sur l'item que vous voulez placer puis cliquez sur l'emplacement où vous voulez le placer.";
        }

        private void btnContexte_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblTitre.Text = b.Text;
            lblTexte.Text = "Nous sommes en 1875, toute l’Allemagne connaît une grande période d’industrialisation. De ce fait, la démographie du pays se voit exploser, les villes se remplissent et" +
                "rapidement beaucoup souhaitent s’échapper de la ville et se ressourcer à la nature.\n\n"+ 
                "Quelle autre bonne manière de le faire que de s’essayer à la randonnée!\n\n"+
                "Ainsi, c’est votre rôle, en tant que ministre allemand, de développer au plus rapidement votre territoire dans ce domaine pour battre les autres régions dans la course à l’aménagement" +
                " de votre région, pour que chacun de ces habitants puisse s’épanouir à son gré sur les chemins de randonnée.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblTitre.Text = b.Text;

        }

        private void btnGagner_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblTitre.Text = b.Text;
            lblTexte.Text = "Vous devrez atteindre un nombre de marcheurs sur votre territoire s'élévant à X marcheurs.\n\n"+
                "Pour cela aménagez votre territoire ! \n" +
                "(Rendez-vous dans la rubrique Construction)";
        }

        private void btnContexte_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
