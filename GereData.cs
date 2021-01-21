
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    class GereData
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        static DataSet dataSet = new DataSet();
        Dictionary<string, SqlDataAdapter> adapters=new Dictionary<string, SqlDataAdapter>();
        internal DataTable GetTable(string query,string TableName)
        {
            //if the adapter already existes we just return it
            if (adapters.ContainsKey(TableName)) return dataSet.Tables[TableName];
            //if it's not exist then we insert one and give it the name of (TableName)
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataSet, TableName);
                adapters.Add(TableName, adapter);
            }catch(Exception e)
            {
                MessageBox.Show("Error : "+e.Message);
            }            
            return dataSet.Tables[TableName];
        }
        internal void UpdateAndClose(string TableName,Form form)
        {
            DialogResult result = MessageBox.Show("voullez vous sauvgarder les changement ?", "sauvgarder", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var adapter = adapters[TableName];
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet.Tables[TableName]);
                }catch(Exception e)
                {
                    MessageBox.Show("Error : "+e.Message);
                }
            }
            form.MdiParent.Close();
        }
        internal void Update(string TableName)
        {
                try
                {
                    var adapter = adapters[TableName];
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet.Tables[TableName]);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error : " + e.Message);
                }
        }

    }
}