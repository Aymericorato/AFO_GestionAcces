using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using AFO_GestionAcces.Services;

namespace AFO_GestionAcces
{
    public partial class Simulateur : Form
    {
        private readonly IDataService _dataService;

        public Simulateur(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbxPersonne.DataSource = _dataService.GetPersonnes();
            CbxPersonne.DisplayMember = "NomPrenom";
            CbxPersonne.ValueMember = "NomPrenom";
            

            CbxBatiment.DataSource = _dataService.GetBatiments();
            CbxBatiment.DisplayMember = "Nom";
            CbxBatiment.ValueMember = "Nom";

            CbxProfile.DataSource = _dataService.GetProfiles();
            CbxProfile.DisplayMember = "LibelType";
            CbxProfile.ValueMember = "LibelType";
            
        }
    }
}
