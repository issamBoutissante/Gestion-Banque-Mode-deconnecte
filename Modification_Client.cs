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
    public partial class Modification_Client : Form
    {
        GereData gereData = new GereData();
        DataTable client;
        DataView clientModifie;
        public Modification_Client()
        {
            InitializeComponent();
        }

        private void Modification_Client_Load(object sender, EventArgs e)
        {
            client= gereData.GetTable("select * from client", "client");
            ClientdataGridView.DataSource = client;

            NumClient.DataSource = client;
            NumClient.DisplayMember = "num_client";
            clientModifie = new DataView(client, "", "", DataViewRowState.ModifiedOriginal);
            clientModifieddataGridView.DataSource = clientModifie;
        }

        private void NumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = client.Rows[NumClient.SelectedIndex];
            NomClient.Text = row[1].ToString();
            PrenomClient.Text = row[2].ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            DataRow row = client.Rows[NumClient.SelectedIndex];
            row.BeginEdit();
            row["nom_client"] = NomClient.Text;
            row["prenom_client"] = PrenomClient.Text;
            row.EndEdit();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            if (clientModifie.Count > 0)
            {
                gereData.UpdateAndClose("client", this);
            }
            this.MdiParent.Close();
        }
    }
}
