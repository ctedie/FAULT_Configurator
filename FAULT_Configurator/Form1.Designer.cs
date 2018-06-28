namespace FAULT_Configurator
{
    partial class frmPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDefaultConf = new System.Windows.Forms.GroupBox();
            this.cbxFaultType = new System.Windows.Forms.ComboBox();
            this.cbxFaultInitState = new System.Windows.Forms.ComboBox();
            this.txtDisAct = new System.Windows.Forms.TextBox();
            this.txtDisCond = new System.Windows.Forms.TextBox();
            this.txtPresAct = new System.Windows.Forms.TextBox();
            this.txtAppAct = new System.Windows.Forms.TextBox();
            this.txtAppCond = new System.Windows.Forms.TextBox();
            this.txtFaultName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCondApparition = new System.Windows.Forms.Label();
            this.lblEtatInit = new System.Windows.Forms.Label();
            this.lblTypeDefaut = new System.Windows.Forms.Label();
            this.lblNomDefaut = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOutils = new System.Windows.Forms.ToolStripMenuItem();
            this.genererCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewFault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.exporterListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDefaultConf.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType});
            this.listView1.Location = new System.Drawing.Point(26, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nom";
            this.columnName.Width = 138;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 106;
            // 
            // grpDefaultConf
            // 
            this.grpDefaultConf.Controls.Add(this.cbxFaultType);
            this.grpDefaultConf.Controls.Add(this.cbxFaultInitState);
            this.grpDefaultConf.Controls.Add(this.txtDisAct);
            this.grpDefaultConf.Controls.Add(this.txtDisCond);
            this.grpDefaultConf.Controls.Add(this.txtPresAct);
            this.grpDefaultConf.Controls.Add(this.txtAppAct);
            this.grpDefaultConf.Controls.Add(this.txtAppCond);
            this.grpDefaultConf.Controls.Add(this.txtFaultName);
            this.grpDefaultConf.Controls.Add(this.label5);
            this.grpDefaultConf.Controls.Add(this.label4);
            this.grpDefaultConf.Controls.Add(this.label3);
            this.grpDefaultConf.Controls.Add(this.label2);
            this.grpDefaultConf.Controls.Add(this.lblCondApparition);
            this.grpDefaultConf.Controls.Add(this.lblEtatInit);
            this.grpDefaultConf.Controls.Add(this.lblTypeDefaut);
            this.grpDefaultConf.Controls.Add(this.lblNomDefaut);
            this.grpDefaultConf.Enabled = false;
            this.grpDefaultConf.Location = new System.Drawing.Point(311, 38);
            this.grpDefaultConf.Name = "grpDefaultConf";
            this.grpDefaultConf.Size = new System.Drawing.Size(566, 387);
            this.grpDefaultConf.TabIndex = 1;
            this.grpDefaultConf.TabStop = false;
            this.grpDefaultConf.Text = "Configuration du défaut";
            // 
            // cbxFaultType
            // 
            this.cbxFaultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFaultType.FormattingEnabled = true;
            this.cbxFaultType.Items.AddRange(new object[] {
            "MINEUR",
            "MAJEUR",
            "INFO"});
            this.cbxFaultType.Location = new System.Drawing.Point(149, 58);
            this.cbxFaultType.Name = "cbxFaultType";
            this.cbxFaultType.Size = new System.Drawing.Size(157, 21);
            this.cbxFaultType.TabIndex = 2;
            // 
            // cbxFaultInitState
            // 
            this.cbxFaultInitState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFaultInitState.FormattingEnabled = true;
            this.cbxFaultInitState.Items.AddRange(new object[] {
            "INACTIF",
            "ACTIF"});
            this.cbxFaultInitState.Location = new System.Drawing.Point(149, 86);
            this.cbxFaultInitState.Name = "cbxFaultInitState";
            this.cbxFaultInitState.Size = new System.Drawing.Size(157, 21);
            this.cbxFaultInitState.TabIndex = 2;
            // 
            // txtDisAct
            // 
            this.txtDisAct.Location = new System.Drawing.Point(149, 318);
            this.txtDisAct.Name = "txtDisAct";
            this.txtDisAct.Size = new System.Drawing.Size(369, 20);
            this.txtDisAct.TabIndex = 1;
            // 
            // txtDisCond
            // 
            this.txtDisCond.Location = new System.Drawing.Point(149, 275);
            this.txtDisCond.Name = "txtDisCond";
            this.txtDisCond.Size = new System.Drawing.Size(369, 20);
            this.txtDisCond.TabIndex = 1;
            // 
            // txtPresAct
            // 
            this.txtPresAct.Location = new System.Drawing.Point(149, 232);
            this.txtPresAct.Name = "txtPresAct";
            this.txtPresAct.Size = new System.Drawing.Size(369, 20);
            this.txtPresAct.TabIndex = 1;
            // 
            // txtAppAct
            // 
            this.txtAppAct.Location = new System.Drawing.Point(149, 189);
            this.txtAppAct.Name = "txtAppAct";
            this.txtAppAct.Size = new System.Drawing.Size(369, 20);
            this.txtAppAct.TabIndex = 1;
            // 
            // txtAppCond
            // 
            this.txtAppCond.Location = new System.Drawing.Point(149, 146);
            this.txtAppCond.Name = "txtAppCond";
            this.txtAppCond.Size = new System.Drawing.Size(369, 20);
            this.txtAppCond.TabIndex = 1;
            // 
            // txtFaultName
            // 
            this.txtFaultName.Location = new System.Drawing.Point(149, 29);
            this.txtFaultName.Name = "txtFaultName";
            this.txtFaultName.Size = new System.Drawing.Size(369, 20);
            this.txtFaultName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Action à la disparition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Condition de disparition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Action en présence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Action à l\'apparition";
            // 
            // lblCondApparition
            // 
            this.lblCondApparition.AutoSize = true;
            this.lblCondApparition.Location = new System.Drawing.Point(22, 149);
            this.lblCondApparition.Name = "lblCondApparition";
            this.lblCondApparition.Size = new System.Drawing.Size(108, 13);
            this.lblCondApparition.TabIndex = 0;
            this.lblCondApparition.Text = "Condition d\'apparition";
            // 
            // lblEtatInit
            // 
            this.lblEtatInit.AutoSize = true;
            this.lblEtatInit.Location = new System.Drawing.Point(22, 89);
            this.lblEtatInit.Name = "lblEtatInit";
            this.lblEtatInit.Size = new System.Drawing.Size(53, 13);
            this.lblEtatInit.TabIndex = 0;
            this.lblEtatInit.Text = "Etat Initial";
            // 
            // lblTypeDefaut
            // 
            this.lblTypeDefaut.AutoSize = true;
            this.lblTypeDefaut.Location = new System.Drawing.Point(22, 61);
            this.lblTypeDefaut.Name = "lblTypeDefaut";
            this.lblTypeDefaut.Size = new System.Drawing.Size(31, 13);
            this.lblTypeDefaut.TabIndex = 0;
            this.lblTypeDefaut.Text = "Type";
            // 
            // lblNomDefaut
            // 
            this.lblNomDefaut.AutoSize = true;
            this.lblNomDefaut.Location = new System.Drawing.Point(22, 33);
            this.lblNomDefaut.Name = "lblNomDefaut";
            this.lblNomDefaut.Size = new System.Drawing.Size(29, 13);
            this.lblNomDefaut.TabIndex = 0;
            this.lblNomDefaut.Text = "Nom";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.menuOutils,
            this.menuAide});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(904, 24);
            this.menuBar.TabIndex = 2;
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "&Fichier";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // menuOutils
            // 
            this.menuOutils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genererCodeToolStripMenuItem,
            this.exporterListeToolStripMenuItem});
            this.menuOutils.Name = "menuOutils";
            this.menuOutils.Size = new System.Drawing.Size(50, 20);
            this.menuOutils.Text = "&Outils";
            // 
            // genererCodeToolStripMenuItem
            // 
            this.genererCodeToolStripMenuItem.Name = "genererCodeToolStripMenuItem";
            this.genererCodeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.genererCodeToolStripMenuItem.Text = "&Generer Code...";
            // 
            // menuAide
            // 
            this.menuAide.Name = "menuAide";
            this.menuAide.Size = new System.Drawing.Size(43, 20);
            this.menuAide.Text = "&Aide";
            // 
            // btnNewFault
            // 
            this.btnNewFault.Location = new System.Drawing.Point(397, 463);
            this.btnNewFault.Name = "btnNewFault";
            this.btnNewFault.Size = new System.Drawing.Size(75, 23);
            this.btnNewFault.TabIndex = 3;
            this.btnNewFault.Text = "Nouveau";
            this.btnNewFault.UseVisualStyleBackColor = true;
            this.btnNewFault.Click += new System.EventHandler(this.btnNewFault_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtnDelete
            // 
            this.dtnDelete.Location = new System.Drawing.Point(719, 462);
            this.dtnDelete.Name = "dtnDelete";
            this.dtnDelete.Size = new System.Drawing.Size(75, 23);
            this.dtnDelete.TabIndex = 3;
            this.dtnDelete.Text = "Supprimer";
            this.dtnDelete.UseVisualStyleBackColor = true;
            this.dtnDelete.Click += new System.EventHandler(this.dtnDelete_Click);
            // 
            // exporterListeToolStripMenuItem
            // 
            this.exporterListeToolStripMenuItem.Name = "exporterListeToolStripMenuItem";
            this.exporterListeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exporterListeToolStripMenuItem.Text = "Exporter liste...";
            this.exporterListeToolStripMenuItem.Click += new System.EventHandler(this.exporterListeToolStripMenuItem_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 539);
            this.Controls.Add(this.dtnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewFault);
            this.Controls.Add(this.grpDefaultConf);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmPrincipale";
            this.Text = "Fault Configurator";
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            this.grpDefaultConf.ResumeLayout(false);
            this.grpDefaultConf.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.GroupBox grpDefaultConf;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuOutils;
        private System.Windows.Forms.ToolStripMenuItem menuAide;
        private System.Windows.Forms.Label lblNomDefaut;
        private System.Windows.Forms.Label lblTypeDefaut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCondApparition;
        private System.Windows.Forms.Label lblEtatInit;
        private System.Windows.Forms.TextBox txtDisAct;
        private System.Windows.Forms.TextBox txtDisCond;
        private System.Windows.Forms.TextBox txtPresAct;
        private System.Windows.Forms.TextBox txtAppAct;
        private System.Windows.Forms.TextBox txtAppCond;
        private System.Windows.Forms.TextBox txtFaultName;
        private System.Windows.Forms.Button btnNewFault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button dtnDelete;
        private System.Windows.Forms.ComboBox cbxFaultType;
        private System.Windows.Forms.ComboBox cbxFaultInitState;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genererCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterListeToolStripMenuItem;
    }
}

