using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    public partial class loginFrom : Form
    {
        public loginFrom()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //close the login window
        }
        private void TxtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click on the textBox Username
            //the text will be delete
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //when you click on the textBox Password
            //the text will be delete
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*'; //when you write the text will be real in back and you will se only "*"
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "data source = libraryManagement.db";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var  queryString = "SELECT * from loginTable where Username  = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
                var commnad = new SQLiteCommand(queryString, connection);
                //"SELECT * from loginTable where username  = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                SQLiteDataAdapter yes = new SQLiteDataAdapter(commnad);
                DataSet ds = new DataSet();
                yes.Fill(ds);                

                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        MessageBox.Show(txtUsername.Text, @"Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashbord dashbord = new Dashbord();
                        dashbord.Show();
                    }
                }
                else
                {
                    MessageBox.Show(@"Wrong UserName or Password", @"Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                //txtUsername.Focus();
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtUsername, "Please enter your Username!");
            }
        }

        #region Status Menu
        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ("Please insert your User name!");
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ("Please insert your Password!");
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ("Press Login!");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }



        #endregion Status Menu

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
            }
        }
    }
}
