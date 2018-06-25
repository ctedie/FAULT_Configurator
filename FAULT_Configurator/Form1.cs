using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FAULT_Configurator
{
    public partial class frmPrincipale : Form
    {
        private const string FIELD_FAULT_NAME = "fault_name=";
        private const string FIELD_FAULT_TYPE = "fault_name=";
        private const string FIELD_FAULT_INIT = "fault_init=";
        private const string FIELD_FAULT_APPARITION_CONDITION = "app_conditon=";
        private const string FIELD_FAULT_APPARITION_ACTION = "app_action=";
        private const string FIELD_FAULT_PRESENCE_ACTION = "presence_action=";
        private const string FIELD_FAULT_DISPARITION_CONDITION = "disp_condition=";
        private const string FIELD_FAULT_DISPARITION_ACTION = "disp_action=";

        private const string WINDOWS_TITLE = "Fault Configurator";

        private string m_TitleComplement = " - No File Selected";
        private string[] m_TabTxtFaultType = new string[] { "MINEUR", "MAJEUR", "INFO" };
        private string[] m_TabTxtFaultState = new string[] { "INACTIF", "ACTIF" };
        private List<Fault> m_FltList = new List<Fault>(); //TODO 
        private string m_StrFaultFile;

        private Fault m_SelectedFault;


        public frmPrincipale()
        {
            InitializeComponent();
        }

        void eraseFaultConf()
        {
            txtFaultName.Text = "";
            cbxFaultInitState.SelectedIndex = -1;
            cbxFaultType.SelectedIndex = -1;

            txtAppCond.Text = "";
            txtAppAct.Text = "";
            txtPresAct.Text = "";
            txtDisCond.Text = "";
            txtDisAct.Text = "";

        }

        private void fillFaultConf(Fault def)
        {
            grpDefaultConf.Enabled = true;

            txtFaultName.Text = def.Name;
            cbxFaultType.SelectedIndex = (int)def.Type;
            cbxFaultInitState.SelectedIndex = (int)def.InitState;

            txtAppCond.Text = def.TextConditionApp;
            txtAppAct.Text = def.TextActionApp;
            txtPresAct.Text = def.TextPresence;
            txtDisCond.Text = def.TextConditionDisp;
            txtDisAct.Text = def.TextActionDisp;

        }


        void saveFaults(string strFilename)
        {
            string strFaultName;
            string strFaultType;
            string strFaultInitState;
            string strFaultAppCond;
            string strFaultAppAct;
            string strFaultDispCond;
            string strFaultDispAct;
            string strFaultPresAct;

            StreamWriter file = new StreamWriter(strFilename);
            

            //TODO Open file


            //TODO Save all fault in file
            foreach (Fault fltItem in m_FltList)
            {
                //TODO Create Fault section
                strFaultName = fltItem.Name;
                strFaultType = fltItem.Type.ToString();
                strFaultInitState = fltItem.InitState.ToString();
                strFaultPresAct = fltItem.TextPresence;
                strFaultAppCond = fltItem.TextConditionApp;
                strFaultAppAct = fltItem.TextActionApp;
                strFaultDispCond = fltItem.TextConditionDisp;
                strFaultDispAct = fltItem.TextActionDisp;

                //TODO Save Fault Config
                file.WriteLine("[" + strFaultName + "]");
                file.WriteLine(FIELD_FAULT_NAME + strFaultName);
                file.WriteLine(FIELD_FAULT_TYPE + strFaultType);
                file.WriteLine(FIELD_FAULT_INIT + strFaultInitState);
                file.WriteLine(FIELD_FAULT_APPARITION_CONDITION + strFaultAppCond);
                file.WriteLine(FIELD_FAULT_APPARITION_ACTION + strFaultAppAct);
                file.WriteLine(FIELD_FAULT_PRESENCE_ACTION + strFaultPresAct);
                file.WriteLine(FIELD_FAULT_DISPARITION_CONDITION + strFaultDispCond);
                file.WriteLine(FIELD_FAULT_DISPARITION_ACTION + strFaultDispAct);
                file.WriteLine("");

            }

            file.Close();
        }

        void openFaults(string strFileName)
        {
            m_FltList.Clear();

            //TODO Parse file and add faults to list

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

                label1.Text = m_FltList.ElementAt(foundIndex).Name;
                m_SelectedFault = m_FltList.ElementAt(foundIndex);
                fillFaultConf(m_FltList.ElementAt(foundIndex));
                //TODO Enable groupbox and fill the fault

            }

        }

        private void refreshFaultList()
        {
            listView1.Items.Clear();

            foreach (var item in m_FltList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.Name;
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Type.ToString());

                listView1.Items.Add(lvi);
            }

            listView1.Update();

            //listView1.Refresh();

        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            this.Text = WINDOWS_TITLE + m_TitleComplement;


            Fault defaut = new Fault();
            defaut.Name = "DEFAUT_TEST";
            defaut.Type = FaultType.MINOR;
            defaut.TextPresence = "Allumer LED";
            m_FltList.Add(defaut);

            refreshFaultList();

        }

        private void refreshTitle()
        {
            this.Text = WINDOWS_TITLE + m_TitleComplement;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result;
            
            result = open.ShowDialog();
            
            switch (result)
            {
                case DialogResult.OK:
                    m_StrFaultFile = open.FileName;
                    m_TitleComplement = " - " + open.SafeFileName;
                    refreshTitle();
                    break;
                default:
                    return;
            }
            parseConfigFile(m_StrFaultFile);

        }

        private void parseConfigFile(string fileName)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFaults(m_StrFaultFile);
        }

        private void faultConfModify(object sender, EventArgs e)
        {
        //    // Get selected Fault
        //    Debug.WriteLine(m_SelectedFault.Name + "\n" + sender.GetType().ToString());

        //    if (sender.GetType().Name == txtAppCond.Name)
        //    {
        //        m_SelectedFault.Name = 
        //    }
        //    else if (sender.GetType().Name == txtAppAct.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == txtPresAct.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == txtDisCond.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == txtDisAct.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == cbxFaultInitState.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == cbxFaultType.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else if (sender.GetType().Name == txtFaultName.Name)
        //    {
        //        m_SelectedFault
        //    }
        //    else
        //    {
        //        //ERROR
        //    }
        //    //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //TODO Save Security

            m_SelectedFault.Name = txtFaultName.Text;
            m_SelectedFault.InitState = (FaultState)cbxFaultInitState.SelectedIndex;
            m_SelectedFault.Type = (FaultType)cbxFaultType.SelectedIndex;

            m_SelectedFault.TextConditionApp = txtAppCond.Text;
            m_SelectedFault.TextActionApp = txtAppAct.Text;
            m_SelectedFault.TextPresence = txtPresAct.Text;
            m_SelectedFault.TextConditionDisp = txtDisCond.Text;
            m_SelectedFault.TextActionDisp = txtDisAct.Text;

            //TODO Refreshe fault List on IHM
            refreshFaultList();
        }

        private void btnNewFault_Click(object sender, EventArgs e)
        {
            string fltName;

            fltName =  Microsoft.VisualBasic.Interaction.InputBox("Enter the FAULT name", "New Fault");
            if(fltName != "")
            {
                Fault flt = new Fault();

                eraseFaultConf();

                flt.Name = fltName;
                m_FltList.Add(flt);
                refreshFaultList();
            }
            else
            {
                return;
            }


        }
    }
}
