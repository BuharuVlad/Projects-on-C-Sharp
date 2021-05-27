using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    public partial class InterfaceTransport : Form
    {
        private const string ConnectionTransport = "Data Source=Transport.db";
        public InterfaceTransport()
        {
            InitializeComponent();
        }

        private void BtnAddTransport_Click(object sender, EventArgs e)
        {
            AddTransport addTransport = new AddTransport();
            addTransport.Show();
        }

        private void BtnDeleteTransport_Click(object sender, EventArgs e)
        {
            string query = "delete from Transport where id ='" + txtIdTransport + "' ;";
            InsertUpdateDeleteTransport(query);
            DisplayTransport();

        }

        private void BtnUpdateTransport_Click(object sender, EventArgs e)
        {
            string query = "update Transport set ProductTransport = '" + txtProductTransport + "', " +
                "QuantityTransport = '" + txtQuantityTransport + "' where id = '" + txtIdTransport + "' ;";
            InsertUpdateDeleteTransport(query);
            DisplayTransport();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayTransport();
        }

        private void DtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdTransport.Text = dtGridList.SelectedRows[0].Cells[0].Value.ToString();
                txtProductTransport.Text = dtGridList.SelectedRows[0].Cells[1].Value.ToString();
                txtQuantityTransport.Text = dtGridList.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Click only in the left side of the window, next to id", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DisplayTransport()
        {
            string query = "Select * FROM Transport";
            InsertUpdateDeleteTransport(query);

        }//DisplayTransport

        private void InsertUpdateDeleteTransport(string Query)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionTransport);
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = connection,
                CommandText = Query
            };
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                connection.Close();
                dtGridList.DataSource = dt;
            }
        } // InsertUpdateDeleteTransport
    }
}
