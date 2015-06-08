namespace GestionEmployes.IHM.GestionEmploye
{
    partial class MenuEmploye
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmploye));
            this.navBar = new WindowsFormsControlLibrary1.NavBar();
            this.groupBoxTri = new System.Windows.Forms.GroupBox();
            this.radioButtonTriResp = new System.Windows.Forms.RadioButton();
            this.radioButtonTriService = new System.Windows.Forms.RadioButton();
            this.radioButtonTriBrut = new System.Windows.Forms.RadioButton();
            this.radioButtonTriEmbauche = new System.Windows.Forms.RadioButton();
            this.radioButtonTriNaissance = new System.Windows.Forms.RadioButton();
            this.radioButtonTriPrenom = new System.Windows.Forms.RadioButton();
            this.radioButtonTriNom = new System.Windows.Forms.RadioButton();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxId = new System.Windows.Forms.GroupBox();
            this.labelCalculAge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerNaissance = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.groupBoxContrat = new System.Windows.Forms.GroupBox();
            this.labelCalculAnciennete = new System.Windows.Forms.Label();
            this.labelSymboleEuro2 = new System.Windows.Forms.Label();
            this.labelSymboleEuro1 = new System.Windows.Forms.Label();
            this.numericUpDownNet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBrut = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerEmbauche = new System.Windows.Forms.DateTimePicker();
            this.labelSalaireNet = new System.Windows.Forms.Label();
            this.labelSalaireBrut = new System.Windows.Forms.Label();
            this.LabelAnciennete = new System.Windows.Forms.Label();
            this.labelDateEmbauche = new System.Windows.Forms.Label();
            this.groupBoxAffectation = new System.Windows.Forms.GroupBox();
            this.comboBoxResp = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTri.SuspendLayout();
            this.groupBoxId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrut)).BeginInit();
            this.groupBoxAffectation.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.ApresEnable = true;
            this.navBar.AvantEnable = true;
            this.navBar.ButtonBorder = 0;
            this.navBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBar.ImageDernier = ((System.Drawing.Image)(resources.GetObject("navBar.ImageDernier")));
            this.navBar.ImagePrecedent = ((System.Drawing.Image)(resources.GetObject("navBar.ImagePrecedent")));
            this.navBar.ImagePremier = ((System.Drawing.Image)(resources.GetObject("navBar.ImagePremier")));
            this.navBar.ImageSuivant = ((System.Drawing.Image)(resources.GetObject("navBar.ImageSuivant")));
            this.navBar.Location = new System.Drawing.Point(36, 12);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(462, 55);
            this.navBar.TabIndex = 0;
            this.navBar.TextDernier = "";
            this.navBar.TextPrecedent = "";
            this.navBar.TextPremier = "";
            this.navBar.TextSuivant = "";
            this.navBar.Navigation += new System.EventHandler<WindowsFormsControlLibrary1.NavBarEventArgs>(this.navBar_Navigation);
            // 
            // groupBoxTri
            // 
            this.groupBoxTri.Controls.Add(this.radioButtonTriResp);
            this.groupBoxTri.Controls.Add(this.radioButtonTriService);
            this.groupBoxTri.Controls.Add(this.radioButtonTriBrut);
            this.groupBoxTri.Controls.Add(this.radioButtonTriEmbauche);
            this.groupBoxTri.Controls.Add(this.radioButtonTriNaissance);
            this.groupBoxTri.Controls.Add(this.radioButtonTriPrenom);
            this.groupBoxTri.Controls.Add(this.radioButtonTriNom);
            this.groupBoxTri.Location = new System.Drawing.Point(12, 73);
            this.groupBoxTri.Name = "groupBoxTri";
            this.groupBoxTri.Size = new System.Drawing.Size(41, 397);
            this.groupBoxTri.TabIndex = 1;
            this.groupBoxTri.TabStop = false;
            this.groupBoxTri.Text = "Tri";
            // 
            // radioButtonTriResp
            // 
            this.radioButtonTriResp.AutoSize = true;
            this.radioButtonTriResp.Location = new System.Drawing.Point(14, 349);
            this.radioButtonTriResp.Name = "radioButtonTriResp";
            this.radioButtonTriResp.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriResp.TabIndex = 46;
            this.radioButtonTriResp.TabStop = true;
            this.radioButtonTriResp.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriService
            // 
            this.radioButtonTriService.AutoSize = true;
            this.radioButtonTriService.Location = new System.Drawing.Point(14, 314);
            this.radioButtonTriService.Name = "radioButtonTriService";
            this.radioButtonTriService.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriService.TabIndex = 45;
            this.radioButtonTriService.TabStop = true;
            this.radioButtonTriService.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriBrut
            // 
            this.radioButtonTriBrut.AutoSize = true;
            this.radioButtonTriBrut.Location = new System.Drawing.Point(14, 215);
            this.radioButtonTriBrut.Name = "radioButtonTriBrut";
            this.radioButtonTriBrut.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriBrut.TabIndex = 44;
            this.radioButtonTriBrut.TabStop = true;
            this.radioButtonTriBrut.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriEmbauche
            // 
            this.radioButtonTriEmbauche.AutoSize = true;
            this.radioButtonTriEmbauche.Location = new System.Drawing.Point(14, 165);
            this.radioButtonTriEmbauche.Name = "radioButtonTriEmbauche";
            this.radioButtonTriEmbauche.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriEmbauche.TabIndex = 43;
            this.radioButtonTriEmbauche.TabStop = true;
            this.radioButtonTriEmbauche.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriNaissance
            // 
            this.radioButtonTriNaissance.AutoSize = true;
            this.radioButtonTriNaissance.Location = new System.Drawing.Point(14, 77);
            this.radioButtonTriNaissance.Name = "radioButtonTriNaissance";
            this.radioButtonTriNaissance.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriNaissance.TabIndex = 42;
            this.radioButtonTriNaissance.TabStop = true;
            this.radioButtonTriNaissance.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriPrenom
            // 
            this.radioButtonTriPrenom.AutoSize = true;
            this.radioButtonTriPrenom.Location = new System.Drawing.Point(14, 54);
            this.radioButtonTriPrenom.Name = "radioButtonTriPrenom";
            this.radioButtonTriPrenom.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriPrenom.TabIndex = 41;
            this.radioButtonTriPrenom.TabStop = true;
            this.radioButtonTriPrenom.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriNom
            // 
            this.radioButtonTriNom.AutoSize = true;
            this.radioButtonTriNom.Location = new System.Drawing.Point(14, 30);
            this.radioButtonTriNom.Name = "radioButtonTriNom";
            this.radioButtonTriNom.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTriNom.TabIndex = 40;
            this.radioButtonTriNom.TabStop = true;
            this.radioButtonTriNom.UseVisualStyleBackColor = true;
            // 
            // buttonImporter
            // 
            this.buttonImporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImporter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonImporter.Image = ((System.Drawing.Image)(resources.GetObject("buttonImporter.Image")));
            this.buttonImporter.Location = new System.Drawing.Point(113, 476);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(51, 40);
            this.buttonImporter.TabIndex = 13;
            this.toolTip.SetToolTip(this.buttonImporter, "Charger");
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonImporter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnnuler.Image")));
            this.buttonAnnuler.Location = new System.Drawing.Point(398, 476);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(51, 41);
            this.buttonAnnuler.TabIndex = 22;
            this.toolTip.SetToolTip(this.buttonAnnuler, "Annuler les modifications");
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonValider.Image = ((System.Drawing.Image)(resources.GetObject("buttonValider.Image")));
            this.buttonValider.Location = new System.Drawing.Point(341, 476);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(51, 41);
            this.buttonValider.TabIndex = 21;
            this.toolTip.SetToolTip(this.buttonValider, "Valider les modifications");
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupprimer.Image")));
            this.buttonSupprimer.Location = new System.Drawing.Point(284, 476);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(51, 41);
            this.buttonSupprimer.TabIndex = 20;
            this.toolTip.SetToolTip(this.buttonSupprimer, "Supprimer");
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonExporter
            // 
            this.buttonExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExporter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExporter.Image = ((System.Drawing.Image)(resources.GetObject("buttonExporter.Image")));
            this.buttonExporter.Location = new System.Drawing.Point(170, 476);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(51, 40);
            this.buttonExporter.TabIndex = 19;
            this.toolTip.SetToolTip(this.buttonExporter, "Sauvegarder");
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonExporter_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonQuitter.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitter.Image")));
            this.buttonQuitter.Location = new System.Drawing.Point(455, 476);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(51, 41);
            this.buttonQuitter.TabIndex = 18;
            this.toolTip.SetToolTip(this.buttonQuitter, "Quitter");
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouter.Image")));
            this.buttonAjouter.Location = new System.Drawing.Point(227, 476);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(51, 41);
            this.buttonAjouter.TabIndex = 17;
            this.toolTip.SetToolTip(this.buttonAjouter, "Ajouter");
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonChercher
            // 
            this.buttonChercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChercher.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonChercher.Image = global::GestionEmployes.IHM.Properties.Resources.rechercher;
            this.buttonChercher.Location = new System.Drawing.Point(56, 476);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(51, 40);
            this.buttonChercher.TabIndex = 23;
            this.toolTip.SetToolTip(this.buttonChercher, "Rechercher");
            this.buttonChercher.UseVisualStyleBackColor = true;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(23, 29);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 24;
            this.labelNom.Text = "Nom";
            // 
            // groupBoxId
            // 
            this.groupBoxId.Controls.Add(this.labelCalculAge);
            this.groupBoxId.Controls.Add(this.pictureBox1);
            this.groupBoxId.Controls.Add(this.dateTimePickerNaissance);
            this.groupBoxId.Controls.Add(this.textBoxPrenom);
            this.groupBoxId.Controls.Add(this.textBoxNom);
            this.groupBoxId.Controls.Add(this.labelAge);
            this.groupBoxId.Controls.Add(this.labelDateNaissance);
            this.groupBoxId.Controls.Add(this.labelPrenom);
            this.groupBoxId.Controls.Add(this.labelNom);
            this.groupBoxId.Location = new System.Drawing.Point(59, 73);
            this.groupBoxId.Name = "groupBoxId";
            this.groupBoxId.Size = new System.Drawing.Size(446, 130);
            this.groupBoxId.TabIndex = 25;
            this.groupBoxId.TabStop = false;
            this.groupBoxId.Text = "Identité";
            // 
            // labelCalculAge
            // 
            this.labelCalculAge.AutoSize = true;
            this.labelCalculAge.Location = new System.Drawing.Point(123, 100);
            this.labelCalculAge.Name = "labelCalculAge";
            this.labelCalculAge.Size = new System.Drawing.Size(0, 13);
            this.labelCalculAge.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionEmployes.IHM.Properties.Resources.pasPhoto;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(331, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 114);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePickerNaissance
            // 
            this.dateTimePickerNaissance.Location = new System.Drawing.Point(140, 71);
            this.dateTimePickerNaissance.Name = "dateTimePickerNaissance";
            this.dateTimePickerNaissance.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerNaissance.TabIndex = 30;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(140, 51);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(179, 20);
            this.textBoxPrenom.TabIndex = 29;
            this.toolTip.SetToolTip(this.textBoxPrenom, "Entrer un prénom");
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(140, 27);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(179, 20);
            this.textBoxNom.TabIndex = 28;
            this.toolTip.SetToolTip(this.textBoxNom, "Entrer un nom \r\n");
            this.textBoxNom.MouseEnter += new System.EventHandler(this.textBoxNom_MouseEnter);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(23, 100);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 27;
            this.labelAge.Text = "Age";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(23, 77);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(96, 13);
            this.labelDateNaissance.TabIndex = 26;
            this.labelDateNaissance.Text = "Date de naissance";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(23, 54);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 25;
            this.labelPrenom.Text = "Prénom";
            // 
            // groupBoxContrat
            // 
            this.groupBoxContrat.Controls.Add(this.labelCalculAnciennete);
            this.groupBoxContrat.Controls.Add(this.labelSymboleEuro2);
            this.groupBoxContrat.Controls.Add(this.labelSymboleEuro1);
            this.groupBoxContrat.Controls.Add(this.numericUpDownNet);
            this.groupBoxContrat.Controls.Add(this.numericUpDownBrut);
            this.groupBoxContrat.Controls.Add(this.dateTimePickerEmbauche);
            this.groupBoxContrat.Controls.Add(this.labelSalaireNet);
            this.groupBoxContrat.Controls.Add(this.labelSalaireBrut);
            this.groupBoxContrat.Controls.Add(this.LabelAnciennete);
            this.groupBoxContrat.Controls.Add(this.labelDateEmbauche);
            this.groupBoxContrat.Location = new System.Drawing.Point(59, 209);
            this.groupBoxContrat.Name = "groupBoxContrat";
            this.groupBoxContrat.Size = new System.Drawing.Size(446, 140);
            this.groupBoxContrat.TabIndex = 26;
            this.groupBoxContrat.TabStop = false;
            this.groupBoxContrat.Text = "Contrat";
            // 
            // labelCalculAnciennete
            // 
            this.labelCalculAnciennete.AutoSize = true;
            this.labelCalculAnciennete.Location = new System.Drawing.Point(137, 53);
            this.labelCalculAnciennete.Name = "labelCalculAnciennete";
            this.labelCalculAnciennete.Size = new System.Drawing.Size(0, 13);
            this.labelCalculAnciennete.TabIndex = 40;
            // 
            // labelSymboleEuro2
            // 
            this.labelSymboleEuro2.AutoSize = true;
            this.labelSymboleEuro2.Location = new System.Drawing.Point(328, 104);
            this.labelSymboleEuro2.Name = "labelSymboleEuro2";
            this.labelSymboleEuro2.Size = new System.Drawing.Size(13, 13);
            this.labelSymboleEuro2.TabIndex = 39;
            this.labelSymboleEuro2.Text = "€";
            // 
            // labelSymboleEuro1
            // 
            this.labelSymboleEuro1.AutoSize = true;
            this.labelSymboleEuro1.Location = new System.Drawing.Point(328, 79);
            this.labelSymboleEuro1.Name = "labelSymboleEuro1";
            this.labelSymboleEuro1.Size = new System.Drawing.Size(13, 13);
            this.labelSymboleEuro1.TabIndex = 38;
            this.labelSymboleEuro1.Text = "€";
            // 
            // numericUpDownNet
            // 
            this.numericUpDownNet.Location = new System.Drawing.Point(140, 102);
            this.numericUpDownNet.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownNet.Name = "numericUpDownNet";
            this.numericUpDownNet.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownNet.TabIndex = 37;
            // 
            // numericUpDownBrut
            // 
            this.numericUpDownBrut.Location = new System.Drawing.Point(140, 77);
            this.numericUpDownBrut.Name = "numericUpDownBrut";
            this.numericUpDownBrut.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownBrut.TabIndex = 36;
            // 
            // dateTimePickerEmbauche
            // 
            this.dateTimePickerEmbauche.Location = new System.Drawing.Point(140, 23);
            this.dateTimePickerEmbauche.Name = "dateTimePickerEmbauche";
            this.dateTimePickerEmbauche.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerEmbauche.TabIndex = 32;
            // 
            // labelSalaireNet
            // 
            this.labelSalaireNet.AutoSize = true;
            this.labelSalaireNet.Location = new System.Drawing.Point(26, 104);
            this.labelSalaireNet.Name = "labelSalaireNet";
            this.labelSalaireNet.Size = new System.Drawing.Size(99, 13);
            this.labelSalaireNet.TabIndex = 35;
            this.labelSalaireNet.Text = "Salaire net mensuel";
            // 
            // labelSalaireBrut
            // 
            this.labelSalaireBrut.AutoSize = true;
            this.labelSalaireBrut.Location = new System.Drawing.Point(26, 79);
            this.labelSalaireBrut.Name = "labelSalaireBrut";
            this.labelSalaireBrut.Size = new System.Drawing.Size(102, 13);
            this.labelSalaireBrut.TabIndex = 34;
            this.labelSalaireBrut.Text = "Salaire brut mensuel";
            // 
            // LabelAnciennete
            // 
            this.LabelAnciennete.AutoSize = true;
            this.LabelAnciennete.Location = new System.Drawing.Point(26, 53);
            this.LabelAnciennete.Name = "LabelAnciennete";
            this.LabelAnciennete.Size = new System.Drawing.Size(61, 13);
            this.LabelAnciennete.TabIndex = 33;
            this.LabelAnciennete.Text = "Ancienneté";
            this.LabelAnciennete.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDateEmbauche
            // 
            this.labelDateEmbauche.AutoSize = true;
            this.labelDateEmbauche.Location = new System.Drawing.Point(26, 29);
            this.labelDateEmbauche.Name = "labelDateEmbauche";
            this.labelDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.labelDateEmbauche.TabIndex = 32;
            this.labelDateEmbauche.Text = "Date d\'embauche";
            // 
            // groupBoxAffectation
            // 
            this.groupBoxAffectation.Controls.Add(this.comboBoxResp);
            this.groupBoxAffectation.Controls.Add(this.comboBoxService);
            this.groupBoxAffectation.Controls.Add(this.labelResponsable);
            this.groupBoxAffectation.Controls.Add(this.labelService);
            this.groupBoxAffectation.Location = new System.Drawing.Point(59, 355);
            this.groupBoxAffectation.Name = "groupBoxAffectation";
            this.groupBoxAffectation.Size = new System.Drawing.Size(446, 115);
            this.groupBoxAffectation.TabIndex = 27;
            this.groupBoxAffectation.TabStop = false;
            this.groupBoxAffectation.Text = "Affectation";
            // 
            // comboBoxResp
            // 
            this.comboBoxResp.FormattingEnabled = true;
            this.comboBoxResp.Location = new System.Drawing.Point(140, 64);
            this.comboBoxResp.Name = "comboBoxResp";
            this.comboBoxResp.Size = new System.Drawing.Size(179, 21);
            this.comboBoxResp.TabIndex = 43;
            this.comboBoxResp.Text = "<aucun>";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(140, 29);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(179, 21);
            this.comboBoxService.TabIndex = 42;
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Location = new System.Drawing.Point(23, 67);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(69, 13);
            this.labelResponsable.TabIndex = 41;
            this.labelResponsable.Text = "Responsable";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(23, 32);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 40;
            this.labelService.Text = "Service";
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.FileName = "openFileDialogImport";
            this.openFileDialogImport.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImage_FileOk);
            // 
            // MenuEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 522);
            this.Controls.Add(this.groupBoxAffectation);
            this.Controls.Add(this.groupBoxContrat);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonImporter);
            this.Controls.Add(this.groupBoxTri);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.groupBoxId);
            this.Name = "MenuEmploye";
            this.Text = "MenuEmploye";
            this.groupBoxTri.ResumeLayout(false);
            this.groupBoxTri.PerformLayout();
            this.groupBoxId.ResumeLayout(false);
            this.groupBoxId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxContrat.ResumeLayout(false);
            this.groupBoxContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrut)).EndInit();
            this.groupBoxAffectation.ResumeLayout(false);
            this.groupBoxAffectation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.NavBar navBar;
        private System.Windows.Forms.GroupBox groupBoxTri;
        private System.Windows.Forms.Button buttonImporter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonExporter;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.GroupBox groupBoxId;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaissance;
        private System.Windows.Forms.GroupBox groupBoxContrat;
        private System.Windows.Forms.Label LabelAnciennete;
        private System.Windows.Forms.Label labelDateEmbauche;
        private System.Windows.Forms.Label labelSalaireBrut;
        private System.Windows.Forms.Label labelSalaireNet;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmbauche;
        private System.Windows.Forms.NumericUpDown numericUpDownBrut;
        private System.Windows.Forms.NumericUpDown numericUpDownNet;
        private System.Windows.Forms.Label labelSymboleEuro2;
        private System.Windows.Forms.Label labelSymboleEuro1;
        private System.Windows.Forms.GroupBox groupBoxAffectation;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxResp;
        private System.Windows.Forms.RadioButton radioButtonTriNom;
        private System.Windows.Forms.RadioButton radioButtonTriNaissance;
        private System.Windows.Forms.RadioButton radioButtonTriPrenom;
        private System.Windows.Forms.RadioButton radioButtonTriBrut;
        private System.Windows.Forms.RadioButton radioButtonTriEmbauche;
        private System.Windows.Forms.RadioButton radioButtonTriResp;
        private System.Windows.Forms.RadioButton radioButtonTriService;
        private System.Windows.Forms.Label labelCalculAnciennete;
        private System.Windows.Forms.Label labelCalculAge;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.ToolTip toolTip;
    }
}