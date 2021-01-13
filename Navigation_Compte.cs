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
    public partial class Navigation_Compte : Form
    {
        GereData gereData = new GereData();
        DataRow row;
        DataTable compte;
        int CurrentRowIndex=0;
        public Navigation_Compte()
        {
            InitializeComponent();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            CurrentRowIndex = 0;
            Afficher();
        }
        void Afficher()
        {
            row = compte.Rows[CurrentRowIndex];
            NumCompte.Text = row["num_compte"].ToString();
            Nom.Text = row["nom_client"].ToString();
            Prenom.Text = row["prenom_client"].ToString();
            Solde.Text = row["solde"].ToString();
            TypeCompte.Text = row["TypeC"].ToString();

        }
        private void Navigation_Compte_Load(object sender, EventArgs e)
        {
            compte=gereData.GetTable("select num_compte,nom_client,prenom_client,solde,typeC" +
                " from Compte join client on compte.num_client=client.num_client"
                ,"Compte");
            NombreComptes.Text = compte.Rows.Count.ToString();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            if (CurrentRowIndex == compte.Rows.Count-1) return;
            CurrentRowIndex++;
            Afficher();

        }

        private void Precedent_Click(object sender, EventArgs e)
        {
            if (CurrentRowIndex == 0) return;
            CurrentRowIndex--;
            Afficher();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            CurrentRowIndex = compte.Rows.Count - 1;
            Afficher();
        }
    }
}
