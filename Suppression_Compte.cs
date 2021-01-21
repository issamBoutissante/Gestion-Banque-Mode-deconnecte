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
    public partial class Suppression_Compte : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataView compteSuppreme;
        public Suppression_Compte()
        {
            InitializeComponent();
        }

        private void Suppression_Compte_Load(object sender, EventArgs e)
        {
            try
            {
                compte = gereData.GetTable("select * from compte;", "compte");
                ComptedataGridView.DataSource = compte;
                NumCompte.DataSource = compte;
                NumCompte.DisplayMember = "num_compte";
                compteSuppreme = new DataView(compte, "", "", DataViewRowState.Deleted);
                compteSupprimedataGridView.DataSource = compteSuppreme;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void SupprimerCompte_Click(object sender, EventArgs e)
        {
            compte.Rows[NumCompte.SelectedIndex].Delete();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            if (compteSuppreme.Count > 0)
            {
                gereData.UpdateAndClose("compte", this);
            }
            this.MdiParent.Close();
        }

    }
}
