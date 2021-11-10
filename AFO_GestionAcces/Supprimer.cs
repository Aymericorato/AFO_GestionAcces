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
    public partial class Supprimer : Form
    {
        private readonly IDataService _dataService;
        public Supprimer(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {
            CbxPersonne.DataSource = _dataService.GetPersonnes();
            CbxPersonne.DisplayMember = "NomPrenom";
            CbxPersonne.ValueMember = "NomPrenom";
            CbxPersonne.SelectedIndex = -1;

            CbxBatiment.DataSource = _dataService.GetBatiments();
            CbxBatiment.DisplayMember = "Nom";
            CbxBatiment.ValueMember = "Nom";

            CbxProfil.DataSource = _dataService.GetProfiles();
            CbxProfil.DisplayMember = "LibelType";
            CbxProfil.ValueMember = "LibelType";

            //Affichage des GroupBox
            GrbxBatiment.Visible = false;
            GrbxProfil.Visible = false;
        }

        private void RbnPersonne_CheckedChanged(object sender, EventArgs e)
        {
            GrbxPersonne.Visible = true;
            GrbxBatiment.Visible = false;
            GrbxProfil.Visible = false;

            CbxProfil.SelectedIndex = -1;
            CbxBatiment.SelectedIndex = -1;

        }

        private void RbnBatiment_CheckedChanged(object sender, EventArgs e)
        {
            GrbxBatiment.Visible = true;
            GrbxProfil.Visible = false;
            GrbxPersonne.Visible = false;

            CbxPersonne.SelectedIndex = -1;
            CbxProfil.SelectedIndex = -1;
        }

        private void RbnProfil_CheckedChanged(object sender, EventArgs e)
        {
            GrbxProfil.Visible = true;
            GrbxBatiment.Visible = false;
            GrbxPersonne.Visible = false;

            CbxPersonne.SelectedIndex = -1;
            CbxBatiment.SelectedIndex = -1;
        }
    }
}
