using System;
using System.Windows.Forms;
using GestionEmployes.Application;
using GestionEmployes.Metier;

namespace GestionEmployes.IHM.GestionEmploye
{
    public partial class MenuEmploye : Form
    {
        private MgtEmploye mgtEmploye = MgtEmploye.GetInstance();
        private MgtService mgtService = MgtService.getInstance();
        private BindingSource bindingSource = new BindingSource();
        private int index = 0;

        
        public MenuEmploye()
        {
            InitializeComponent();
            bindingSource.DataSource = mgtService.ListeServices;
            comboBoxService.DataSource = mgtService.ListeServices;
            updateNavBar();
            if (mgtEmploye.EmployesListe != null)
            {
               // AfficherEmploye(mgtEmploye.EmployesListe[0]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void AfficherEmploye(Employe employe)
        {
            textBoxNom.Text = employe.Nom;
            textBoxPrenom.Text = employe.Prenom;
            dateTimePickerNaissance.Value = employe.DateNaissance;
            labelCalculAge.Text = Convert.ToString(employe.Age)+" ans";
            dateTimePickerEmbauche.Value = employe.DateEmbauche;
            labelCalculAnciennete.Text = Convert.ToString(employe.Anciennete) + " années";
            numericUpDownNet.Value = Convert.ToDecimal(employe.Salaire);
            if (employe.Service != null)
            {
                comboBoxService.Text = employe.Service.Libelle;               
            }
            if (employe.Chef != null)
            {
                comboBoxResp.Text = employe.Chef.Nom + ' ' + employe.Chef.Prenom;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string ajoutQuestion = "voulez-vous ajouter cet employé ?";
            string ajouter = "employé ajouté";
            if (MessageBox.Show(ajoutQuestion, ajouter, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                mgtEmploye.AjouterEmploye(textBoxNom.Text, textBoxPrenom.Text, dateTimePickerNaissance.Value, 
                    dateTimePickerEmbauche.Value, Convert.ToDouble(numericUpDownNet), null, null);
            }

        }

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            openFileDialogImport.ShowDialog();
        }

        private void buttonExporter_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                OpenFileDialog file = (OpenFileDialog)sender;
                mgtEmploye.EmployesListe = MgtEmploye.Charger(file.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'import fichier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                SaveFileDialog rep = (SaveFileDialog)sender;
                MgtEmploye.Sauvegarder(rep.FileName, mgtEmploye.EmployesListe);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'export fichier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialogImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                OpenFileDialog rep = (OpenFileDialog)sender;
                pictureBox1.ImageLocation = rep.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'import fichier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navBar_Navigation(object sender, WindowsFormsControlLibrary1.NavBarEventArgs e)
        {
            switch (e.NavAction)
            {
                case WindowsFormsControlLibrary1.NavBar.NavActionEnum.Dernier:
                    index = mgtEmploye.EmployesListe.Count - 1;
                    updateNavBar();
                    AfficherEmploye(mgtEmploye.ObtenirEmploye(index));
                    break;
                case WindowsFormsControlLibrary1.NavBar.NavActionEnum.Precedent:
                    index -= 1;
                    updateNavBar();
                    AfficherEmploye(mgtEmploye.ObtenirEmploye(index));
                    break;
                case WindowsFormsControlLibrary1.NavBar.NavActionEnum.Premier:
                    index = 0;
                    updateNavBar();
                    AfficherEmploye(mgtEmploye.ObtenirEmploye(index));
                    break;
                case WindowsFormsControlLibrary1.NavBar.NavActionEnum.Suivant:
                    index += 1;
                    updateNavBar();
                    AfficherEmploye(mgtEmploye.ObtenirEmploye(index));
                    break;
                default:
                    break;
            }
        }

        private void updateNavBar()
        {
            if (index == 0)
            {
                navBar.AvantEnable = false;
                navBar.ApresEnable = true;
            }
            if (index == mgtEmploye.EmployesListe.Count - 1)
            {
                navBar.AvantEnable = true;
                navBar.ApresEnable = false;
            }
            if (index < mgtEmploye.EmployesListe.Count - 1 && index > 0)
            {
                navBar.AvantEnable = true;
                navBar.ApresEnable = true;
            }
            if (mgtEmploye.EmployesListe.Count == 0 || mgtEmploye.EmployesListe.Count == 1)
            {
                navBar.AvantEnable = false;
                navBar.ApresEnable = false;
            }
        }

        #region TOOLTIP
        private void textBoxNom_MouseEnter(object sender, EventArgs e)
        {
           
        }
        #endregion
    }
}
