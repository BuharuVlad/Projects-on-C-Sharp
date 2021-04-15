using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces;
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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        #region  Buttons   
        private void addRuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRute addRute = new AddRute();
            addRute.Show();
        }

        private void addTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransport addTransport = new AddTransport();
            addTransport.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Buttons

        #region View Buttons
        private void viewDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceDriver interfaceDriver = new InterfaceDriver();
            interfaceDriver.Show();
        } //Driver Interface
        private void viewCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceCar interfaceCar = new InterfaceCar();
            interfaceCar.Show();
        } //Car Interface
        
        #endregion

    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
