using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_ManajemenRumahSakit
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void patientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regis obj1 = new Regis();
            this.Hide();
            obj1.ShowDialog();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasien obj1 = new Pasien();
            this.Hide();
            obj1.ShowDialog();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter obj2 = new Dokter();
            this.Hide();
            obj2.ShowDialog();
        }

        private void roomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kamar obj1 = new Kamar();
            //this.Hide();
            //obj1.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void roomInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kamar obj1 = new Kamar();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
