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
    public partial class FormJeu : Form
    {
        public FormJeu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAide formAide = new FormAide();
            formAide.Show();
        }
    }
}
