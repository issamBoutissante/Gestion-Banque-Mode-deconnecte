using System;
using System.Data;
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
            DataTable client = gereData.GetTable("select * from client;", "client");

            NumCompte.DataSource = compte;
            NumCompte.DisplayMember = "num_compte";
            NumClient.DataSource = client;
            NumClient.DisplayMember = "num_client";
            compteView = new DataView(compte, "", "", DataViewRowState.ModifiedOriginal);
            compteModifieddataGridView.DataSource = compteView;
        }

        private void ModifierCompte_Click(object sender, EventArgs e)
        {
            DataRow row =compte.Rows[NumCompte.SelectedIndex];
            row.BeginEdit();
            row["num_client"] = NumClient.Text;
            row["typeC"] = TypeCompte.SelectedItem;
            row.EndEdit();
        }

        private void NumCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = compte.Rows[NumCompte.SelectedIndex];
            NumClient.Text = row[1].ToString();
            Solde.Text = row[2].ToString();
            TypeCompte.Text=row[3].ToString();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            if (compteView.Count > 0)
            {
                gereData.UpdateAndClose("compte", this);
            }
            this.MdiParent.Close();
        }
    }
}
