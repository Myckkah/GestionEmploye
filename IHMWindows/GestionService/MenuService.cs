using System;
using System.ComponentModel;
using System.Windows.Forms;
using GestionEmployes.Application;

namespace GestionEmployes.IHM
{
    public partial class MenuService : Form
    {
        private MgtService mgtService = MgtService.getInstance();
        private string code;
        private string libelle;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public MenuService()
        {
            InitializeComponent();
            AfficheService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCode.ReadOnly)
                {
                    textBoxCode.ReadOnly = false;
                }
                string ajoutQuestion = "voulez-vous ajouter cet élément ?";
                string ajouter = "élément ajouté";
                if (MessageBox.Show(ajoutQuestion, ajouter, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    mgtService.AjouterService(textBoxCode.Text, textBoxLibelle.Text);
                }
                textBoxCode.Text = null;
                textBoxLibelle.Text = null;
                AfficheService();
            }
            catch (ApplicationException ae)
            {

                errorProviderCode.SetError(buttonValider, ae.Message);
            }
        }

        private void buttonViderListe_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            string fermeQuestion = "Souhaitez vous fermer l'application ?";
            string ferme = "Fermerture en cours";
            if (MessageBox.Show(fermeQuestion, ferme, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBoxCode.ReadOnly = true;
                textBoxCode.Text = listBox1.SelectedItem.ToString().Substring(0, 5);
                textBoxLibelle.Text = listBox1.SelectedItem.ToString().Substring(6);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs eventArgs)
        {
            listBox1.SelectedItem = null;
            if (textBoxCode.ReadOnly)
            {
                textBoxCode.ReadOnly = false;
            }
            textBoxCode.Text = null;
            textBoxLibelle.Text = null;
        }

        private void buttonValider_Click(object sender, EventArgs eventArgs)
        {
            string modifier = "Element modifié";
            string modifQuestion = "Voulez vous modifier le libellé de cet élément ?";
            if (MessageBox.Show(modifQuestion, modifier, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                mgtService.ModifierService(mgtService.ObtenirService(textBoxCode.Text), textBoxLibelle.Text, textBoxCode.Text);
            }
            if (textBoxCode.ReadOnly)
            {
                textBoxCode.ReadOnly = false;
            }
            AfficheService();
            listBox1.SelectedItem = null;
            textBoxCode.Text = null;
            textBoxLibelle.Text = null;
        }

        public void AfficheService()
        {
            listBox1.Items.Clear();
            foreach (var service in mgtService.ListeServices)
            {
                listBox1.Items.Add(service.Code + " " + service.Libelle);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string suppress = "Elément supprimé";
            string suppresQuestion = "Voulez vous vraiment supprimer cet élément ?";
            if (MessageBox.Show(suppresQuestion, suppress, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                mgtService.SupprimerService(mgtService.ObtenirService(textBoxCode.Text));
            }
            listBox1.SelectedItem = null;
            AfficheService();
            if (textBoxCode.ReadOnly)
            {
                textBoxCode.ReadOnly = false;
            }
            textBoxCode.Text = null;
            textBoxLibelle.Text = null;
        }

        private void buttonExplorter_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                OpenFileDialog file = (OpenFileDialog)sender;
                mgtService.ListeServices = mgtService.Importer(file.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'import fichier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AfficheService();

            Update();

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                SaveFileDialog rep = (SaveFileDialog)sender;
                MgtService.Sauvegarder(rep.FileName, mgtService.ListeServices);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'export fichier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
