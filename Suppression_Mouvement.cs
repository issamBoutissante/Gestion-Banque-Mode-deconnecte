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
    public partial class Suppression_Mouvement : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataTable mouvement;
        DataView mouvementSuppreme;
        public Suppression_Mouvement()
        {
            InitializeComponent();
        }

        private void Suppression_Mouvement_Load(object sender, EventArgs e)
        {
            try
            {
                compte = gereData.GetTable("select * from compte;", "compte");
                ComptedataGridView.DataSource = compte;
                mouvement = gereData.GetTable("select * from mouvement;", "mouvement");
                NumMouvement.DataSource = mouvement;
                NumMouvement.DisplayMember = "num_mouvement";
                mouvementDataGridView.DataSource = mouvement;
                mouvementSuppreme = new DataView(mouvement, "", "", DataViewRowState.Deleted);
                MouvementSupprimedataGridView.DataSource = mouvementSuppreme;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void NumMouvement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n=mouvement.Rows[NumMouvement.SelectedIndex]["num_compte"].ToString();
            DataView c = new DataView(compte, "num_compte = " + n, "", DataViewRowState.OriginalRows);
            Solde.Text = c[0][2].ToString();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            mouvement.Rows[NumMouvement.SelectedIndex].Delete();
            MouvementSupprimedataGridView.Refresh();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            gereData.Update("compte");
            gereData.UpdateAndClose("mouvement", this);
        }
    }
}
