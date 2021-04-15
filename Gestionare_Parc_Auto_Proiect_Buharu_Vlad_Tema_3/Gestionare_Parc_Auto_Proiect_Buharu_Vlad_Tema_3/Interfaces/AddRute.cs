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
    public partial class AddRute : Form
    {
        private List<Rute> listRute = new List<Rute>();
        private const string ConnectiongString = "Data Source = Rute.db";
        public AddRute()
        {
            InitializeComponent();
        }

        private void btnSaveRute_Click(object sender, EventArgs e)
        {
            if (txtNameRute.Text != "" && txtFromRute.Text != ""
                 && txtToRute.Text != "" && txtNameRute.Text != " " && txtFromRute.Text != " "
                 && txtToRute.Text != " ")
            {
                Rute rute = new Rute(txtNameRute.Text, txtFromRute.Text,
                    txtToRute.Text);
                AddRuteSQLite(rute);
            }
            else
            {
                MessageBox.Show("Please write all the date about the driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddRuteSQLite(Rute rute)
        {
            var query = "insert into Rute(NameRute, FromRute, ToRute)" +
                "values (@NameRute, @FromRute, @ToRute);" +
                              "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectiongString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                var NameRute = new SQLiteParameter("@NameRute");
                NameRute.Value = rute.NameRute;
                var FromRute = new SQLiteParameter("@FromRute");
                FromRute.Value = rute.FromRute;
                var ToRute = new SQLiteParameter("@ToRute");
                ToRute.Value = rute.ToRute;

                command.Parameters.Add(NameRute);
                command.Parameters.Add(FromRute);
                command.Parameters.Add(ToRute);

                rute.id = (long)command.ExecuteScalar();

                var countStart = listRute.Count;
                listRute.Add(rute);
                var countEnd = listRute.Count;
                if (countStart < countEnd)
                {
                    MessageBox.Show("You add a new rute", "Succes Add", MessageBoxButtons.OK);
                    if (MessageBoxButtons.OK == 0)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
