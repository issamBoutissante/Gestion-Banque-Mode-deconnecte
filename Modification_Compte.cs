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
    public partial class Modification_Compte : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataView compteView;
        public Modification_Compte()
        {
            InitializeComponent();
        }

        private void Modification_Compte_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte", "compte");
            ComptedataGridView.DataSource = compte;
            compteModifieddataGridView.DataSource = compteView;
        }

        private void ModifierCompte_Click(object sender, EventArgs e)
        {
           // compte.Rows[]   
        }
    }
}
