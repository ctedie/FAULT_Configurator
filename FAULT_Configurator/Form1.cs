﻿using System;
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
        private List<Fault> fltList = new List<Fault>(); //TODO 
        

        public frmPrincipale()
        {
            InitializeComponent();
        }

        void eraseFaultConf()
        {
            
        }

        private void fillFaultConf(Fault def)
        {
            grpDefaultConf.Enabled = true;
            txtFaultName.Text = def.Name;
            cbxFaultType.SelectedIndex = (int)def.Type;
            cbxFaultInitState.SelectedIndex = (int)def.InitState;


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int foundIndex;
            
            if (listView1.SelectedItems.Count > 0)
            {
                //label1.Text = listView1.SelectedItems[0].Text;
                try
                {
                    foundIndex = listView1.Items[listView1.SelectedItems[0].Text].Index;
                }
                catch (Exception)
                {

                    return;
                }

                label1.Text = fltList.ElementAt(foundIndex).Name;
                fillFaultConf(fltList.ElementAt(foundIndex));
                //TODO Enable groupbox and fill the fault

            }

        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            Fault defaut = new Fault();

            defaut.Name = "DEFAUT_TEST";
            defaut.Type = FaultType.MINOR;

            fltList.Add(defaut);

            foreach (var item in fltList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.Name;
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Type.ToString());
                
                listView1.Items.Add(lvi);
            }

        }
    }
}
