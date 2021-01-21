using System;
using System.Data;
using System.Windows.Forms;

namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    public partial class Ajout_Mouvement : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataTable mouvement;
        public Ajout_Mouvement()
        {
            InitializeComponent();
        }

        private void Ajout_Mouvement_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte", "compte");
            mouvement = gereData.GetTable("select * from mouvement", "mouvement");
            MouvementsdataGridView.DataSource = mouvement;
            comptesdataGridView.DataSource = compte;
            NumCompte.DataSource = compte;
            NumCompte.DisplayMember = "num_compte";
        }

        private void AjouterClient_Click(object sender, EventArgs e)
        {

            DataRow compteRow = compte.Rows[NumCompte.SelectedIndex];
            decimal solde = Convert.ToDecimal(compteRow["solde"]);
            if (TypeMouvement.SelectedItem.ToString() == "retrait")
            {
                if (solde > Convert.ToInt32(Montant.Text))
                {
                    compteRow[2] = solde - Convert.ToInt32(Montant.Text);

                }
                else
                {
                    MessageBox.Show("tu n'as pas assez d'argent");
                    return;
                }
            }
            else
            {
                compteRow[2] = solde + Convert.ToInt32(Montant.Text);
            }
            DataRow mRow = mouvement.NewRow();
            mRow[1] = NumCompte.Text;
            mRow[2] = Montant.Text;
            mRow[3] = TypeMouvement.Text;
            mRow[4] = DateTime.Now;
            mouvement.Rows.Add(mRow);
        }

        private void NumCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow compteRow = compte.Rows[NumCompte.SelectedIndex];
            Solde.Text = compteRow["solde"].ToString();
        }

        private void EnregistrerClient_Click(object sender, EventArgs e)
        {
            gereData.Update("compte");
            gereData.UpdateAndClose("mouvement", this);
        }
    }
}
