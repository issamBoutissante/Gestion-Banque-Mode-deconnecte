using System;
using System.Data;
using System.Windows.Forms;


namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    public partial class Ajout_Compte : Form
    {
        GereData gereData = new GereData();
        DataTable compte;        
        public Ajout_Compte()
        {
            InitializeComponent();
        }

        private void Navigation_Comptes_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte;", "compte");
            ComptedataGridView.DataSource = compte;
            DataTable client = gereData.GetTable("select * from client;", "client");
            NumClient.DataSource = client;
            NumClient.ValueMember = "num_client";
        }
        

        private void AjouterCompte_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = compte.NewRow();
                row[0] = NumCompte.Text;
                row[1] = NumClient.Text;
                row[2] = Solde.Text;
                row[3] = TypeCompte.SelectedItem;
                compte.Rows.Add(row);
                MessageBox.Show("L'ajout a ete effectue");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : "+ex.Message);
            }
        }
        private void EnregistrerCompte_Click(object sender, EventArgs e)
        {
            gereData.UpdateAndClose("compte",this);
        }
    }
}
