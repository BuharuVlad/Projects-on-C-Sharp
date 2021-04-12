using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void addCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDrivers addDrivers = new AddDrivers();
            addDrivers.Show();
        }

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
    }
}
