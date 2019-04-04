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
    public partial class frmDepart : Form
    {
        public frmDepart()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Bravo tu as trouvé tous les indices de CTS'cape tu peux maintenant rejoindre ton ami !");
           
        }
    }
}
