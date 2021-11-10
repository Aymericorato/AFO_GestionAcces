using AFO_GestionAcces.Services;
using AFO_GestionAcces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AFO_GestionAcces
{
    public partial class PersonneForm : Form
    {
        private readonly IDataService _dataService;

        public PersonneForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }
        public PersonneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personne nouveau = new Personne
            {
                Prenom = TxtPrenom.Text,
                Nom = TxtNom.Text,
                Badge = TxtBadge.Text
            }
            _dataService.CreatePersonne(nouveau);
        }
    }
}
