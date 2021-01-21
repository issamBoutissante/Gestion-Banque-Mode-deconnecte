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
    public partial class Ajout_Client : Form
    {
        GereData gereData = new GereData();
        DataTable client;
        DataView clientView;
        public Ajout_Client()
        {
            InitializeComponent();
        }


        private void Ajout_Client_Load(object sender, EventArgs e)
        {
            client = gereData.GetTable("select * from client;", "client");
            ClientdataGridView.DataSource = client;
        }

        private void AjouterClient_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = client.NewRow();
                row[0] = NumClient.Text;
                row[1] = NomClient.Text;
                row[2] = PrenomClient.Text;
                client.Rows.Add(row);
                MessageBox.Show("L'ajout a ete effectue");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void EnregistrerClient_Click(object sender, EventArgs e)
        {
            gereData.UpdateAndClose("client",this);
        }
    }
}
