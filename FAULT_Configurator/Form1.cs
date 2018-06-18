using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAULT_Configurator
{
    public partial class frmPrincipale : Form
    {
        private string[] tabTxtFaultType = new string[] { "MINEUR", "MAJEUR", "INFO" };
        private string[] tabTxtFaultState = new string[] { "INACTIF", "ACTIF" };
        private Fault SelectedFault; //TODO 

        public frmPrincipale()
        {
            InitializeComponent();
        }
    }
}
