using AFO_GestionAcces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFO_GestionAcces
{
    public partial class GestionAccèsMere : Form
    {
        private readonly IDataService _dataService;

        public GestionAccèsMere(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }
        public GestionAccèsMere()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simulateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Simulateur =  new Simulateur(_dataService);
            Simulateur.MdiParent = this;
            Simulateur.Show();
        }

        private void personneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Personne = new PersonneForm(_dataService);
            Personne.MdiParent = this;
            Personne.Show();
        }

        private void batimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Batiment = new BatimentForm(_dataService);
            Batiment.MdiParent = this;
            Batiment.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Profil = new ProfilForm(_dataService);
            Profil.MdiParent = this;
            Profil.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Supprimer = new Supprimer(_dataService);
            Supprimer.MdiParent = this;
            Supprimer.Show();
        }
    }
}
