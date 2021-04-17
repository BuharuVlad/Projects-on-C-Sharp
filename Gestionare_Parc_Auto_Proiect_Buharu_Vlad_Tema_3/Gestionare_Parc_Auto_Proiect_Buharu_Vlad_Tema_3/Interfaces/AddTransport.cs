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

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    public partial class AddTransport : Form
    {
        private readonly List<Transport> listTransport = new List<Transport>();
        private const string ConnectiongString = "Data Source = Transport.db";
        public AddTransport()
        {
            InitializeComponent();
        }

        private void BtnSaveTransport_Click(object sender, EventArgs e)
        {
            if (txtProductTransport.Text != "" && txtQuantityTransport.Text != ""
                && txtProductTransport.Text != " " && txtQuantityTransport.Text != " ")
            {                
                Transport transport = new Transport(txtProductTransport.Text, Int32.Parse(txtQuantityTransport.Text));
                AddTransportSQLite(transport);
            }
            else
            {
                MessageBox.Show("Please write all the date about the driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelTransport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure? Data will be delete!", "Unsaved data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.Close();
        }
        private void AddTransportSQLite(Transport transport)
        {
            var query = "insert into Transport(ProductTransport, QuantityTransport)" +
                "values (@ProductTransport, @QuantityTransport);" +
                              "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectiongString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                var ProductTransport = new SQLiteParameter("@ProductTransport")
                {
                    Value = transport.ProductTransport
                };
                var QuantityTransport = new SQLiteParameter("@QuantityTransport")
                {
                    Value = transport.QuantityTransport
                };

                command.Parameters.Add(ProductTransport);
                command.Parameters.Add(QuantityTransport);

                transport.Id = (long)command.ExecuteScalar();

                var countStart = listTransport.Count;
                listTransport.Add(transport);
                var countEnd = listTransport.Count;
                if (countStart < countEnd)
                {
                    MessageBox.Show("You add a new transport", "Succes Add", MessageBoxButtons.OK);
                    if (MessageBoxButtons.OK == 0)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
