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
    public partial class Navigation_Client : Form
    {
        GereData gereData = new GereData();
        DataTable compte;
        DataTable client;
        DataView compteView;
        public Navigation_Client()
        {
            InitializeComponent();
        }
        private void Navigation_Client_Load(object sender, EventArgs e)
        {
            compte = gereData.GetTable("select * from compte;", "compte");
            client = gereData.GetTable("select num_client,(nom_client+' '+prenom_client) as nom from client","client");
            NumClient.DataSource = client;
            NumClient.DisplayMember = "num_client";
        }

        private void NumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = client.Rows[NumClient.SelectedIndex];
            string selectedClient = row["num_client"].ToString();
            Nom.Text = row["nom"].ToString();
            compteView = new DataView(compte, "num_client = "+selectedClient, "", DataViewRowState.OriginalRows);
            ComptedataGridView.DataSource = compteView;
            
        }
    }
}
