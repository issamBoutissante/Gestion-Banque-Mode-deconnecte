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
    public partial class Suppression_Client : Form
    {
        GereData gereData = new GereData();
        DataTable client;
        DataView clientSupprime;
        public Suppression_Client()
        {
            InitializeComponent();
        }

        private void Suppression_Client_Load(object sender, EventArgs e)
        {
            try
            {
                client = gereData.GetTable("select * from client;", "client");
                ClientdataGridView.DataSource = client;
                NumClient.DataSource = client;
                NumClient.DisplayMember = "num_client";
                clientSupprime= new DataView(client, "", "", DataViewRowState.Deleted);
                clientSuppremedataGridView.DataSource = clientSupprime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            client.Rows[NumClient.SelectedIndex].Delete();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            if (clientSupprime.Count > 0)
            {
                gereData.UpdateAndClose("client", this);
            }
            this.MdiParent.Close();
        }
    }
}
