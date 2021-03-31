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

namespace Wanderer.view
{
    public partial class FormFin : Form
    {
        public FormFin(Player currentPlayer)
        {
            InitializeComponent();
            label1.Text = currentPlayer.Color + " a gagné !";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
