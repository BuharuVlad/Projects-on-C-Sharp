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
    public partial class loginFrom : Form
    {
        public loginFrom()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //close the login window
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click on the textBox Username
            //the text will be delete
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click on the textBox Password
            //the text will be delete
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*'; //when you write the text will be real in back and you will se only "*"
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "data source = libraryManagement.db";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var  queryString = "SELECT * from loginTable where username  = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                var commnad = new SQLiteCommand(queryString, connection);
                //"SELECT * from loginTable where username  = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                SQLiteDataAdapter yes = new SQLiteDataAdapter(commnad);
                DataSet ds = new DataSet();
                yes.Fill(ds);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Dashbord dsa = new Dashbord();
                    dsa.Show();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void loginFrom_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
