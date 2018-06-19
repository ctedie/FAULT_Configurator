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
            this.columnName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDefaultConf = new System.Windows.Forms.GroupBox();
            this.cbxFaultType = new System.Windows.Forms.ComboBox();
            this.cbxFaultInitState = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.menuOutils = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDefaultConf.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName1,
            this.columnType1});
            this.listView1.Location = new System.Drawing.Point(26, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnName1
            // 
            this.columnName1.Text = "Nom";
            this.columnName1.Width = 138;
            // 
            // columnType1
            // 
            this.columnType1.Text = "Type";
            this.columnType1.Width = 106;
            // 
            // grpDefaultConf
            // 
            this.grpDefaultConf.Controls.Add(this.cbxFaultType);
            this.grpDefaultConf.Controls.Add(this.cbxFaultInitState);
            this.grpDefaultConf.Controls.Add(this.textBox8);
            this.grpDefaultConf.Controls.Add(this.textBox7);
            this.grpDefaultConf.Controls.Add(this.textBox6);
            this.grpDefaultConf.Controls.Add(this.textBox5);
            this.grpDefaultConf.Controls.Add(this.textBox4);
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
            "MINEUR",
            "MAJEUR",
            "INFO"});
            this.cbxFaultInitState.Location = new System.Drawing.Point(149, 86);
            this.cbxFaultInitState.Name = "cbxFaultInitState";
            this.cbxFaultInitState.Size = new System.Drawing.Size(157, 21);
            this.cbxFaultInitState.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(149, 318);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(369, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(149, 275);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(369, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 232);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(369, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(369, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(369, 20);
            this.textBox4.TabIndex = 1;
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
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "&Fichier";
            // 
            // menuOutils
            // 
            this.menuOutils.Name = "menuOutils";
            this.menuOutils.Size = new System.Drawing.Size(50, 20);
            this.menuOutils.Text = "&Outils";
            // 
            // menuAide
            // 
            this.menuAide.Name = "menuAide";
            this.menuAide.Size = new System.Drawing.Size(43, 20);
            this.menuAide.Text = "&Aide";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtnDelete
            // 
            this.dtnDelete.Location = new System.Drawing.Point(719, 462);
            this.dtnDelete.Name = "dtnDelete";
            this.dtnDelete.Size = new System.Drawing.Size(75, 23);
            this.dtnDelete.TabIndex = 3;
            this.dtnDelete.Text = "Supprimer";
            this.dtnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
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
        private System.Windows.Forms.ColumnHeader columnName1;
        private System.Windows.Forms.ColumnHeader columnType1;
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
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtFaultName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button dtnDelete;
        private System.Windows.Forms.ComboBox cbxFaultType;
        private System.Windows.Forms.ComboBox cbxFaultInitState;
        private System.Windows.Forms.Label label1;
    }
}

