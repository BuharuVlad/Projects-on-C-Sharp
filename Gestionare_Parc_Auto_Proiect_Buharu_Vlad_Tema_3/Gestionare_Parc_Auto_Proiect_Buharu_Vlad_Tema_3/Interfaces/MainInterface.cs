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
        private void viewRutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceRute interfaceRute = new InterfaceRute();
            interfaceRute.Show();
        } //Rute Interface

        private void viewTransportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceTransport interfaceTransport = new InterfaceTransport();
            interfaceTransport.Show();
        } //Transport Interface

        #endregion

    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
