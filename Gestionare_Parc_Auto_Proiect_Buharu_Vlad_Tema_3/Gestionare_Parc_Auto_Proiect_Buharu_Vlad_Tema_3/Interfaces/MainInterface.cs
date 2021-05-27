using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes;
using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DragDropEffects;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    public partial class Dashbord : Form
    {
        #region Attributes

        private AllData transport = new AllData();
        private List<Car> _cars;
        private List<Driver> _drivers;
        private List<Rute> _rutes;
        private List<Transport> _transports;
        private List<AllData> DashBordGripList = new List<AllData>();
        private const string ConnectionCar = "Data Source=Cars.db";
        private const string ConnectionDriver = "Data Source=Drivers.db";
        private const string ConnectionRute = "Data Source=Rute.db";
        private const string ConnectionTransport = "Data Source=Transport.db";
        private DataSerializer dataSerializer = new DataSerializer();
        private Bitmap bitmap;
        DateTime dateTime = DateTime.Now;


        bool testClickEventCar = false, testClickEventRuteFrom = false, testClickEventRuteTo = false;

        #endregion
        public Dashbord()
        {
            InitializeComponent();
            _cars = new List<Car>();
            _drivers = new List<Driver>();
            _rutes = new List<Rute>();
            _transports = new List<Transport>();
            CheckProductsTransport();
        }

        #region  Buttons + Serializare binara + Deserializare
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Transport_Click(object sender, EventArgs e)
        {
            if (cbNameCar.Text == "" | cbNameRute.Text == "" | cbFirstNameDriver.Text == "" | cbSecondNameDriver.Text == "")
            {
                MessageBox.Show("A case is blank", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                #region add in DashBordList
                string birthDayDriver;
                try
                {
                    transport.FirstNameDriver = cbFirstNameDriver.Text;
                    transport.SecondNameDriver = cbSecondNameDriver.Text;

                    birthDayDriver = txtBirthDateDriver.Text;
                    transport.BirthDayDriver = DateTime.Parse(birthDayDriver);

                    if (CheckDriver(transport.FirstNameDriver,
                        transport.SecondNameDriver,
                        transport.BirthDayDriver) == true)
                    {
                        ConvertSQLiteDataInDriver();
                        foreach (var driver in _drivers)
                        {
                            if (driver.NameCar.Equals(transport.FirstNameDriver) &&
                                driver.SecondNameDriver.Equals(transport.SecondNameDriver) &&
                                driver.BirthDayDriver.Equals(transport.BirthDayDriver))
                            {
                                transport.AdressDriver = driver.AdressDriver;
                                transport.SalaryDriver = driver.SalaryDriver;
                                break;
                            }
                        }
                    }

                    transport.ProductTransport = cbProducts.Text;

                    string quantityTransport = txtQuantityTransport.Text;
                    transport.QuantityTransport = Int32.Parse(quantityTransport);

                    transport.NameCar = cbNameCar.Text;
                    transport.ModelCar = cbModelCar.Text;
                    transport.NameRute = cbNameRute.Text;
                    transport.FromRute = txtFromRute.Text;
                    transport.ToRute = txtToRute.Text;
                    DashBordGripList.Add(transport);
                    addInListView(DashBordGripList);
                    dataSerializer.BinarySerializeObject(DashBordGripList);
                }
                catch (CustomException)
                {
                    MessageBox.Show("Error");
                }
                #endregion
            }
        }
        private void addInListView(List<AllData> DashBordGripList)
        {
            //SERIALIZARE
            lvTransport.Items.Clear();
            if (File.Exists("serializeb.bin"))
            {
                foreach (var transport in DashBordGripList)
                {
                    ListViewItem item = new ListViewItem(transport.ProductTransport);
                    item.SubItems.Add(transport.QuantityTransport.ToString());
                    item.SubItems.Add(transport.NameCar);
                    item.SubItems.Add(transport.ModelCar);
                    item.SubItems.Add(transport.NameRute);
                    item.SubItems.Add(transport.FromRute);
                    item.SubItems.Add(transport.ToRute);
                    item.SubItems.Add(transport.FirstNameDriver);
                    item.SubItems.Add(transport.SecondNameDriver);
                    item.SubItems.Add(transport.BirthDayDriver.ToString());
                    //si restul elementelor
                    item.Tag = transport;
                    lvTransport.Items.Add(item);
                }
            }

        }
        private void btn_View_All_List_Click(object sender, EventArgs e)
        {
            //DEZERIALIZARE
            int nr = lvTransport.Items.Count;
            for (int i = 0; i < nr; i++)
            {
                lvTransport.Items[i].Text = "";
            }
            lvTransport.Items.Clear();
            DashBordGripList = dataSerializer.Deserialize();
            addInListView(DashBordGripList);
        }

        private void btn_Delete_Transport_Click(object sender, EventArgs e)
        {
            if (lvTransport.SelectedItems.Count == 1)
            {
                DashBordGripList.Remove((AllData)lvTransport.SelectedItems[0].Tag);
                dataSerializer.BinarySerializeObject(DashBordGripList);
                addInListView(DashBordGripList);
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbProducts.Text = "";
            txtQuantityTransport.Text = "";
            cbNameCar.Text = "";
            cbModelCar.Text = "";
            cbNameRute.Text = "";
            txtFromRute.Text = "";
            txtToRute.Text = "";
            cbFirstNameDriver.Text = "";
            cbSecondNameDriver.Text = "";
            txtBirthDateDriver.Text = "";
            using (SQLiteConnection con = new SQLiteConnection(ConnectionTransport))
            {
                cbProducts.Items.Clear();
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT ProductTransport FROM Transport", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbProducts.Items.Add(dr.GetString(0));
                }
            }
            using (SQLiteConnection con = new SQLiteConnection(ConnectionCar))
            {
                cbNameCar.Items.Clear();
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameCar FROM Cars", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameCar.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionRute))
            {
                cbNameRute.Items.Clear();
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameRute FROM Rute", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameRute.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionDriver))
            {
                cbFirstNameDriver.Items.Clear();
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT FirstName FROM Drivers", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbFirstNameDriver.Items.Add(dr.GetString(0));
                }
            }
            lvTransport.Items.Clear();
        }
        #endregion //Buttons

        #region View Buttons
        private void ViewDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceDriver interfaceDriver = new InterfaceDriver();
            interfaceDriver.Show();
        } //Driver Interface
        private void ViewCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceCar interfaceCar = new InterfaceCar();
            interfaceCar.Show();
        } //Car Interface
        private void ViewRutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceRute interfaceRute = new InterfaceRute();
            interfaceRute.Show();
        } //Rute Interface

        private void ViewTransportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceTransport interfaceTransport = new InterfaceTransport();
            interfaceTransport.Show();
        } //Transport Interface

       
        #endregion

        #region Methods
        #region Convert methods from SQLite in List
        public void ConvertSQLiteDataInCar()
        {
            _cars.Clear();
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionCar))
            {
                connect.Open();
                _cars.Clear();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT NameCar, ModelCar FROM Cars";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string NameCar = (string)r["NameCar"];
                        string ModelCar = (string)r["ModelCar"];
                        _cars.Add(new Car(NameCar, ModelCar));
                    }
                }
            }
        } // ConvertSQLiteDataInCar
        public void ConvertSQLiteDataInDriver()
        {
            _drivers.Clear();
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionDriver))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT FirstName, SecondName, BirthDay, Salary, Adress FROM Drivers";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string FirstName = (string)r["FirstName"];
                        string SecondName = (string)r["SecondName"];
                        string BirthDay = (string)r["BirthDay"];
                        DateTime birthDateTime = DateTime.Parse(BirthDay);
                        long Salary = (Int64)r["Salary"]; 
                        string Adress = (string)r["Adress"];
                        _drivers.Add(new Driver(FirstName, SecondName, birthDateTime, Adress, Salary));
                    }
                }
            }
        } //ConvertSQLiteDataInDriver
        public void ConvertSQLiteDateInRute()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionRute))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT NameRute, FromRute, ToRute FROM Rute";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string NameRute = (string)r["NameRute"];
                        string FromRute = (string)r["FromRute"];
                        string ToRute = (string)r["ToRute"];
                        _rutes.Add(new Rute(NameRute, FromRute, ToRute));
                    }
                }
            }
        } // ConvertSQLiteDateInRute
        public void ConvertSQLiteDateInTransport()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionTransport))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT ProductTransport, QuantityTransport FROM Transport";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string ProductTransport = (string)r["ProductTransport"];
                        var quantityVar = r["QuantityTransport"];
                        int QuantityTransport = int.Parse(string.Format("{0}", quantityVar));
                        _transports.Add(new Transport(ProductTransport, QuantityTransport));
                    }
                }
            }
        } // ConvertSQLiteDateInTransport
        #endregion // Convert methods from SQLite in List

        #region Check TextBoxs

        private void CheckProductsTransport()
        {
            ConvertSQLiteDateInTransport();
            cbProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            foreach(Transport transport in _transports)
            {
                coll.Add(transport.ProductTransport);
            }
            cbProducts.AutoCompleteCustomSource = coll;
        }

        private bool CheckDriver(string firstname, string secondName, DateTime birthDay)
        {
            ConvertSQLiteDataInDriver();
            bool test = false;
            foreach (var driver in _drivers)
            {
                if (driver.NameCar.Equals(firstname) &&
                    driver.SecondNameDriver.Equals(secondName) &&
                    driver.BirthDayDriver.Equals(birthDay))
                {
                    test = true;
                    break;
                }
            }

            return test;
        }


        #endregion //Check TextBoxs

        #region Start Dashbord && Connections with SQLite

        private void Dashbord_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionTransport))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT ProductTransport FROM Transport", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbProducts.Items.Add(dr.GetString(0));
                }
            }
            using (SQLiteConnection con = new SQLiteConnection(ConnectionCar))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameCar FROM Cars", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameCar.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionRute))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameRute FROM Rute", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameRute.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionDriver))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT FirstName FROM Drivers", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbFirstNameDriver.Items.Add(dr.GetString(0));
                }
            }

            if (File.Exists("serializeb.bin"))
            {
                DashBordGripList = dataSerializer.Deserialize();
                addInListView(DashBordGripList);
            }
            
            cbProducts.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
            cbProducts.MouseDown += new MouseEventHandler(richTextBox1_MouseDown);
            cbProducts.DragDrop += new DragEventHandler(richTextBox1_DragDrop);


        }

        #endregion


        #endregion // Methods


        #region KeyDown
        private void cbProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                cbNameCar.Focus();
            }
        }
       
        private void cbNameCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                cbModelCar.Focus();
            }
        }



        #endregion KeyDown

        private void cbProducts_Validating(object sender, CancelEventArgs e)
        {
            bool test = false;
            foreach (Transport transport in _transports)
            {
                if (cbProducts.Text.Equals(transport.ProductTransport))
                {
                    errorProvider1.SetError((Control) cbProducts, null);
                    test = true;
                    break;
                }
            }
            if (test == false)
            {
                e.Cancel = true;
                cbProducts.Focus();
                errorProvider1.SetError((Control)cbProducts, "Check the list again!");
            }
        }

        #region Index Changed

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtQuantityTransport != null)
            {
                txtQuantityTransport.Clear();
            }
            ConvertSQLiteDateInTransport();
            foreach (var transport in _transports)
            {
                if (cbProducts.Text.Equals(transport.ProductTransport))
                {
                    txtQuantityTransport.Text = transport.QuantityTransport.ToString();
                }
            }
        }
        private void cbNameCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModelCar.Items.Clear();
            ConvertSQLiteDataInCar();
            if (cbModelCar != null)
            {
                cbModelCar.Text = "";
            }
            foreach (var car in _cars)
            {
                if (cbNameCar.Text.Equals(car.NameCar))
                {
                    cbModelCar.Items.Add(car.ModelCar);
                }
            }
        }
        private void cbNameRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertSQLiteDateInRute();
            foreach (var rute in _rutes)
            {
                if (cbNameRute.Text.Equals(rute.NameRute))
                {
                    txtFromRute.Text = rute.FromRute;
                    txtToRute.Text = rute.ToRute;
                }
            }

        }

        private void cbSecondNameDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBirthDateDriver.Clear();
            if (txtBirthDateDriver.Text != null)
            {
                txtBirthDateDriver.Text = "";
            }
            ConvertSQLiteDataInDriver();
            foreach (var driver in _drivers)
            {
                if (cbSecondNameDriver.Text.Equals(driver.SecondNameDriver))
                {
                    txtBirthDateDriver.Text = driver.BirthDayDriver.ToLongDateString();
                }
            }
        }

        private void cbFirstNameDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSecondNameDriver.Items.Clear();
            txtBirthDateDriver.Clear();
            if (cbSecondNameDriver.Text != null)
            {
                cbSecondNameDriver.Text = "";
            }
            if (txtBirthDateDriver.Text != null)
            {
                txtBirthDateDriver.Text = "";
            }

            ConvertSQLiteDataInDriver();
            foreach (var driver in _drivers)
                if (cbFirstNameDriver.Text.Equals(driver.FirstNameDriver)) cbSecondNameDriver.Items.Add(driver.SecondNameDriver);
        }
        #endregion

        #region Print

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Username: " + loginFrom.getUsername(), new Font("Arial",
                    12, FontStyle.Regular), Brushes.Black, new PointF(50,100));
            e.Graphics.DrawString("Date time: " + dateTime.ToLongDateString() , new Font("Arial",
                    12, FontStyle.Regular), Brushes.Black, new PointF(50, 120));

            int hight = 160;
            float pageHeight = e.MarginBounds.Height;

            if (lvTransport.Items.Count != 0)
            {
                foreach (ListViewItem item in lvTransport.Items)
                {
                    e.Graphics.DrawString(item.Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(50, hight));
                    e.Graphics.DrawString(item.SubItems[1].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(100, hight));
                    e.Graphics.DrawString(item.SubItems[2].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(135, hight));
                    e.Graphics.DrawString(item.SubItems[3].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(210, hight));
                    e.Graphics.DrawString(item.SubItems[4].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(300, hight));
                    e.Graphics.DrawString(item.SubItems[7].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(455, hight));
                    e.Graphics.DrawString(item.SubItems[8].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(515, hight));
                    e.Graphics.DrawString(item.SubItems[9].Text, new Font("Times New Roman", 12), Brushes.Black,
                        new PointF(585, hight));
                    hight += 20;
                    if (hight >= pageHeight)
                    {
                        e.HasMorePages = true;
                        hight = 50;
                        break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Didn't have itmes in list view! Select All List View button!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printPreviewDialog1.Close();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

       

        private void btnPrintSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
                printPreviewDialog1.ShowDialog();
            }
        }

        




        #endregion

        #region Clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTransport.SelectedItems.Count > 0)
            {
                string productTransport = lvTransport.SelectedItems[0].SubItems[0].Text;
                int quantityTransport = Int32.Parse(lvTransport.SelectedItems[0].SubItems[1].Text);
                string nameCar = lvTransport.SelectedItems[0].SubItems[2].Text;
                string modelCar = lvTransport.SelectedItems[0].SubItems[3].Text;
                string nameRute = lvTransport.SelectedItems[0].SubItems[4].Text;
                string FromRute = lvTransport.SelectedItems[0].SubItems[5].Text;
                string ToRute = lvTransport.SelectedItems[0].SubItems[6].Text;
                string firstNameDriver = lvTransport.SelectedItems[0].SubItems[7].Text;
                string secondNameDriver = lvTransport.SelectedItems[0].SubItems[8].Text;
                DateTime birthDayDriver = DateTime.Parse(lvTransport.SelectedItems[0].SubItems[9].Text);

                transport = new AllData();
                transport = new AllData(nameCar, modelCar, firstNameDriver,
                    secondNameDriver, birthDayDriver, nameRute, FromRute, ToRute
                    , productTransport, quantityTransport);
                Clipboard.SetText(transport.ToString());
            }
            else
            {
                MessageBox.Show("Select a item from ListView!", "Warnning", MessageBoxButtons.OK);
            }
        }

        

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        #endregion

        #region Drag and Drop


       


        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.DoDragDrop(richTextBox1.Text, DragDropEffects.Copy);
            //RichTextBox tb = (RichTextBox)sender;
            //string text = tb.SelectedText;
            //tb.DoDragDrop(text, DragDropEffects.Copy);
        }


        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent((DataFormats.Text)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }
        #endregion


    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
