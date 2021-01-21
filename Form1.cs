using System;
using System.Windows.Forms;

namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.IsMdiContainer = true;
            this.AutoScroll = false;
        }
        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Navigation_Compte());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ajoutCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajout_Compte());
        }

        private void modificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Modification_Compte());
        }

        private void suppressionCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suppression_Compte());
        }

        private void navigationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openForm(new Navigation_Client());
        }

        private void ajoutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajout_Client());
        }

        private void modificationClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Modification_Client());
        }

        private void suppressionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suppression_Client());
        }

        private void ajoutMouvementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajout_Mouvement());
        }

        private void suppressionMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suppression_Mouvement());
        }

        private void ajoutVirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajout_Virement());
        }

        private void suppressionVirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suppression_Virement());
        }
    }
}
