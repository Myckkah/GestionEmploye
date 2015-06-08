using System.Windows.Forms;

namespace GestionEmployes.IHM
{
    partial class MenuService
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuService));
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonViderListe = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.errorProviderCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouter.Image")));
            this.buttonAjouter.Location = new System.Drawing.Point(147, 199);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(66, 64);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonViderListe
            // 
            this.buttonViderListe.Image = ((System.Drawing.Image)(resources.GetObject("buttonViderListe.Image")));
            this.buttonViderListe.Location = new System.Drawing.Point(463, 25);
            this.buttonViderListe.Name = "buttonViderListe";
            this.buttonViderListe.Size = new System.Drawing.Size(41, 35);
            this.buttonViderListe.TabIndex = 3;
            this.buttonViderListe.UseVisualStyleBackColor = true;
            this.buttonViderListe.Click += new System.EventHandler(this.buttonViderListe_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitter.Image")));
            this.buttonQuitter.Location = new System.Drawing.Point(435, 199);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(69, 64);
            this.buttonQuitter.TabIndex = 5;
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "--- GESTION DES SERVICES ---";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 121);
            this.listBox1.TabIndex = 10;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseClick);
            // 
            // buttonImporter
            // 
            this.buttonImporter.Image = ((System.Drawing.Image)(resources.GetObject("buttonImporter.Image")));
            this.buttonImporter.Location = new System.Drawing.Point(3, 199);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(66, 64);
            this.buttonImporter.TabIndex = 12;
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonImporter_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Image = ((System.Drawing.Image)(resources.GetObject("buttonExporter.Image")));
            this.buttonExporter.Location = new System.Drawing.Point(75, 199);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(66, 64);
            this.buttonExporter.TabIndex = 13;
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonExplorter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupprimer.Image")));
            this.buttonSupprimer.Location = new System.Drawing.Point(219, 199);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(66, 64);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Image = ((System.Drawing.Image)(resources.GetObject("buttonValider.Image")));
            this.buttonValider.Location = new System.Drawing.Point(291, 199);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(66, 64);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnnuler.Image")));
            this.buttonAnnuler.Location = new System.Drawing.Point(363, 199);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(66, 64);
            this.buttonAnnuler.TabIndex = 16;
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(34, 172);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 13);
            this.labelCode.TabIndex = 17;
            this.labelCode.Text = "Code :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(75, 169);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(66, 20);
            this.textBoxCode.TabIndex = 18;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(178, 172);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(43, 13);
            this.labelLibelle.TabIndex = 19;
            this.labelLibelle.Text = "Libellé :";
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(227, 169);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(230, 20);
            this.textBoxLibelle.TabIndex = 20;
            // 
            // errorProviderCode
            // 
            this.errorProviderCode.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // MenuService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 268);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonImporter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonViderListe);
            this.Controls.Add(this.buttonAjouter);
            this.Name = "MenuService";
            this.Text = "GESTION DES SERVICES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonViderListe;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private Button buttonImporter;
        private Button buttonExporter;
        private Button buttonSupprimer;
        private Button buttonValider;
        private Button buttonAnnuler;
        private Label labelCode;
        private TextBox textBoxCode;
        private Label labelLibelle;
        private TextBox textBoxLibelle;
        private ErrorProvider errorProviderCode;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}

