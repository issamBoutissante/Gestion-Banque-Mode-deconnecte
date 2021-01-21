using System;
using System.Data;
using System.Windows.Forms;

namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    public partial class Suppression_Virement : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataTable virement;
        public Suppression_Virement()
        {
            InitializeComponent();
        }

        private void Suppression_Virement_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte", "compte");
            virement = gereData.GetTable("select * from virement", "virement");
            VirementdataGridView.DataSource = virement;
            ComptedataGridView.DataSource = compte;
            NumVirement.DataSource = virement;
            NumVirement.DisplayMember = "num_virement";
            NumVirement.ValueMember = "num_virement";
            
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DataView vrmView = new DataView(virement, "num_virement="+NumVirement.SelectedValue, "", DataViewRowState.CurrentRows);
            DataView dbtView = new DataView(compte, "num_compte=" + vrmView[0]["num_debiteur"],"", DataViewRowState.CurrentRows);
            DataView crtView = new DataView(compte, "num_compte=" + vrmView[0]["num_crediteur"], "", DataViewRowState.CurrentRows);

            decimal soldDebiteur = Convert.ToDecimal(dbtView[0]["solde"]);
            decimal soldCrediteur = Convert.ToDecimal(crtView[0]["solde"]);
            if (soldCrediteur >= Convert.ToDecimal(vrmView[0]["montant_vr"]))
            {
                crtView[0]["solde"] = soldDebiteur - Convert.ToDecimal(soldCrediteur);
                dbtView[0]["solde"] = soldCrediteur + Convert.ToDecimal(soldDebiteur);
            }
            else
            {
                MessageBox.Show("le debiteur n'a pas assez d'argent");
                return;
            }
            virement.Rows[NumVirement.SelectedIndex].Delete();
            VirementdataGridView.Refresh();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            gereData.Update("compte");
            gereData.UpdateAndClose("virement", this);
        }
    }
}
