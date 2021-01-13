using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            form.Dock = DockStyle.Fill;
            this.Dock = DockStyle.Fill;
            form.MdiParent = this;
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
    }
}
