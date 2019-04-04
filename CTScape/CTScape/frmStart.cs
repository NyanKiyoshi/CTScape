using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTScape
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJeu jeu = new frmJeu();
            jeu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnTutoriel_Click(object sender, EventArgs e)
        {
            frmtutoriel tuto = new frmtutoriel();
            tuto.ShowDialog();

        }

        private void btnTutoriel_MouseHover(object sender, EventArgs e)
        {
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
