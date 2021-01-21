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
    public partial class Ajout_Virement : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataTable virement;

        public Ajout_Virement()
        {
            InitializeComponent();
        }
        private void Ajout_Virement_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte", "compte");
            virement = gereData.GetTable("select * from virement", "virement");
            VirementdataGridView.DataSource = virement;
            ComptedataGridView.DataSource = compte;
            Numero_Debiteur.DataSource = new DataView(compte);
            Numero_Debiteur.DisplayMember = "num_compte";
            NumeroCrediteur.DataSource = new DataView(compte);
            NumeroCrediteur.DisplayMember = "num_compte";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            DataRow crediteurRow = compte.Rows[NumeroCrediteur.SelectedIndex];
            DataRow debiteurRow = compte.Rows[Numero_Debiteur.SelectedIndex];
            decimal soldDebiteur = Convert.ToDecimal(debiteurRow["solde"]);
            decimal soldCrediteur = Convert.ToDecimal(crediteurRow["solde"]);
            
            if (soldDebiteur > Convert.ToDecimal(Montant.Text))
            {
                crediteurRow.BeginEdit();
                debiteurRow["solde"] = soldDebiteur - Convert.ToDecimal(Montant.Text);
                crediteurRow.EndEdit();
                debiteurRow.BeginEdit();
                debiteurRow["solde"] = soldCrediteur + Convert.ToDecimal(Montant.Text);
                debiteurRow.EndEdit();
            }
            else
            {
                MessageBox.Show("le debiteur n'a pas assez d'argent");
                return;
            }
            DataRow vRow = virement.NewRow();
            vRow[1] = Numero_Debiteur.Text;
            vRow[2] = NumeroCrediteur.Text;
            vRow[3] = Montant.Text;
            vRow[4] = DateTime.Now;
            virement.Rows.Add(vRow);
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            gereData.Update("compte");
            gereData.UpdateAndClose("virement", this);
        }
    }
}
