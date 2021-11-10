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
    public partial class ProfilForm : Form
    {
        private readonly IDataService _dataService;

        public ProfilForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }
        public ProfilForm()
        {
            InitializeComponent();
        }
    }
}
